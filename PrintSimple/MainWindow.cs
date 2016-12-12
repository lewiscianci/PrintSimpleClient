using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintSimple.Classes;
using PrintSimple.Properties;
using static PrintSimple.Classes.Common;


namespace PrintSimple
{
    public partial class MainWindow : Form
    {
        private DateTime? dtLastCached;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshCache();

            //pbCacheInit.Style = ProgressBarStyle.Marquee;
        }

        private void RefreshCache(bool skipWMI = false, string search = null)
        {
            var app = new AppOperations();
            var wmi = new WMIOperations();
            //dtLastCached = DateTime.Now;
            Task.Run(() =>
            {
                tsCacheLastRefreshed.Text = "Cache is being refreshed...";
                if (!skipWMI)
                {
                    var cacheRefreshStatus = app.RegenerateCache();
                    dtLastCached = DateTime.Now;
                    tsCacheLastRefreshed.Text = "Cache last refreshed at " + dtLastCached;
                }
            }).ContinueWith(enable =>
            {
                lvPrinters.InvokeIfRequired(() =>
                {
                    lvPrinters.Visible = true;
                    // pull info from local db
                    lvPrinters.Clear();
                    lvPrinters.Enabled = false;
                    lvPrinters.BeginUpdate();
                });
                label1.InvokeIfRequired(() => { label1.Visible = false; });
                pbCacheInit.InvokeIfRequired(() => { pbCacheInit.Visible = false; });
                lvPrinters.InvokeIfRequired(() =>
                {
                    if (search == null)
                    {
                        lvPrinters.Clear();
                        foreach (var printer in app.GetPrinterClassFromCache().GroupBy(x => x.PrinterName))
                            lvPrinters.Items.Add(ListViewItemPrinterFactory(printer));
                    }
                    else
                    {
                        lvPrinters.Clear();
                        foreach (
                            var printer in
                            app.GetPrinterClassFromCache()
                                .Where(p => p.PrinterName.Contains(search))
                                .GroupBy(x => x.PrinterName))
                            lvPrinters.Items.Add(ListViewItemPrinterFactory(printer));
                    }

                    lvPrinters.Enabled = true;
                    lvPrinters.EndUpdate();
                });
            });
            //});
        }

        private void newPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var np = new NewPrinter();
            np.Show();
        }

        private void reinitilizePrinterCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvPrinters.Items.Clear();
            lvPrinters.Visible = false;
            pbCacheInit.Visible = true;
            label1.Visible = true;
            MainWindow_Load(null, null);
        }

        private void createBogusPrintersOnTheServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            for (var i = 0; i < 2000; i++)
            {
                var wmi = new WMIOperations();

                foreach (var server in Settings.Default.PrintServers)
                {
                    var name = rand.Next(1000, 8000).ToString();

                    wmi.createPrinterTCPIPPort(name, "10.21.23.2", server);
                    wmi.createPrinter(name, "Dell Color PCL Printer Driver", "potato!", server);
                }
            }
        }

        private void cmPrinterContextMenu_Opening(object sender, CancelEventArgs e)
        {
        }

        private void removePrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lbPrintServers.Items.RemoveAt(lbPrintServers.SelectedIndex);
            var printerstoremove = new List<string>();

            foreach (ListViewItem printer in lvPrinters.SelectedItems)
                printerstoremove.Add(printer.Text);


            var rp = new RemovePrinter(printerstoremove);
            rp.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var printer = lvPrinters.Items[lvPrinters.SelectedIndices[0]];
            var pd = new PrinterDetails(printer.Text);
            pd.Show();
        }

        private void timCacheRefresher_Tick(object sender, EventArgs e)
        {
            RefreshCache();
        }

        private void timUpdateTimeSinceCached_Tick(object sender, EventArgs e)
        {
            if (dtLastCached.HasValue)
            {
                var span = DateTime.Now - (DateTime) dtLastCached;
                tsCacheLastRefreshed.Text = "Cache refreshed at " + dtLastCached.Value.ToShortTimeString() + "(" +
                                            Math.Round(span.TotalMinutes) + " minutes ago).";
            }
        }

        private void txtPrinterSearch_TextChanged(object sender, EventArgs e)
        {
            var ao = new AppOperations();

            lvPrinters.Items.Clear();

            //if (txtPrinterSearch.Text.Length > 3)
            //{
            var printers =
                ao.GetPrinterClassFromCache().Where(x => x.PrinterName.Contains(txtPrinterSearch.Text)).Distinct();
            foreach (var printer in printers)
                RefreshCache(true, txtPrinterSearch.Text);
            //}
        }

        private ListViewItem ListViewItemPrinterFactory(IGrouping<string, tblPrinterClassCache> groupedprinter)
        {
            var ao = new AppOperations();

            var lvi = new ListViewItem
            {
                Text = groupedprinter.Key
            };

            if (groupedprinter.Count() == Settings.Default.PrintServers.Count)
                lvi.ImageIndex = 0;
            else
                lvi.ImageIndex = 1;
            lvi.ToolTipText = string.Format("This printer is installed on {0} of {1} print servers.",
                groupedprinter.Count(), Settings.Default.PrintServers.Count);
            return lvi;
        }

        private void lvPrinters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var pd = new PrinterDetails(lvPrinters.Items[lvPrinters.SelectedIndices[0]].Text);
            pd.Show();
        }

        private void reconfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sup = new Startup();
            sup.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void directDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new DirectDB();
            db.Show();
        }

        private void fromSpreadsheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var im = new ImportPrinters();
            im.Show();
        }


        //}

        //    return lvi;
        //    }
        //        lvi.ImageIndex = 1;
        //    {
        //    else
        //    }
        //        lvi.ImageIndex = 0;
        //    {

        //    if (ao.isOnAllPrintServers(printer))
        //    };
        //        Text = printer
        //    {

        //    ListViewItem lvi = new ListViewItem()
        //    Classes.AppOperations ao = new Classes.AppOperations();
        //{

        //private ListViewItem ListViewItemPrinterFactory(string printer, int count)
    }
}