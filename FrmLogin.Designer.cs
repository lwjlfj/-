namespace 停车场管理系统
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Vehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.Enter = new System.Windows.Forms.ToolStripMenuItem();
            this.Ieave = new System.Windows.Forms.ToolStripMenuItem();
            this.Inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.Current = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.To = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Vehicle,
            this.Inquiry,
            this.Current,
            this.Record,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Vehicle
            // 
            this.Vehicle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Enter,
            this.Ieave,
            this.Quit});
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(68, 21);
            this.Vehicle.Text = "车辆管理";
            // 
            // Enter
            // 
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(180, 22);
            this.Enter.Text = "进入停车场";
            // 
            // Ieave
            // 
            this.Ieave.Name = "Ieave";
            this.Ieave.Size = new System.Drawing.Size(180, 22);
            this.Ieave.Text = "离开停车场";
            // 
            // Inquiry
            // 
            this.Inquiry.Name = "Inquiry";
            this.Inquiry.Size = new System.Drawing.Size(68, 21);
            this.Inquiry.Text = "信息查询";
            this.Inquiry.Click += new System.EventHandler(this.Inquiry_Click);
            // 
            // Current
            // 
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(104, 21);
            this.Current.Text = "当前车辆场信息";
            this.Current.Click += new System.EventHandler(this.Current_Click);
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(92, 21);
            this.Record.Text = "车辆进出记录";
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.To});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // To
            // 
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(180, 22);
            this.To.Text = "关于(&O)";
            this.To.Click += new System.EventHandler(this.To_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 403);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(180, 22);
            this.Quit.Text = "退出";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(734, 428);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "停车场管理系统界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Vehicle;
        private System.Windows.Forms.ToolStripMenuItem Inquiry;
        private System.Windows.Forms.ToolStripMenuItem Current;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem To;
        private System.Windows.Forms.ToolStripMenuItem Enter;
        private System.Windows.Forms.ToolStripMenuItem Ieave;
        private System.Windows.Forms.ToolStripMenuItem Quit;
    }
}