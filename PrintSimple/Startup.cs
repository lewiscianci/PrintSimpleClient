using System;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using PrintSimple.Classes;
using PrintSimple.Properties;

namespace PrintSimple
{
    //class WizardPages : TabControl
    //{
    //    protected override void WndProc(ref Message m)
    //    {
    //        // Hide tabs by trapping the TCM_ADJUSTRECT message
    //        if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
    //        else base.WndProc(ref m);
    //    }

    //    private BackgroundWorker backgroundWorker1;

    //    private void InitializeComponent()
    //    {
    //        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
    //        this.SuspendLayout();
    //        this.ResumeLayout(false);

    //    }
    //}

    public partial class Startup : Form
    {
        //private BindingSource bs;
        //private BindingList<Classes.AppOperations.PrinterServerDetails> bl;

        //List<PrintSimple.Classes.AppOperations.PrinterServerDetails> printServers = new List<Classes.AppOperations.PrinterServerDetails>();
        private static readonly ILog log = LogManager.GetLogger
            (MethodBase.GetCurrentMethod().DeclaringType);

        public Startup()
        {
            InitializeComponent();
        }

        private void btnWelcomeNext_Click(object sender, EventArgs e)
        {
            wizStartup.SelectedIndex = wizStartup.SelectedIndex + 1;
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                log.Info("Data directory is " + ApplicationDeployment.CurrentDeployment.DataDirectory);
            else
                log.Info("not deployed via clickonce!!");
            Settings.Default.FirstRun = false;
            //bl = new BindingList<Classes.AppOperations.PrinterServerDetails>();
            //bs = new BindingSource(bl, null);

            //string configpath = null;
            var ao = new AppOperations();
            //if (ao.StartupCheck() != null)
            //{
            //    configpath = ao.CreateConfigFiles();
            //}
            //else
            //{
            //    configpath = ao.StartupCheck();
            //}

            //string[] printservers = null;

            //if (Properties.Settings.Default.PrintServers != null)
            //{
            //    Properties.Settings.Default.PrintServers.CopyTo(printservers, 0);

            //    if (printservers != null)
            //    {

            //        foreach (var printserver in printservers)
            //        {
            //            lbPrintServers.Items.Add(printserver);
            //        }


            //    }
            //}

            if (Settings.Default.PrintServers != null)
                foreach (var printserver in Settings.Default.PrintServers)
                    lbPrintServers.Items.Add(printserver);

            if (Settings.Default.SecureUsername != null)
                txtUsername.Text = Settings.Default.SecureUsername;
            if (Settings.Default.SecurePassword != null)
                txtPassword.Text = Settings.Default.SecurePassword;

            txtDomain.Text = IPGlobalProperties.GetIPGlobalProperties().DomainName;
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            var wmi = new WMIOperations();


            lbPrintServers.Items.Add(txtPrintServer.Text);
            txtPrintServer.Text = null;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            wizStartup.SelectedIndex = wizStartup.SelectedIndex - 1;
        }

        private void btnNextPrintServers_Click(object sender, EventArgs e)
        {
            var ao = new AppOperations();
            //StringBuilder sb = new StringBuilder();
            var printserverlist = new StringCollection();

            foreach (string item in lbPrintServers.Items)
                printserverlist.Add(item);

            Settings.Default.PrintServers = printserverlist;
            Settings.Default.Save();
            //foreach (var listitem in lbPrintServers.Items)
            //{
            //    //ao.SaveConfigSetting("Application", "PrintServers", listitem.ToString());
            //}

            //for (int i = 0; i < lbPrintServers.Items.Count; i++)
            //{
            //    if (i == lbPrintServers.Items.Count)
            //    {
            //        sb.Append(lbPrintServers.Items[i]);
            //    }
            //    else
            //    {
            //        sb.Append(lbPrintServers.Items[i] + ",");
            //    }
            //}
            //ao.SaveConfigSetting("Application", "PrintServers", sb.ToString());

            wizStartup.SelectedIndex = wizStartup.SelectedIndex + 1;
        }

        private void tsRemoveServer_Click(object sender, EventArgs e)
        {
            lbPrintServers.Items.RemoveAt(lbPrintServers.SelectedIndex);
        }

        private void btnVerifyCredentials_Click(object sender, EventArgs e)
        {
            log.Info("Attempting to authenticate with provided credentials...");
            var wmi = new WMIOperations();
            Settings.Default.SecureUsername = txtUsername.Text;
            Settings.Default.SecurePassword = txtPassword.Text; // NOT ENCRYPTED -TODO HIGH PRO
            Settings.Default.Save();
            //ConnectionOptions co = new ConnectionOptions()
            //{
            //    Username = txtUsername.Text,
            //    SecurePassword = new NetworkCredential("", txtPassword.Text).SecurePassword
            //};

            if (wmi.isCredentialUsable(lbPrintServers.Items[0].ToString()))
            {
                log.Info("Credentials valid!");
                btnFinish.Enabled = true;
            }
            else
            {
                log.Info("Credentials aren't valid for this username...");
                MessageBox.Show(string.Format("Those credentials aren't authorised to perform that action on {0}",
                    lbPrintServers.Items[0]));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Hide();
            var mw = new MainWindow();
            mw.Show();
        }
    }
}