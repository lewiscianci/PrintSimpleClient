namespace PrintSimple
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCacheInit = new System.Windows.Forms.ProgressBar();
            this.lvPrinters = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmPrinterContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removePrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnotherPrinterLikeThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrinterSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinitilizePrinterCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconfigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orphanedPrintersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orphanedTCPIPPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBogusPrintersOnTheServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsCacheLastRefreshed = new System.Windows.Forms.ToolStripStatusLabel();
            this.timCacheRefresher = new System.Windows.Forms.Timer(this.components);
            this.timUpdateTimeSinceCached = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.cmPrinterContextMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbCacheInit);
            this.groupBox1.Controls.Add(this.lvPrinters);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 611);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initializing the printer cache (this could take a while)";
            // 
            // pbCacheInit
            // 
            this.pbCacheInit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCacheInit.Location = new System.Drawing.Point(209, 292);
            this.pbCacheInit.Name = "pbCacheInit";
            this.pbCacheInit.Size = new System.Drawing.Size(425, 23);
            this.pbCacheInit.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbCacheInit.TabIndex = 1;
            // 
            // lvPrinters
            // 
            this.lvPrinters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPrinters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvPrinters.ContextMenuStrip = this.cmPrinterContextMenu;
            this.lvPrinters.LargeImageList = this.ilIcons;
            this.lvPrinters.Location = new System.Drawing.Point(3, 16);
            this.lvPrinters.Name = "lvPrinters";
            this.lvPrinters.ShowItemToolTips = true;
            this.lvPrinters.Size = new System.Drawing.Size(917, 571);
            this.lvPrinters.SmallImageList = this.ilIcons;
            this.lvPrinters.TabIndex = 0;
            this.lvPrinters.UseCompatibleStateImageBehavior = false;
            this.lvPrinters.Visible = false;
            this.lvPrinters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPrinters_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Printer";
            // 
            // cmPrinterContextMenu
            // 
            this.cmPrinterContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removePrinterToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.createAnotherPrinterLikeThisToolStripMenuItem});
            this.cmPrinterContextMenu.Name = "cmPrinterContextMenu";
            this.cmPrinterContextMenu.Size = new System.Drawing.Size(234, 70);
            this.cmPrinterContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmPrinterContextMenu_Opening);
            // 
            // removePrinterToolStripMenuItem
            // 
            this.removePrinterToolStripMenuItem.Name = "removePrinterToolStripMenuItem";
            this.removePrinterToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.removePrinterToolStripMenuItem.Text = "Delete";
            this.removePrinterToolStripMenuItem.Click += new System.EventHandler(this.removePrinterToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // createAnotherPrinterLikeThisToolStripMenuItem
            // 
            this.createAnotherPrinterLikeThisToolStripMenuItem.Name = "createAnotherPrinterLikeThisToolStripMenuItem";
            this.createAnotherPrinterLikeThisToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.createAnotherPrinterLikeThisToolStripMenuItem.Text = "Create another printer like this";
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "PrintGood.png");
            this.ilIcons.Images.SetKeyName(1, "PrintAttention.png");
            this.ilIcons.Images.SetKeyName(2, "PrintBad.png");
            this.ilIcons.Images.SetKeyName(3, "PrintMisc.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtPrinterSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtPrinterSearch
            // 
            this.txtPrinterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrinterSearch.Location = new System.Drawing.Point(7, 14);
            this.txtPrinterSearch.Name = "txtPrinterSearch";
            this.txtPrinterSearch.Size = new System.Drawing.Size(910, 20);
            this.txtPrinterSearch.TabIndex = 0;
            this.txtPrinterSearch.TextChanged += new System.EventHandler(this.txtPrinterSearch_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printersToolStripMenuItem,
            this.auditingToolStripMenuItem,
            this.quickActionsToolStripMenuItem,
            this.vBugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reinitilizePrinterCacheToolStripMenuItem,
            this.reconfigureToolStripMenuItem,
            this.createNewPrinterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reinitilizePrinterCacheToolStripMenuItem
            // 
            this.reinitilizePrinterCacheToolStripMenuItem.Name = "reinitilizePrinterCacheToolStripMenuItem";
            this.reinitilizePrinterCacheToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.reinitilizePrinterCacheToolStripMenuItem.Text = "Reinitilize Printer Cache";
            this.reinitilizePrinterCacheToolStripMenuItem.Click += new System.EventHandler(this.reinitilizePrinterCacheToolStripMenuItem_Click);
            // 
            // reconfigureToolStripMenuItem
            // 
            this.reconfigureToolStripMenuItem.Name = "reconfigureToolStripMenuItem";
            this.reconfigureToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.reconfigureToolStripMenuItem.Text = "Reconfigure";
            this.reconfigureToolStripMenuItem.Click += new System.EventHandler(this.reconfigureToolStripMenuItem_Click);
            // 
            // createNewPrinterToolStripMenuItem
            // 
            this.createNewPrinterToolStripMenuItem.Name = "createNewPrinterToolStripMenuItem";
            this.createNewPrinterToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.createNewPrinterToolStripMenuItem.Text = "Exit";
            // 
            // printersToolStripMenuItem
            // 
            this.printersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPrinterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importToolStripMenuItem});
            this.printersToolStripMenuItem.Name = "printersToolStripMenuItem";
            this.printersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.printersToolStripMenuItem.Text = "Printers";
            // 
            // newPrinterToolStripMenuItem
            // 
            this.newPrinterToolStripMenuItem.Name = "newPrinterToolStripMenuItem";
            this.newPrinterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newPrinterToolStripMenuItem.Text = "New printer";
            this.newPrinterToolStripMenuItem.Click += new System.EventHandler(this.newPrinterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSpreadsheetToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // fromSpreadsheetToolStripMenuItem
            // 
            this.fromSpreadsheetToolStripMenuItem.Name = "fromSpreadsheetToolStripMenuItem";
            this.fromSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fromSpreadsheetToolStripMenuItem.Text = "From spreadsheet";
            this.fromSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.fromSpreadsheetToolStripMenuItem_Click);
            // 
            // auditingToolStripMenuItem
            // 
            this.auditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForToolStripMenuItem});
            this.auditingToolStripMenuItem.Name = "auditingToolStripMenuItem";
            this.auditingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.auditingToolStripMenuItem.Text = "Auditing";
            // 
            // checkForToolStripMenuItem
            // 
            this.checkForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orphanedPrintersToolStripMenuItem,
            this.orphanedTCPIPPortsToolStripMenuItem});
            this.checkForToolStripMenuItem.Name = "checkForToolStripMenuItem";
            this.checkForToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkForToolStripMenuItem.Text = "Check for...";
            // 
            // orphanedPrintersToolStripMenuItem
            // 
            this.orphanedPrintersToolStripMenuItem.Name = "orphanedPrintersToolStripMenuItem";
            this.orphanedPrintersToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.orphanedPrintersToolStripMenuItem.Text = "Orphaned printers";
            // 
            // orphanedTCPIPPortsToolStripMenuItem
            // 
            this.orphanedTCPIPPortsToolStripMenuItem.Name = "orphanedTCPIPPortsToolStripMenuItem";
            this.orphanedTCPIPPortsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.orphanedTCPIPPortsToolStripMenuItem.Text = "Orphaned TCPIP ports";
            // 
            // quickActionsToolStripMenuItem
            // 
            this.quickActionsToolStripMenuItem.Name = "quickActionsToolStripMenuItem";
            this.quickActionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.quickActionsToolStripMenuItem.Text = "Quick Actions";
            // 
            // vBugToolStripMenuItem
            // 
            this.vBugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBogusPrintersOnTheServerToolStripMenuItem,
            this.directDBToolStripMenuItem});
            this.vBugToolStripMenuItem.Name = "vBugToolStripMenuItem";
            this.vBugToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vBugToolStripMenuItem.Text = "vBug";
            // 
            // createBogusPrintersOnTheServerToolStripMenuItem
            // 
            this.createBogusPrintersOnTheServerToolStripMenuItem.Name = "createBogusPrintersOnTheServerToolStripMenuItem";
            this.createBogusPrintersOnTheServerToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.createBogusPrintersOnTheServerToolStripMenuItem.Text = "Create bogus printers on the server";
            this.createBogusPrintersOnTheServerToolStripMenuItem.Click += new System.EventHandler(this.createBogusPrintersOnTheServerToolStripMenuItem_Click);
            // 
            // directDBToolStripMenuItem
            // 
            this.directDBToolStripMenuItem.Name = "directDBToolStripMenuItem";
            this.directDBToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.directDBToolStripMenuItem.Text = "Direct DB";
            this.directDBToolStripMenuItem.Click += new System.EventHandler(this.directDBToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCacheLastRefreshed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 676);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsCacheLastRefreshed
            // 
            this.tsCacheLastRefreshed.Name = "tsCacheLastRefreshed";
            this.tsCacheLastRefreshed.Size = new System.Drawing.Size(118, 17);
            this.tsCacheLastRefreshed.Text = "toolStripStatusLabel1";
            // 
            // timCacheRefresher
            // 
            this.timCacheRefresher.Enabled = true;
            this.timCacheRefresher.Interval = 900000;
            this.timCacheRefresher.Tick += new System.EventHandler(this.timCacheRefresher_Tick);
            // 
            // timUpdateTimeSinceCached
            // 
            this.timUpdateTimeSinceCached.Enabled = true;
            this.timUpdateTimeSinceCached.Interval = 3000;
            this.timUpdateTimeSinceCached.Tick += new System.EventHandler(this.timUpdateTimeSinceCached_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 698);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PrintSimple.";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmPrinterContextMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvPrinters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrinterSearch;
        private System.Windows.Forms.ProgressBar pbCacheInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinitilizePrinterCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orphanedPrintersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orphanedTCPIPPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconfigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBogusPrintersOnTheServerToolStripMenuItem;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip cmPrinterContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removePrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAnotherPrinterLikeThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsCacheLastRefreshed;
        private System.Windows.Forms.Timer timCacheRefresher;
        private System.Windows.Forms.Timer timUpdateTimeSinceCached;
        private System.Windows.Forms.ToolStripMenuItem directDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSpreadsheetToolStripMenuItem;
    }
}

