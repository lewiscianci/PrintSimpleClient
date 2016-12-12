using System;
using System.Linq;
using System.Windows.Forms;
using PrintSimple.Classes;
using PrintSimple.Properties;

namespace PrintSimple
{
    public partial class NewPrinter : Form
    {
        public NewPrinter()
        {
            InitializeComponent();
        }

        private void NewPrinter_Load(object sender, EventArgs e)
        {
            var ao = new AppOperations();

            var drivers = ao.GetPrinterDriversFromCache();
            //cmbPrinterDriver.DataSource = drivers.Select(x => x.PrinterDriver).OrderBy(x => x);

            foreach (var driver in drivers)
                if (driver.DriverName != null)
                    cmbPrinterDriver.Items.Add(driver.DriverName);

            //var printservers = Properties.Settings.Default.PrintServers;
            //foreach (var printserver in printservers)
            //{
            //    clbPrintServers.Items.Add(printserver);

            //}
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var wmi = new WMIOperations();
            //wmi.createPrinterTCPIPPort(txtPrinterIP.Text, txtPrinterIP.Text, )
            foreach (ListViewItem printserver in lvPrintServers.CheckedItems)
            {
                wmi.createPrinterTCPIPPort(txtPrinterName.Text, txtPrinterIP.Text, printserver.Text);
                wmi.createPrinter(txtPrinterName.Text, cmbPrinterDriver.SelectedItem.ToString(), txtPrinterDesc.Text,
                    printserver.Text);
            }
        }

        private void cmbPrinterDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ao = new AppOperations();

            lvPrintServers.Items.Clear();
            var printservers =
                ao.GetPrinterDriversFromCache()
                    .Where(x => x.DriverName == (string) cmbPrinterDriver.SelectedItem)
                    .FirstOrDefault()
                    .InstalledOn;
            gbPrintServers.Text = string.Format("Print Servers - (Driver availible on {0} of {1} print servers)",
                printservers.Count(), Settings.Default.PrintServers.Count);

            foreach (var printserver in printservers)
                lvPrintServers.Items.Add(printserver);

            //foreach (var printserver in printservers)
            //{
            //    foreach (var p in printserver.InstalledOn)
            //    {

            //    ListViewItem lvi = new ListViewItem();
            //    lvi.Text = p;
            //    //if (!printserver.Usable)
            //    //{
            //    //    lvi.ForeColor = SystemColors.GrayText;
            //    //    lvi.Text += "Unavailible";
            //    //    lvi.BackColor = SystemColors.InactiveBorder;
            //    //    lvi.Selected = false;
            //    //    lvi.Tag = "unavailible";
            //    //}
            //    lvPrintServers.Items.Add(lvi);

            //    }

            //}

            //lvPrintServers.Items.Clear();
            //var printdrivers = 

            //foreach (var printdriver in printdrivers)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.Text = printdriver.DriverName;
            //    if (!printdriver.Usable)
            //    {
            //        lvi.ForeColor = Color.Gray;
            //        lvi.Text = lvi.Text + " - Not "
            //    }

            //}
        }

        private void lvPrintServers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //if (e.Item.Tag != null || e.Item.Tag.ToString() == "unavailible")
            //{
            //    e.Item.Checked = false;
            //}
        }
    }
}