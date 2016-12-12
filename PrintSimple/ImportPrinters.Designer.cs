namespace PrintSimple
{
    partial class ImportPrinters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofExcelFinder = new System.Windows.Forms.OpenFileDialog();
            this.wizPrinterImport = new PrintSimple.WizardPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnWelcomeNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPrinterDriver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrinterIP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrinterDescription = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPrinterName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbWorksheet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStartAtLine = new System.Windows.Forms.ComboBox();
            this.btnBrowseForSpreadsheet = new System.Windows.Forms.Button();
            this.txtSpreadsheetToOpen = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBackPreview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.clmMakeModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDriverToUse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wizPrinterImport.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofExcelFinder
            // 
            this.ofExcelFinder.FileName = "openFileDialog1";
            this.ofExcelFinder.Filter = "Excel Spreadsheet|*.xlsx|All files|*.*";
            // 
            // wizPrinterImport
            // 
            this.wizPrinterImport.Controls.Add(this.tabPage1);
            this.wizPrinterImport.Controls.Add(this.tabPage2);
            this.wizPrinterImport.Controls.Add(this.tabPage3);
            this.wizPrinterImport.Controls.Add(this.tabPage4);
            this.wizPrinterImport.Location = new System.Drawing.Point(12, 12);
            this.wizPrinterImport.Name = "wizPrinterImport";
            this.wizPrinterImport.SelectedIndex = 0;
            this.wizPrinterImport.Size = new System.Drawing.Size(603, 320);
            this.wizPrinterImport.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnWelcomeNext);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnWelcomeNext
            // 
            this.btnWelcomeNext.Location = new System.Drawing.Point(508, 265);
            this.btnWelcomeNext.Name = "btnWelcomeNext";
            this.btnWelcomeNext.Size = new System.Drawing.Size(75, 23);
            this.btnWelcomeNext.TabIndex = 1;
            this.btnWelcomeNext.Text = "Next";
            this.btnWelcomeNext.UseVisualStyleBackColor = true;
            this.btnWelcomeNext.Click += new System.EventHandler(this.btnWelcomeNext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPrinterDriver);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbPrinterIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbPrinterDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbPrinterName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Link the data";
            // 
            // cmbPrinterDriver
            // 
            this.cmbPrinterDriver.FormattingEnabled = true;
            this.cmbPrinterDriver.Location = new System.Drawing.Point(312, 101);
            this.cmbPrinterDriver.Name = "cmbPrinterDriver";
            this.cmbPrinterDriver.Size = new System.Drawing.Size(265, 21);
            this.cmbPrinterDriver.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Printer Driver";
            // 
            // cmbPrinterIP
            // 
            this.cmbPrinterIP.FormattingEnabled = true;
            this.cmbPrinterIP.Location = new System.Drawing.Point(312, 74);
            this.cmbPrinterIP.Name = "cmbPrinterIP";
            this.cmbPrinterIP.Size = new System.Drawing.Size(265, 21);
            this.cmbPrinterIP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Printer IP";
            // 
            // cmbPrinterDescription
            // 
            this.cmbPrinterDescription.FormattingEnabled = true;
            this.cmbPrinterDescription.Location = new System.Drawing.Point(312, 47);
            this.cmbPrinterDescription.Name = "cmbPrinterDescription";
            this.cmbPrinterDescription.Size = new System.Drawing.Size(265, 21);
            this.cmbPrinterDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Printer Description";
            // 
            // cmbPrinterName
            // 
            this.cmbPrinterName.FormattingEnabled = true;
            this.cmbPrinterName.Location = new System.Drawing.Point(312, 20);
            this.cmbPrinterName.Name = "cmbPrinterName";
            this.cmbPrinterName.Size = new System.Drawing.Size(265, 21);
            this.cmbPrinterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Printer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbWorksheet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbStartAtLine);
            this.groupBox1.Controls.Add(this.btnBrowseForSpreadsheet);
            this.groupBox1.Controls.Add(this.txtSpreadsheetToOpen);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a file to import";
            // 
            // cmbWorksheet
            // 
            this.cmbWorksheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorksheet.FormattingEnabled = true;
            this.cmbWorksheet.Location = new System.Drawing.Point(225, 50);
            this.cmbWorksheet.Name = "cmbWorksheet";
            this.cmbWorksheet.Size = new System.Drawing.Size(202, 21);
            this.cmbWorksheet.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Worksheet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Headers are on line";
            // 
            // cmbStartAtLine
            // 
            this.cmbStartAtLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartAtLine.FormattingEnabled = true;
            this.cmbStartAtLine.Location = new System.Drawing.Point(115, 50);
            this.cmbStartAtLine.Name = "cmbStartAtLine";
            this.cmbStartAtLine.Size = new System.Drawing.Size(39, 21);
            this.cmbStartAtLine.TabIndex = 2;
            this.cmbStartAtLine.SelectedIndexChanged += new System.EventHandler(this.cmbStartAtLine_SelectedIndexChanged);
            // 
            // btnBrowseForSpreadsheet
            // 
            this.btnBrowseForSpreadsheet.Location = new System.Drawing.Point(434, 20);
            this.btnBrowseForSpreadsheet.Name = "btnBrowseForSpreadsheet";
            this.btnBrowseForSpreadsheet.Size = new System.Drawing.Size(143, 20);
            this.btnBrowseForSpreadsheet.TabIndex = 1;
            this.btnBrowseForSpreadsheet.Text = "Browse";
            this.btnBrowseForSpreadsheet.UseVisualStyleBackColor = true;
            this.btnBrowseForSpreadsheet.Click += new System.EventHandler(this.btnBrowseForSpreadsheet_Click);
            // 
            // txtSpreadsheetToOpen
            // 
            this.txtSpreadsheetToOpen.Location = new System.Drawing.Point(7, 20);
            this.txtSpreadsheetToOpen.Name = "txtSpreadsheetToOpen";
            this.txtSpreadsheetToOpen.Size = new System.Drawing.Size(420, 20);
            this.txtSpreadsheetToOpen.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBackPreview);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dgvDrivers);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 282);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drivers";
            // 
            // btnBackPreview
            // 
            this.btnBackPreview.Location = new System.Drawing.Point(421, 258);
            this.btnBackPreview.Name = "btnBackPreview";
            this.btnBackPreview.Size = new System.Drawing.Size(75, 23);
            this.btnBackPreview.TabIndex = 2;
            this.btnBackPreview.Text = "Back";
            this.btnBackPreview.UseVisualStyleBackColor = true;
            this.btnBackPreview.Click += new System.EventHandler(this.btnBackPreview_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMakeModel,
            this.clmDriverToUse});
            this.dgvDrivers.Location = new System.Drawing.Point(6, 19);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.RowHeadersWidth = 55;
            this.dgvDrivers.Size = new System.Drawing.Size(571, 233);
            this.dgvDrivers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(595, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 247);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.progressBar1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(595, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(583, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(582, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // clmMakeModel
            // 
            this.clmMakeModel.HeaderText = "Printer Make/Model";
            this.clmMakeModel.Name = "clmMakeModel";
            // 
            // clmDriverToUse
            // 
            this.clmDriverToUse.HeaderText = "Driver To Use";
            this.clmDriverToUse.Name = "clmDriverToUse";
            // 
            // ImportPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 354);
            this.Controls.Add(this.wizPrinterImport);
            this.Name = "ImportPrinters";
            this.Text = "ImportPrinters";
            this.Load += new System.EventHandler(this.ImportPrinters_Load);
            this.wizPrinterImport.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WizardPages wizPrinterImport;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnWelcomeNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPrinterDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrinterIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPrinterDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPrinterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseForSpreadsheet;
        private System.Windows.Forms.TextBox txtSpreadsheetToOpen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog ofExcelFinder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStartAtLine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBackPreview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbWorksheet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMakeModel;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDriverToUse;
    }
}