using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security;
using ClosedXML.Excel;
using log4net;
using PrintSimple.Properties;

namespace PrintSimple.Classes
{
    public class AppOperations
    {
        private static readonly ILog log = LogManager.GetLogger
            (MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string settingspath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AzimuthApps",
                "PrintSimple", "Config.xml");

        public string StartupCheck()
            ///
            /// This function checks if the startup file in Application Data.
            /// Returns path of config file if it exists, null if it doesn't.
            /// 
            ///
        {
            log.Info("Startup check invoked");
            Settings.Default["potato"] = true;

            log.Info(string.Format("Checking in {0} for existing settings...", settingspath));
            if (!File.Exists(settingspath))
            {
                log.Info("Settings file not found.");
                return settingspath;
            }
            log.Info("Setting file found!");
            return null;
        }

        public bool RegenerateCache()
            ///
            /// Regenerates the cache and populates the database tables with printer information.
            /// Stores older printer details for historical purposes.
            ///

        {
            try
            {
                var wmi = new WMIOperations();
                var guid = Guid.NewGuid();

                //wmi.CacheDriversFromPrintServer(Properties.Settings.Default.PrintServers[0], guid.ToString());
                //wmi.CachePrintersFromPrintServer(Properties.Settings.Default.PrintServers[0]);
                //wmi.CacheTCPIPPortsFromPrintServer(Properties.Settings.Default.PrintServers[0]);
                foreach (var printserver in Settings.Default.PrintServers)
                {
                    wmi.CachePrintersFromPrintServer(printserver, guid.ToString());
                    wmi.CacheTCPIPPortsFromPrintServer(printserver, guid.ToString());
                    wmi.CacheDriversFromPrintServer(printserver, guid.ToString());
                    var cache = new tblCacheUpdate
                    {
                        CacheUpdateGUID = guid.ToString(),
                        CacheUpdateTime = DateTime.Now
                    };
                    using (var db = new dbPrintSimpleEntities())
                    {
                        //db.GetTable<tblCacheUpdate>().InsertOnSubmit(cache);
                        //db.SubmitChanges();
                        db.tblCacheUpdates.Add(cache);
                        db.SaveChanges(); // linq updated to EF  - LC 12/12/16
                    }
                }

                //Properties.Settings.Default.CurrentCache = guid.ToString();

                return true;
            }


            catch (Exception ex)
            {
                log.Error("Couldn't regenerate cache!", ex);
                return false;
            }
        }

        public bool isOnAllPrintServers(string printer)
        {
            var printservercount = Settings.Default.PrintServers.Count;

            using (var db = new dbPrintSimpleEntities())
            {
                var installedon = (from p in db.tblPrinterClassCaches
                    where (p.PrinterName == printer) && (p.CacheGUID == mostRecentCacheID())
                    select p).Count();

                if (installedon < printservercount)
                    return false;
                return true;
            }
        }

        public List<tblPrinterClassCache> GetPrinterClassFromCache(bool mostRecent = true)
        {
            using (var db = new dbPrintSimpleEntities())
            {
                if (mostRecent)
                {
                    var q = from p in db.tblPrinterClassCaches
                        where p.CacheGUID == mostRecentCacheID()
                        select p;
                    if (q.Count() > 0)
                        log.Info(
                            string.Format("Cache Request: Retreving cached printer details from cache identifier {0}",
                                q.FirstOrDefault().CacheGUID));
                    else
                        log.Info(
                            "The cache is empty! Either something has broken or there aren't any printers to retrieve.");
                    return q.ToList();
                }
                else
                {
                    var q = from p in db.tblPrinterClassCaches
                        select p;
                    log.Info("Cache Request: Returning everything from printer cache.");
                    return q.ToList();
                }
            }
        }

        public List<tblPrinterClassCache> SearchPrinterCache(string printer)
        {
            var q = from p in GetPrinterClassFromCache()
                where p.PrinterName == printer
                select p;

            return q.ToList();
        }

        public string mostRecentCacheID()
        {
            using (var db = new dbPrintSimpleEntities())
            {
                return db.tblCacheUpdates.OrderByDescending(x => x.ID).FirstOrDefault().CacheUpdateGUID;
            }
        }

        public List<PrinterDrivers> GetPrinterDriversFromCache()
        {
            using (var db = new dbPrintSimpleEntities())
            {
                var q = (from p in db.tblPrinterDriverCaches
                    where p.CacheGUID == mostRecentCacheID()
                    group p by p.PrinterDriver
                    into g
                    select g
                ).ToList().Select(g => new PrinterDrivers
                {
                    DriverName = g.Key,
                    InstalledOn = ServersWithThisDriver(g.Key),
                    Usable = g.Count() == Settings.Default.PrintServers.Count
                });
                return q.ToList();
            }
        }

        public List<string> ServersWithThisDriver(string driver)
        {
            using (var db = new dbPrintSimpleEntities())
            {
                var q = from p in db.tblPrinterDriverCaches
                    where (p.CacheGUID == mostRecentCacheID()) && (p.PrinterDriver == driver)
                    select p.PrinterServer;

                return q.Distinct().ToList();
            }
        }

        public List<tblPrinterTCPIPClassCache> GetTCPIPClassFromCache(bool mostRecent = true)
        {
            using (var db = new dbPrintSimpleEntities())
            {
                if (mostRecent)
                {
                    var q = from p in db.tblPrinterTCPIPClassCaches
                        where
                        p.CacheGUID == db.tblCacheUpdates.OrderByDescending(x => x.ID).FirstOrDefault().CacheUpdateGUID
                        select p;
                    log.Info(string.Format("Cache Request: Retreving cached TCP details from cache identifier {0}",
                        q.FirstOrDefault().CacheGUID));
                    return q.ToList();
                }
                else
                {
                    var q = from p in db.tblPrinterTCPIPClassCaches
                        select p;
                    log.Info("Cache Request: Returning everything from TCP cache.");
                    return q.ToList();
                }
            }
        }

        public List<PrinterChecks> ErrorCheckPrinters(string printer)
            ///
            /// Checks all the servers specified in the preferences file for the existance of this server.
            /// Returns detailed information on issues found.
            ///
        {
            var pc = new List<PrinterChecks>();


            var printservers = Settings.Default.PrintServers.Cast<string>().ToList();

            /// Checks if the printer exists on all print servers.

            var thisprinter = GetPrinterClassFromCache().Where(x => x.PrinterName == printer);
            var installedon = thisprinter.Select(x => x.PrinterServer).ToList();
            var notinstalledon = printservers.Except(installedon);
            if (notinstalledon.Count() > 0)
                foreach (var n in notinstalledon)
                    pc.Add(new PrinterChecks
                    {
                        CheckText =
                            string.Format(
                                "This printer isn't installed on {0}.  In environments where printer jobs are load balanced across multiple print servers, this may produce inconsistent results.",
                                n),
                        ErrorLevel = 1,
                        PrinterName = printer,
                        PrinterServer = n
                    });
            else
                pc.Add(new PrinterChecks
                {
                    CheckText = "This printer is installed on all print servers.",
                    ErrorLevel = 0,
                    PrinterName = printer
                });

            /// Checks if the printer is responding to ping.
            /// 

            if (PingHost(getPortDetails(printer).PortAddress))
                pc.Add(new PrinterChecks
                {
                    CheckText =
                        "This printer is responding to network ping.  This indicates that it should be able to recieve print jobs.",
                    ErrorLevel = 0,
                    PrinterName = printer
                });
            else
                pc.Add(new PrinterChecks
                {
                    CheckText =
                        "This printer isn't responding to network ping.  This could be due to the printer being offline (or your computer can't see this printer on the network)",
                    ErrorLevel = 1,
                    PrinterName = printer
                });


            return pc;
        }

        public tblPrinterTCPIPClassCache getPortDetails(string printer)
        {
            using (var db = new dbPrintSimpleEntities())
            {
                var portname =
                    db.tblPrinterClassCaches.Where(
                            x => (x.PrinterName == printer) && (x.CacheGUID == mostRecentCacheID()))
                        .OrderByDescending(i => i.ID)
                        .FirstOrDefault()
                        .PrinterPort;
                return
                    db.tblPrinterTCPIPClassCaches.Where(
                            x => (x.PortName == portname) && (x.CacheGUID == mostRecentCacheID()))
                        .OrderByDescending(i => i.ID)
                        .FirstOrDefault();
            }
        }

        public static bool PingHost(string nameOrAddress)
        {
            var pingable = false;
            var pinger = new Ping();
            try
            {
                var reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            return pingable;
        }

        public List<string> GetWorksheetsFromSpreadsheet(string spreadsheet)
        {
            //FileStream fs = new FileStream(spreadsheet, FileMode.Open);
            //XLWorkbook wb = new XLWorkbook(fs);
            //var fs = File.OpenRead(spreadsheet);
            //fs.ReadTimeout = 5000;
            //fs.WriteTimeout = 5000;
            using (var workbook = new XLWorkbook(spreadsheet))
            {
                var worksheets = workbook.Worksheets.Select(x => x.Name).Cast<string>().ToList();
                //workbook.Dispose(); // closedxml implements idisposable, yay
                return worksheets;
            }
            //var wb = new XLWorkbook(spreadsheet);
        }

        public List<IXLCell> GetColumnsFromSpreadsheet(string spreadsheet, string worksheet, int starton)
        {
            using (var wb = new XLWorkbook(spreadsheet))
            {
                //int lastcol = wb.Worksheet(worksheet).LastColumnUsed().RangeAddress;

                //return wb.Worksheet(worksheet).Row(starton).Cells(1, 20).Select(x => x.GetString()).ToList();
                return wb.Worksheet(worksheet).Row(starton).Cells(1, 20).ToList();
            }
        }

        public List<PrinterImportDetails> getPrinterBuildList(string spreadsheet, string worksheet, int starton,
            int descriptioncol, int drivercol, int namecol, int ipcol)
        {
            using (var wb = new XLWorkbook(spreadsheet))
            {
                var pidlist = new List<PrinterImportDetails>();

                using (var ws = wb.Worksheet(worksheet))
                {
                    var descriptions =
                        ws.Column(descriptioncol)
                            .Cells(starton, ws.LastCellUsed().Address.RowNumber)
                            .Select(x => x.GetString())
                            .ToList();
                    var drivers =
                        ws.Column(drivercol)
                            .Cells(starton, ws.LastCellUsed().Address.RowNumber)
                            .Select(x => x.GetString())
                            .ToList();
                    var names =
                        ws.Column(namecol)
                            .Cells(starton, ws.LastCellUsed().Address.RowNumber)
                            .Select(x => x.GetString())
                            .ToList();
                    var ips =
                        ws.Column(ipcol)
                            .Cells(starton, ws.LastCellUsed().Address.RowNumber)
                            .Select(x => x.GetString())
                            .ToList();
                    for (var i = 1; i < descriptions.Count(); i++)
                        if ((descriptions[i] == null) || (ips[i] == null) || (names[i] == null) || (drivers[i] == null))
                        {
                            log.Info("On index " + i + " the spreadsheet failed the null check");
                            break;
                        }
                        else
                        {
                            //}

                            var pid = new PrinterImportDetails
                            {
                                PrinterComment = descriptions[i],
                                PrinterIP = ips[i],
                                PrinterName = names[i],
                                PrinterModel = drivers[i]
                            };
                            pidlist.Add(pid);
                        }
                    return pidlist;
                }
            }
        }

        public Dictionary<string, string> LinkMakeModelToDriver(List<string> makemodels)
        {
            var linkedmodels = new Dictionary<string, string>();
            using (var db = new dbPrintSimpleEntities())
            {
                foreach (var makemodel in makemodels.Distinct())
                {
                    var linkeddriver = (from d in db.tblMatchedDrivers
                        where d.PrinterMakeModel == makemodel
                        select d.PrinterMatchedDriver).FirstOrDefault();

                    if (linkeddriver != null)
                        linkedmodels.Add(makemodel, linkeddriver);
                    else
                        linkedmodels.Add(makemodel, null);
                }
            }

            return linkedmodels;
        }

        public void LinkMakeModelToDriver(string model, string driver)
        {
            using (var db = new dbPrintSimpleEntities())
            {
                // remove old references
                var oldreferences = from p in db.tblMatchedDrivers
                    where p.PrinterMakeModel == model
                    select p;

                foreach (var oldreference in oldreferences)
                    db.tblMatchedDrivers.Remove(oldreference);

                db.SaveChanges();

                // add new reference

                var matcheddriver = new tblMatchedDriver
                {
                    PrinterMakeModel = model,
                    PrinterMatchedDriver = driver
                };

                db.tblMatchedDrivers.Add(matcheddriver);
                db.SaveChanges();
            }
        }

        public class PrinterServerDetails
        {
            public string PrinterServer { get; set; }
            public bool PrinterServerUsable { get; set; }
        }

        public class SecureCredentials
        {
            public string username { get; set; }
            public SecureString password { get; set; }
        }

        public class PrinterDetails
        {
            public string PrinterName { get; set; }
            public string PrinterServer { get; set; }
            public string PortName { get; set; }
            public string PrinterIP { get; set; }
            public string PrinterComment { get; set; }
        }

        public class PrinterImportDetails
        {
            public string PrinterName { get; set; }
            public string PrinterIP { get; set; }
            public string PrinterComment { get; set; }
            public string PrinterModel { get; set; }
            public string PrinterMatchedDriver { get; set; }
            public bool PrinterBuildable { get; set; }
        }

        public class PrinterChecks
        {
            public string PrinterName { get; set; }
            public string PrinterServer { get; set; }
            public int ErrorLevel { get; set; } //0 is good, 1 is warning, 2 is something broken
            public string CheckText { get; set; }
        }

        public class PrinterDrivers
        {
            public string DriverName { get; set; }
            public bool Usable { get; set; }
            public List<string> InstalledOn { get; set; }
        }

        //    }
        //        return null;
        //        log.Fatal("Couldn't create new settings file", ex);
        //    {
        //    catch (Exception ex)
        //    }
        //        return settingspath;
        //        log.Info("Successfully created config file at " + settingspath);
        //        SaveConfigSetting("Application", "FirstRun", "false");
        //        xdoc.Save(settingspath);
        //        XDocument xdoc = new XDocument();
        //        //File.Create(settingspath);
        //        Directory.CreateDirectory(Path.GetDirectoryName(settingspath));
        //    {

        //    try
        //{
        /////
        /////
        ///// NULL means the creation didn't work.
        ///// Creates application configuration files, and returns the path of the created files.
        /////

        //public string CreateConfigFiles()

        //}
        //{


        //public int ColumnNameToInt(string colname)

        //}

        //public bool SaveConfigSetting(string category, string key, string value)
        //{
        //    log.Info("Attempting to write values to XML config.");
        //    log.Info(String.Format("Category:{0}, Key:{1}, Value:{2}, ConfigFilePath:{3}", category, key, value, settingspath));
        //    try
        //    {
        //        XDocument xdoc = XDocument.Load(settingspath);
        //        xdoc.Element(category).Add(new XElement(key, value));
        //        xdoc.Save(settingspath);
        //        log.Info("Successfully wrote setting to XML configuration.");
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error while trying to write config.", ex);
        //        return false;
        //        //break;
        //        //throw (ex);
        //    }
        //}

        //public List<XElement> LoadConfigSetting(string category, string key)
        //{
        //    log.Info("Attempting to load setting from XML config.");
        //    log.Info(string.Format("Category:{0}, Key:{1}, ConfigFilePath:{2}", category, key, settingspath));

        //    try
        //    {
        //        XDocument xdoc = XDocument.Load(settingspath);
        //        var configElements = xdoc.Element(category).Elements(key);
        //        if (configElements.Count() == 0)
        //        {
        //            return null; // nothing loaded/found
        //        }
        //        else
        //        {

        //            return configElements.ToList();

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Can't load config setting.", ex);
        //        return null;
        //    }

        //}
    }
}