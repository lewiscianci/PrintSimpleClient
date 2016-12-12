namespace PrintSimple
{
    partial class Startup
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServerOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
            this.wizStartup = new PrintSimple.WizardPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWelcomeNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrevPrintServers = new System.Windows.Forms.Button();
            this.btnNextPrintServers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPrintServers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.txtPrintServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVerifyCredentials = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ServerOptions.SuspendLayout();
            this.wizStartup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = global::PrintSimple.Properties.Resources.basiclogoturned;
            this.pictureBox1.Location = new System.Drawing.Point(615, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ServerOptions
            // 
            this.ServerOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRemoveServer});
            this.ServerOptions.Name = "ServerOptions";
            this.ServerOptions.Size = new System.Drawing.Size(118, 26);
            // 
            // tsRemoveServer
            // 
            this.tsRemoveServer.Name = "tsRemoveServer";
            this.tsRemoveServer.Size = new System.Drawing.Size(117, 22);
            this.tsRemoveServer.Text = "Remove";
            this.tsRemoveServer.Click += new System.EventHandler(this.tsRemoveServer_Click);
            // 
            // wizStartup
            // 
            this.wizStartup.Controls.Add(this.tabPage1);
            this.wizStartup.Controls.Add(this.tabPage2);
            this.wizStartup.Controls.Add(this.tabPage3);
            this.wizStartup.Location = new System.Drawing.Point(12, 12);
            this.wizStartup.Name = "wizStartup";
            this.wizStartup.SelectedIndex = 0;
            this.wizStartup.Size = new System.Drawing.Size(597, 359);
            this.wizStartup.TabIndex = 3;
            this.wizStartup.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnWelcomeNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WelcomeStep";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "This wizard will step you through the process of configuring PrintSimple for your" +
    " environment.\r\n\r\nClick Next to get started.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to PrintSimple.";
            // 
            // btnWelcomeNext
            // 
            this.btnWelcomeNext.Location = new System.Drawing.Point(483, 304);
            this.btnWelcomeNext.Name = "btnWelcomeNext";
            this.btnWelcomeNext.Size = new System.Drawing.Size(100, 23);
            this.btnWelcomeNext.TabIndex = 1;
            this.btnWelcomeNext.Text = "Next";
            this.btnWelcomeNext.UseVisualStyleBackColor = true;
            this.btnWelcomeNext.Click += new System.EventHandler(this.btnWelcomeNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrevPrintServers);
            this.tabPage2.Controls.Add(this.btnNextPrintServers);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrevPrintServers
            // 
            this.btnPrevPrintServers.Location = new System.Drawing.Point(366, 300);
            this.btnPrevPrintServers.Name = "btnPrevPrintServers";
            this.btnPrevPrintServers.Size = new System.Drawing.Size(95, 23);
            this.btnPrevPrintServers.TabIndex = 4;
            this.btnPrevPrintServers.Text = "Previous";
            this.btnPrevPrintServers.UseVisualStyleBackColor = true;
            this.btnPrevPrintServers.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNextPrintServers
            // 
            this.btnNextPrintServers.Location = new System.Drawing.Point(467, 300);
            this.btnNextPrintServers.Name = "btnNextPrintServers";
            this.btnNextPrintServers.Size = new System.Drawing.Size(109, 23);
            this.btnNextPrintServers.TabIndex = 3;
            this.btnNextPrintServers.Text = "Next";
            this.btnNextPrintServers.UseVisualStyleBackColor = true;
            this.btnNextPrintServers.Click += new System.EventHandler(this.btnNextPrintServers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbPrintServers);
            this.groupBox2.Location = new System.Drawing.Point(9, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availible Print Servers";
            // 
            // lbPrintServers
            // 
            this.lbPrintServers.ContextMenuStrip = this.ServerOptions;
            this.lbPrintServers.FormattingEnabled = true;
            this.lbPrintServers.Location = new System.Drawing.Point(8, 18);
            this.lbPrintServers.Name = "lbPrintServers";
            this.lbPrintServers.Size = new System.Drawing.Size(560, 173);
            this.lbPrintServers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddServer);
            this.groupBox1.Controls.Add(this.txtPrintServer);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Server";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(434, 17);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(134, 23);
            this.btnAddServer.TabIndex = 1;
            this.btnAddServer.Text = "Add";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // txtPrintServer
            // 
            this.txtPrintServer.Location = new System.Drawing.Point(8, 19);
            this.txtPrintServer.Name = "txtPrintServer";
            this.txtPrintServer.Size = new System.Drawing.Size(420, 20);
            this.txtPrintServer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add your print servers here.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(589, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFinish);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnVerifyCredentials);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 302);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credentials";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(473, 273);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(104, 23);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVerifyCredentials
            // 
            this.btnVerifyCredentials.Location = new System.Drawing.Point(6, 208);
            this.btnVerifyCredentials.Name = "btnVerifyCredentials";
            this.btnVerifyCredentials.Size = new System.Drawing.Size(571, 23);
            this.btnVerifyCredentials.TabIndex = 4;
            this.btnVerifyCredentials.Text = "Verify Credentials";
            this.btnVerifyCredentials.UseVisualStyleBackColor = true;
            this.btnVerifyCredentials.Click += new System.EventHandler(this.btnVerifyCredentials_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDomain);
            this.groupBox6.Location = new System.Drawing.Point(6, 148);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(571, 53);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(7, 20);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(557, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "This account will need to have the relevant privledges to complete WMI operations" +
    " on the targeted servers.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPassword);
            this.groupBox5.Location = new System.Drawing.Point(6, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(571, 57);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(558, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUsername);
            this.groupBox4.Location = new System.Drawing.Point(6, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 47);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(7, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(558, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Set your credentials here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PrintSimple will query the first print driver in this list for available print dr" +
    "ivers etc.";
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 379);
            this.Controls.Add(this.wizStartup);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Startup";
            this.Text = "Welcome to PrintSimple.";
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ServerOptions.ResumeLayout(false);
            this.wizStartup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWelcomeNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WizardPages wizStartup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.TextBox txtPrintServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrevPrintServers;
        private System.Windows.Forms.Button btnNextPrintServers;
        private System.Windows.Forms.ListBox lbPrintServers;
        private System.Windows.Forms.ContextMenuStrip ServerOptions;
        private System.Windows.Forms.ToolStripMenuItem tsRemoveServer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVerifyCredentials;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}