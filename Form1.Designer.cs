namespace Tray_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LocationLauncher = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.locationNumber = new System.Windows.Forms.ToolStripTextBox();
            this.virtualCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.esxi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esxi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.esxi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LocationLauncher.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationLauncher
            // 
            this.LocationLauncher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationNumber,
            this.virtualCenter,
            this.esxi1,
            this.esxi2,
            this.esxi3,
            this.cmm,
            this.toolStripSeparator1,
            this.exit});
            this.LocationLauncher.Name = "contextMenuStrip1";
            this.LocationLauncher.Size = new System.Drawing.Size(161, 189);
            this.LocationLauncher.Opened += new System.EventHandler(this.focusHandler);
            // 
            // locationNumber
            // 
            this.locationNumber.Name = "locationNumber";
            this.locationNumber.Size = new System.Drawing.Size(100, 23);
            // 
            // virtualCenter
            // 
            this.virtualCenter.Name = "virtualCenter";
            this.virtualCenter.Size = new System.Drawing.Size(160, 22);
            this.virtualCenter.Text = "Virtual Center";
            this.virtualCenter.Click += new System.EventHandler(this.virtualCenter_Click);
            // 
            // esxi1
            // 
            this.esxi1.Name = "esxi1";
            this.esxi1.Size = new System.Drawing.Size(160, 22);
            this.esxi1.Text = "ESXi 1";
            // 
            // esxi2
            // 
            this.esxi2.Name = "esxi2";
            this.esxi2.Size = new System.Drawing.Size(160, 22);
            this.esxi2.Text = "ESXi 2";
            // 
            // esxi3
            // 
            this.esxi3.Name = "esxi3";
            this.esxi3.Size = new System.Drawing.Size(160, 22);
            this.esxi3.Text = "ESXi 3";
            // 
            // cmm
            // 
            this.cmm.Name = "cmm";
            this.cmm.Size = new System.Drawing.Size(160, 22);
            this.cmm.Text = "CMM";
            this.cmm.Click += new System.EventHandler(this.cmm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(160, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exitClickHandler);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.LocationLauncher;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Tray Location Launcher";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.LocationLauncher.ResumeLayout(false);
            this.LocationLauncher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip LocationLauncher;
        private System.Windows.Forms.ToolStripTextBox locationNumber;
        private System.Windows.Forms.ToolStripMenuItem virtualCenter;
        private System.Windows.Forms.ToolStripMenuItem esxi1;
        private System.Windows.Forms.ToolStripMenuItem esxi2;
        private System.Windows.Forms.ToolStripMenuItem esxi3;
        private System.Windows.Forms.ToolStripMenuItem cmm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

