namespace NumCapApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CapOn = new System.Windows.Forms.NotifyIcon(this.components);
            this.CapOff = new System.Windows.Forms.NotifyIcon(this.components);
            this.NumOn = new System.Windows.Forms.NotifyIcon(this.components);
            this.NumOff = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hide this window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Double click to resore window";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Iterate";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(12, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.linkLabel1.Size = new System.Drawing.Size(168, 40);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "iterate.com.au";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // CapOn
            // 
            this.CapOn.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CapOn.BalloonTipText = "Double click to show window";
            this.CapOn.Icon = ((System.Drawing.Icon)(resources.GetObject("CapOn.Icon")));
            this.CapOn.Text = "Caps On";
            this.CapOn.Visible = true;
            this.CapOn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CapOn_MouseDoubleClick);
            // 
            // CapOff
            // 
            this.CapOff.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CapOff.BalloonTipText = "Double click to show window";
            this.CapOff.Icon = ((System.Drawing.Icon)(resources.GetObject("CapOff.Icon")));
            this.CapOff.Text = "Caps Off";
            this.CapOff.Visible = true;
            this.CapOff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CapOff_MouseDoubleClick);
            // 
            // NumOn
            // 
            this.NumOn.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NumOn.BalloonTipText = "Double click to show window";
            this.NumOn.Icon = ((System.Drawing.Icon)(resources.GetObject("NumOn.Icon")));
            this.NumOn.Text = "Num On";
            this.NumOn.Visible = true;
            this.NumOn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NumOn_MouseDoubleClick);
            // 
            // NumOff
            // 
            this.NumOff.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NumOff.BalloonTipText = "Double click to show window";
            this.NumOff.Icon = ((System.Drawing.Icon)(resources.GetObject("NumOff.Icon")));
            this.NumOff.Text = "Num Off";
            this.NumOff.Visible = true;
            this.NumOff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NumOff_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NumCapApp.Properties.Resources.iterate;
            this.pictureBox1.InitialImage = global::NumCapApp.Properties.Resources.iterate;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 289);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 289);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Iterate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon CapOn;
        private System.Windows.Forms.NotifyIcon CapOff;
        private System.Windows.Forms.NotifyIcon NumOn;
        private System.Windows.Forms.NotifyIcon NumOff;
    }
}

