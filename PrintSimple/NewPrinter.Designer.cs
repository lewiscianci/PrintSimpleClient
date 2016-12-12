namespace PrintSimple
{
    partial class NewPrinter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbPrintServers = new System.Windows.Forms.GroupBox();
            this.cmbPrinterDriver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrinterIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrinterDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPrintServers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.gbPrintServers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.gbPrintServers);
            this.groupBox1.Controls.Add(this.cmbPrinterDriver);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrinterIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrinterDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrinterName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer Details";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 321);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(518, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Printer on Print Servers";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbPrintServers
            // 
            this.gbPrintServers.Controls.Add(this.lvPrintServers);
            this.gbPrintServers.Location = new System.Drawing.Point(9, 132);
            this.gbPrintServers.Name = "gbPrintServers";
            this.gbPrintServers.Size = new System.Drawing.Size(531, 182);
            this.gbPrintServers.TabIndex = 8;
            this.gbPrintServers.TabStop = false;
            this.gbPrintServers.Text = "Print Servers";
            // 
            // cmbPrinterDriver
            // 
            this.cmbPrinterDriver.FormattingEnabled = true;
            this.cmbPrinterDriver.Location = new System.Drawing.Point(110, 108);
            this.cmbPrinterDriver.Name = "cmbPrinterDriver";
            this.cmbPrinterDriver.Size = new System.Drawing.Size(430, 21);
            this.cmbPrinterDriver.TabIndex = 7;
            this.cmbPrinterDriver.SelectedIndexChanged += new System.EventHandler(this.cmbPrinterDriver_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Driver";
            // 
            // txtPrinterIP
            // 
            this.txtPrinterIP.Location = new System.Drawing.Point(110, 82);
            this.txtPrinterIP.Name = "txtPrinterIP";
            this.txtPrinterIP.Size = new System.Drawing.Size(430, 20);
            this.txtPrinterIP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP Address";
            // 
            // txtPrinterDesc
            // 
            this.txtPrinterDesc.Location = new System.Drawing.Point(110, 56);
            this.txtPrinterDesc.Name = "txtPrinterDesc";
            this.txtPrinterDesc.Size = new System.Drawing.Size(430, 20);
            this.txtPrinterDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(110, 30);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(430, 20);
            this.txtPrinterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lvPrintServers
            // 
            this.lvPrintServers.CheckBoxes = true;
            this.lvPrintServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvPrintServers.Location = new System.Drawing.Point(6, 19);
            this.lvPrintServers.Name = "lvPrintServers";
            this.lvPrintServers.Size = new System.Drawing.Size(518, 157);
            this.lvPrintServers.TabIndex = 0;
            this.lvPrintServers.UseCompatibleStateImageBehavior = false;
            this.lvPrintServers.View = System.Windows.Forms.View.Details;
            this.lvPrintServers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvPrintServers_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Print Servers";
            this.columnHeader1.Width = 503;
            // 
            // NewPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPrinter";
            this.Text = "NewPrinter";
            this.Load += new System.EventHandler(this.NewPrinter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPrintServers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbPrintServers;
        private System.Windows.Forms.ComboBox cmbPrinterDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrinterIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrinterDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListView lvPrintServers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}