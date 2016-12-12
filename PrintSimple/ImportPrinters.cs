using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PrintSimple.Classes;

namespace PrintSimple
{
    public partial class ImportPrinters : Form
    {
        public ImportPrinters()
        {
            InitializeComponent();
        }

        private void btnWelcomeNext_Click(object sender, EventArgs e)
        {
            wizPrinterImport.SelectedIndex += 1;
            var ao = new AppOperations();
            var printerlist =
                ao.getPrinterBuildList(txtSpreadsheetToOpen.Text, cmbWorksheet.SelectedItem.ToString(),
                    (int) cmbStartAtLine.SelectedItem, (int) cmbPrinterDescription.SelectedValue,
                    (int) cmbPrinterDriver.SelectedValue, (int) cmbPrinterName.SelectedValue,
                    (int) cmbPrinterIP.SelectedValue).Select(x => x.PrinterModel).Cast<string>().ToList();
            //dgvDrivers.DataSource = printerlist;
            var linkedmodels = ao.LinkMakeModelToDriver(printerlist);
            dgvDrivers.DataSource = linkedmodels;
            var dgvcolumnmodel = new DataGridViewColumn
            {
                HeaderText = "Model",
                DataPropertyName = "Key"
            };
            var dgvcolumndriver = new DataGridViewColumn
            {
                HeaderText = "Driver",
                DataPropertyName = "Value"
            };
            dgvDrivers.Columns.AddRange(dgvcolumnmodel, dgvcolumndriver);
        }

        private void btnBackPreview_Click(object sender, EventArgs e)
        {
            wizPrinterImport.SelectedIndex -= 1;
        }

        private void btnBrowseForSpreadsheet_Click(object sender, EventArgs e)
        {
            var ao = new AppOperations();
            ofExcelFinder.ShowDialog();
            var path = ofExcelFinder.FileName;

            ofExcelFinder.Dispose();
            txtSpreadsheetToOpen.Text = path;
            cmbWorksheet.DataSource = ao.GetWorksheetsFromSpreadsheet(path);
        }

        private void ImportPrinters_Load(object sender, EventArgs e)
        {
            for (var i = 1; i <= 100; i++)
                cmbStartAtLine.Items.Add(i);
        }

        private void cmbStartAtLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ao = new AppOperations();
            if ((txtSpreadsheetToOpen.Text != null) && (cmbWorksheet.SelectedValue != null) &&
                (cmbStartAtLine.SelectedItem != null))
            {
                var columns = ao.GetColumnsFromSpreadsheet(txtSpreadsheetToOpen.Text,
                    cmbWorksheet.SelectedValue.ToString(), (int) cmbStartAtLine.SelectedItem);
                var keyedcolumns = new Dictionary<int, string>();


                //cmbPrinterName.Items.Clear();
                //cmbPrinterDescription.Items.Clear();
                //cmbPrinterDriver.Items.Clear();
                //cmbPrinterIP.Items.Clear();
                // readd
                //cmbPrinterDescription.Items.AddRange(columns.ToArray<string>());
                //cmbPrinterDriver.Items.AddRange(columns.ToArray<string>());
                //cmbPrinterIP.Items.AddRange(columns.ToArray<string>());
                //cmbPrinterName.Items.AddRange(columns.ToArray<string>());
                foreach (var cell in columns)
                    keyedcolumns.Add(cell.Address.ColumnNumber, cell.GetString());

                cmbPrinterDescription.DataSource = new BindingSource(keyedcolumns, null);
                cmbPrinterDescription.DisplayMember = "Value";
                cmbPrinterDescription.ValueMember = "Key";

                cmbPrinterDriver.DataSource = new BindingSource(keyedcolumns, null);
                cmbPrinterDriver.DisplayMember = "Value";
                cmbPrinterDriver.ValueMember = "Key";

                cmbPrinterIP.DataSource = new BindingSource(keyedcolumns, null);
                cmbPrinterIP.DisplayMember = "Value";
                cmbPrinterIP.ValueMember = "Key";

                cmbPrinterName.DataSource = new BindingSource(keyedcolumns, null);
                cmbPrinterName.DisplayMember = "Value";
                cmbPrinterName.ValueMember = "Key";


                //cmbPrinterDescription.DataSource = columns;
                //cmbPrinterDriver.DataSource = columns;
                //cmbPrinterIP.DataSource = columns;
                //cmbPrinterName.DataSource = columns;
            }
        }
    }
}