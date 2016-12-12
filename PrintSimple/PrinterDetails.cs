using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintSimple.Classes;
using static PrintSimple.Classes.Common;

namespace PrintSimple
{
    public partial class PrinterDetails : Form
    {
        public PrinterDetails(string printer)
        {
            InitializeComponent();
            lblPrinterName.Text = printer;
        }

        private void PrinterDetails_Load(object sender, EventArgs e)
        {
            Task.Run(() =>

            {
                var ao = new AppOperations();

                var printercheck = ao.ErrorCheckPrinters(lblPrinterName.Text);

                foreach (var pc in printercheck)
                {
                    var lvi = new ListViewItem
                    {
                        Text = pc.CheckText,
                        ImageIndex = pc.ErrorLevel,
                        ToolTipText = pc.CheckText
                    };
                    lvHealthCheck.InvokeIfRequired(() => { lvHealthCheck.Items.Add(lvi); });
                    //lvHealthCheck.Items.Add(lvi);
                }

                foreach (var printer in ao.SearchPrinterCache(lblPrinterName.Text))
                {
                    //lbInstalledOnPrintServers.Items.Add(printer.PrinterServer);
                    var tn = new TreeNode
                    {
                        Text = printer.PrinterServer
                    };
                    var tnpn = new TreeNode
                    {
                        Text = printer.PrinterName
                    };
                    if (printer.PrinterPort != null)
                    {
                        var tnpp = new TreeNode
                        {
                            Text = "Port:" + printer.PrinterPort
                        };
                        tn.Nodes.Add(tnpp);
                    }

                    tn.Nodes.Add(tnpn);

                    treeView1.InvokeIfRequired(() => { treeView1.Nodes.Add(tn); });
                }

                treeView1.InvokeIfRequired(() => { treeView1.ExpandAll(); });
            });
        }
    }
}