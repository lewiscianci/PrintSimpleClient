using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintSimple.Classes;
using static PrintSimple.Classes.Common;


namespace PrintSimple
{
    public partial class RemovePrinter : Form
    {
        public List<AppOperations.PrinterDetails> PrinterRemovals;
        private readonly List<string> printerstoremove = new List<string>();


        public RemovePrinter(List<string> printers)
        {
            InitializeComponent();
            printerstoremove = printers;

            //lblPrinter.Text = printer;
        }


        private void RemovePrinter_Load(object sender, EventArgs e)
        {
            //string printer = lblPrinter.Text;

            Task.Run(() =>
            {
                foreach (var printer in printerstoremove)
                {
                    var ao = new AppOperations();

                    PrinterRemovals = (from p in ao.GetPrinterClassFromCache()
                        where printerstoremove.Contains(p.PrinterName)
                        select new AppOperations.PrinterDetails
                        {
                            PrinterName = p.PrinterName,
                            PortName = p.PrinterPort,
                            PrinterServer = p.PrinterServer
                        }).ToList();

                    foreach (var p in PrinterRemovals)
                        lbActions.InvokeIfRequired(() =>
                        {
                            lbActions.Items.Add(
                                string.Format(
                                    "Printer {0} will have all print jobs deleted from the queue, if any exist",
                                    p.PrinterName));
                            lbActions.Items.Add(string.Format("Printer {0} will be removed from {1}", p.PrinterName,
                                p.PrinterServer));
                            lbActions.Items.Add(string.Format("TCPIP Port {0} will be removed from {1}", p.PortName,
                                p.PrinterServer));
                        });
                }
            });
        }

        private void btnRemovePrinter_Click(object sender, EventArgs e)
        {
            btnRemovePrinter.Visible = false;
            pbDeletion.Visible = true;


            Task.Run(() =>
            {
                var wmi = new WMIOperations();
                foreach (var printer in PrinterRemovals)
                {
                    wmi.RemovePrinterFromPrintServer(printer.PrinterName, printer.PrinterServer);
                    wmi.RemoveTCPIPPortFromPrintServer(printer.PortName, printer.PrinterServer);
                }

                this.InvokeIfRequired(() => { Hide(); });
            });
        }
    }
}