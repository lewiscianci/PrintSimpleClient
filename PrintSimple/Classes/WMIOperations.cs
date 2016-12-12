using System;
using System.Management;
using System.Reflection;
using log4net;
using PrintSimple.Properties;

namespace PrintSimple.Classes
{
    internal class WMIOperations
    {
        //string printserver = Properties.Settings.Default?.PrintServers[0];

        //if (Properties.Settings.Default.PrintServers[0] != null)
        //{
        //}


        private static readonly ILog log = LogManager.GetLogger
            (MethodBase.GetCurrentMethod().DeclaringType);

        public ManagementObjectCollection GetObjectsFromWMI(string querystring, string printserver)
        {
            var co = new ConnectionOptions
            {
                Username = Settings.Default.SecureUsername,
                Password = Settings.Default.SecurePassword
            };

            var eo = new EnumerationOptions
            {
                EnumerateDeep = false,
                DirectRead = true
            };

            log.Info(string.Format("Querying WMI on {0}", printserver));
            var scope = new ManagementScope(string.Format("\\\\{0}\\ROOT\\cimv2", printserver), co);
            log.Info("Query:" + querystring);
            var query = new ObjectQuery(querystring);
            var searcher = new ManagementObjectSearcher(scope, query, eo);
            var results = searcher.Get();
            //foreach (var result in results)
            //{
            //    foreach (PropertyData prop in result.Properties)
            //    {

            //        log.Debug("WMI Property Name:" + prop.Name);
            //        log.Debug("WMI Value:" + prop.Value);
            //    }
            //}
            log.Info(string.Format("WMI Query returned {0} objects", results.Count));
            return results;
        }

        public ManagementClass PutObjectsIntoWMI(string objectpath, string printserver)
        {
            var co = new ConnectionOptions
            {
                Username = Settings.Default.SecureUsername,
                Password = Settings.Default.SecurePassword
            };

            var ms = new ManagementScope("\\\\" + printserver + "\\root\\cimv2", co);
            var path = new ManagementPath(objectpath);
            var mclass = new ManagementClass(ms, path, null);

            return mclass;
        }

        public bool RemovePrinterFromPrintServer(string printer, string printserver)
        {
            var printers = GetObjectsFromWMI(string.Format("SELECT * FROM Win32_Printer WHERE Name = '{0}'", printer),
                printserver);

            log.Info(string.Format("Deletion: Removing {0} from {1}. Completed by {2}", printer, printserver,
                Environment.UserName));
            log.Info(
                string.Format(
                    "Deletion: WMI Query for deletion found {0} objects on the server. These will be removed as part of this request.",
                    printers.Count));
            foreach (ManagementObject p in printers)
                try
                {
                    log.Info(string.Format("Deletion: Removing {0}.", p["Name"]));
                    log.Info(string.Format("Deletion: This printer was linked to {0}", p["PortName"]));
                    p.InvokeMethod("CancelAllJobs", null);
                    p.Delete();
                }
                catch (Exception ex)
                {
                    log.Info(string.Format("Deletion: Couldn't remove {0} from {1}", printer, printserver), ex);
                } // TODO This should handle things breaking more eloquently.
            return true;
        }

        public void RemoveTCPIPPortFromPrintServer(string portname, string printserver)
        {
            var ports =
                GetObjectsFromWMI(string.Format("SELECT * FROM Win32_TCPIPPrinterPort WHERE Name = '{0}'", portname),
                    printserver);
            log.Info(string.Format("Port Deletion: Removing {0} from {1}. Completed by {2}", portname, printserver,
                Environment.UserName));
            log.Info(
                string.Format(
                    "Port Deletion: WMI Query found {0} ports for deletion.  These will be removed as part of this request.",
                    ports.Count));
            foreach (ManagementObject mo in ports)
                try
                {
                    log.Info(string.Format("Port Deletion: Removing {0}.", mo["Name"]));
                    log.Info(string.Format("Port Deletion: This port was connected to {0}", mo["HostAddress"]));
                    mo.Delete();
                }
                catch (Exception ex)
                {
                    log.Info(string.Format("Port Deletion: Couldn't remove {0} from {1}", portname, printserver), ex);
                } // TODO This should handle things breaking more eloquently.
        }

        public bool CachePrintersFromPrintServer(string printserver, string guid)
        {
            var printers = GetObjectsFromWMI("SELECT * FROM Win32_Printer", printserver);

            try
            {
                using (var db = new dbPrintSimpleEntities())
                {
                    //log.Info("Connection string is " + db.Connection.ConnectionString);
                    foreach (var o in printers)
                    {
                        var printer = (ManagementObject) o;
                        //string drivername = null;

                        //var drivername = printer.GetRelated(x => x["Name"]).tostring();

                        //foreach (var moc in printer.GetRelated())
                        //{
                        //    drivername = moc["Name"].ToString();
                        //    log.Info("Found driver name: " + moc["Name"]);
                        //}

                        //var wmiRelated = printer.GetRelated("Win32_PrinterConfiguration", null, null, null, null, null, false, null);

                        //string printerdriver = null;

                        //foreach (ManagementBaseObject mbo in wmiRelated)
                        //{

                        //    if (mbo.Properties["Name"].Value != null)
                        //    {

                        //        if (mbo.ClassPath.Path.Contains("Win32_PrinterConfiguration")) // this is hack :( todo fix low pri
                        //        {

                        //            printerdriver = mbo.Properties["Name"].Value.ToString();
                        //            log.Info("DRIVER NAME IS " + mbo.Properties["Name"].Value);

                        //        }
                        //    }
                        //}


                        var p = new tblPrinterClassCache
                        {
                            PrinterName = printer["Name"].ToString(),
                            PrinterPort = printer["PortName"].ToString(),
                            PrinterServer = printserver,
                            CacheGUID = guid
                        };

                        db.tblPrinterClassCaches.Add(p);
                    }
                    db.SaveChanges();
                    return true;
                }
            }

            catch (Exception ex)
            {
                log.Error("Error getting print drivers from server, does the user have rights?", ex);
                return false;
            }
        }

        public bool CacheDriversFromPrintServer(string printserver, string guid)
        {
            var printersDrivers = GetObjectsFromWMI("SELECT Name FROM Win32_PrinterDriver", printserver);

            try
            {
                using (var db = new dbPrintSimpleEntities())
                {
                    foreach (ManagementObject printerDriver in printersDrivers)
                    {
                        //var wmiRelated = printerDriver.GetRelated();
                        //string drivername = null;

                        //foreach (ManagementBaseObject mbo in wmiRelated)
                        //{

                        //    if (mbo.Properties["DriverName"].Value != null)
                        //    {


                        //        drivername = mbo.Properties["DriverName"].Value.ToString();
                        //        log.Info("DRIVER NAME IS " + mbo.Properties["DriverName"].Value);


                        //    }
                        //}

                        var driver = printerDriver["Name"].ToString();
                        driver = driver.Substring(0, driver.IndexOf(',')); // hack sort of, fix todo low pri
                        // wmi defines printer driver as three stupid strings crammed together for no good reason


                        var pdriver = new tblPrinterDriverCache
                        {
                            PrinterDriver = driver,
                            PrinterServer = printserver,
                            CacheGUID = guid
                        };

                        db.tblPrinterDriverCaches.Add(pdriver);
                    }
                    db.SaveChanges();
                    return true;
                }
            }

            catch (Exception ex)
            {
                log.Error("Error when getting drivers from the print server, does the user have rights?", ex);
                return false;
            }
        }

        public bool CacheTCPIPPortsFromPrintServer(string printserver, string guid)
        {
            var printersTCP = GetObjectsFromWMI("SELECT * FROM Win32_TCPIPPrinterPort", printserver);

            try
            {
                using (var db = new dbPrintSimpleEntities())
                {
                    foreach (var printerTCP in printersTCP)
                    {
                        var tcp = new tblPrinterTCPIPClassCache
                        {
                            PortAddress = printerTCP["HostAddress"].ToString(),
                            PortName = printerTCP["Name"].ToString(),
                            CacheGUID = guid
                        };

                        db.tblPrinterTCPIPClassCaches.Add(tcp);
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.Error("Error when querying for TCPIP ports... Does the user have rights?", ex);
                return false;
            }
        }


        public bool isCredentialUsable(string printserver)
        {
            try
            {
                var result = GetObjectsFromWMI("SELECT * FROM Win32_PrinterDriver", printserver);
                if (result != null)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                log.Error("Account used doesn't have the correct WMI rights.", ex);
                return false;
            }
        }


        public bool createPrinter(string name, string drivername, string comment, string printserver)
        {
            using (var printer = PutObjectsIntoWMI("Win32_Printer", printserver).CreateInstance())
            {
                printer["DeviceID"] = name;
                printer["DriverName"] = drivername;
                printer["Sharename"] = name;
                printer["Comment"] = comment;
                printer["PortName"] = name;
                printer.Put();
                return true;
            }
        }

        public bool createPrinterTCPIPPort(string portname, string IPAddress, string printserver)
        {
            using (var tcpipport = PutObjectsIntoWMI("Win32_TCPIPPrinterPort", printserver).CreateInstance())
            {
                tcpipport["Name"] = portname;
                tcpipport["Queue"] = portname;
                tcpipport["HostAddress"] = IPAddress;
                tcpipport["SNMPEnabled"] = false;
                tcpipport["Protocol"] = 2;

                tcpipport.Put();
                return true;
            }
        }

        public class StandardWMIQueries
        {
            //public string AllPrinters
            //{
            //    get
            //    {
            //        return "SELECT * FROM Win32_Printer";
            //    }
            //}
        }
    }
}