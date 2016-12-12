namespace PrintSimple
{
    partial class RemovePrinter
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbActions = new System.Windows.Forms.ListBox();
            this.btnRemovePrinter = new System.Windows.Forms.Button();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.pbDeletion = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are removing printer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbActions);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // lbActions
            // 
            this.lbActions.FormattingEnabled = true;
            this.lbActions.Location = new System.Drawing.Point(6, 19);
            this.lbActions.Name = "lbActions";
            this.lbActions.Size = new System.Drawing.Size(464, 264);
            this.lbActions.Sorted = true;
            this.lbActions.TabIndex = 0;
            // 
            // btnRemovePrinter
            // 
            this.btnRemovePrinter.Location = new System.Drawing.Point(12, 318);
            this.btnRemovePrinter.Name = "btnRemovePrinter";
            this.btnRemovePrinter.Size = new System.Drawing.Size(476, 23);
            this.btnRemovePrinter.TabIndex = 2;
            this.btnRemovePrinter.Text = "Remove Printer";
            this.btnRemovePrinter.UseVisualStyleBackColor = true;
            this.btnRemovePrinter.Click += new System.EventHandler(this.btnRemovePrinter_Click);
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Location = new System.Drawing.Point(132, 9);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(35, 13);
            this.lblPrinter.TabIndex = 3;
            this.lblPrinter.Text = "label2";
            // 
            // pbDeletion
            // 
            this.pbDeletion.Location = new System.Drawing.Point(12, 319);
            this.pbDeletion.Name = "pbDeletion";
            this.pbDeletion.Size = new System.Drawing.Size(457, 23);
            this.pbDeletion.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbDeletion.TabIndex = 4;
            this.pbDeletion.Visible = false;
            // 
            // RemovePrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 355);
            this.Controls.Add(this.pbDeletion);
            this.Controls.Add(this.lblPrinter);
            this.Controls.Add(this.btnRemovePrinter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RemovePrinter";
            this.Text = " ";
            this.Load += new System.EventHandler(this.RemovePrinter_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemovePrinter;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.ListBox lbActions;
        private System.Windows.Forms.ProgressBar pbDeletion;
    }
}