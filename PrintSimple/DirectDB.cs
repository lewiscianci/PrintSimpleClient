using System;
using System.Windows.Forms;

namespace PrintSimple
{
    public partial class DirectDB : Form
    {
        public DirectDB()
        {
            InitializeComponent();
        }

        private void DirectDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printSimpleCacheDataSet.tblPrinterDriverCache' table. You can move, or remove it, as needed.
            tblPrinterDriverCacheTableAdapter.Fill(printSimpleCacheDataSet.tblPrinterDriverCache);
            // TODO: This line of code loads data into the 'printSimpleCacheDataSet.tblPrinterTCPIPClassCache' table. You can move, or remove it, as needed.
            tblPrinterTCPIPClassCacheTableAdapter.Fill(printSimpleCacheDataSet.tblPrinterTCPIPClassCache);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                tblPrinterTCPIPClassCacheTableAdapter.FillBy(printSimpleCacheDataSet.tblPrinterTCPIPClassCache);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}