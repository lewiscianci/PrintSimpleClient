namespace PrintSimple
{
    partial class DirectDB
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblPrinterTCPIPClassCacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printSimpleCacheDataSet = new PrintSimple.PrintSimpleCacheDataSet();
            this.tblPrinterTCPIPClassCacheTableAdapter = new PrintSimple.PrintSimpleCacheDataSetTableAdapters.tblPrinterTCPIPClassCacheTableAdapter();
            this.tblPrinterDriverCacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPrinterDriverCacheTableAdapter = new PrintSimple.PrintSimpleCacheDataSetTableAdapters.tblPrinterDriverCacheTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacheGUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrinterDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrinterServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrinterTCPIPClassCacheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSimpleCacheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrinterDriverCacheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cacheGUIDDataGridViewTextBoxColumn,
            this.PrinterDriver,
            this.PrinterServer});
            this.dataGridView1.DataSource = this.tblPrinterDriverCacheBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 430);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(604, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tblPrinterTCPIPClassCacheBindingSource
            // 
            this.tblPrinterTCPIPClassCacheBindingSource.DataMember = "tblPrinterTCPIPClassCache";
            this.tblPrinterTCPIPClassCacheBindingSource.DataSource = this.printSimpleCacheDataSet;
            // 
            // printSimpleCacheDataSet
            // 
            this.printSimpleCacheDataSet.DataSetName = "PrintSimpleCacheDataSet";
            this.printSimpleCacheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPrinterTCPIPClassCacheTableAdapter
            // 
            this.tblPrinterTCPIPClassCacheTableAdapter.ClearBeforeFill = true;
            // 
            // tblPrinterDriverCacheBindingSource
            // 
            this.tblPrinterDriverCacheBindingSource.DataMember = "tblPrinterDriverCache";
            this.tblPrinterDriverCacheBindingSource.DataSource = this.printSimpleCacheDataSet;
            // 
            // tblPrinterDriverCacheTableAdapter
            // 
            this.tblPrinterDriverCacheTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cacheGUIDDataGridViewTextBoxColumn
            // 
            this.cacheGUIDDataGridViewTextBoxColumn.DataPropertyName = "CacheGUID";
            this.cacheGUIDDataGridViewTextBoxColumn.HeaderText = "CacheGUID";
            this.cacheGUIDDataGridViewTextBoxColumn.Name = "cacheGUIDDataGridViewTextBoxColumn";
            // 
            // PrinterDriver
            // 
            this.PrinterDriver.DataPropertyName = "PrinterDriver";
            this.PrinterDriver.HeaderText = "PrinterDriver";
            this.PrinterDriver.Name = "PrinterDriver";
            // 
            // PrinterServer
            // 
            this.PrinterServer.DataPropertyName = "PrinterServer";
            this.PrinterServer.HeaderText = "PrinterServer";
            this.PrinterServer.Name = "PrinterServer";
            // 
            // DirectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 455);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DirectDB";
            this.Text = "DirectDB";
            this.Load += new System.EventHandler(this.DirectDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrinterTCPIPClassCacheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSimpleCacheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrinterDriverCacheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrintSimpleCacheDataSet printSimpleCacheDataSet;
        private System.Windows.Forms.BindingSource tblPrinterTCPIPClassCacheBindingSource;
        private PrintSimpleCacheDataSetTableAdapters.tblPrinterTCPIPClassCacheTableAdapter tblPrinterTCPIPClassCacheTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource tblPrinterDriverCacheBindingSource;
        private PrintSimpleCacheDataSetTableAdapters.tblPrinterDriverCacheTableAdapter tblPrinterDriverCacheTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacheGUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterServer;
    }
}