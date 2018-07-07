namespace GAME
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRoomStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.flpBag = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbKeyKichen = new System.Windows.Forms.PictureBox();
            this.pbKnife = new System.Windows.Forms.PictureBox();
            this.pbKey = new System.Windows.Forms.PictureBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.allTimer = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).BeginInit();
            this.flpBag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyKichen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKnife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(784, 25);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVoice});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // tsmiVoice
            // 
            this.tsmiVoice.Checked = true;
            this.tsmiVoice.CheckOnClick = true;
            this.tsmiVoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiVoice.Name = "tsmiVoice";
            this.tsmiVoice.Size = new System.Drawing.Size(100, 22);
            this.tsmiVoice.Text = "声音";
            this.tsmiVoice.Click += new System.EventHandler(this.tsmiVoice_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiFileOpen});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(124, 22);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiFileOpen
            // 
            this.tsmiFileOpen.Name = "tsmiFileOpen";
            this.tsmiFileOpen.Size = new System.Drawing.Size(124, 22);
            this.tsmiFileOpen.Text = "逃生手册";
            this.tsmiFileOpen.Click += new System.EventHandler(this.tsmiFileOpen_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1,
            this.tsslRoomStatus,
            this.tsslDetails});
            this.ssStatus.Location = new System.Drawing.Point(0, 440);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(784, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslRoomStatus
            // 
            this.tsslRoomStatus.Name = "tsslRoomStatus";
            this.tsslRoomStatus.Size = new System.Drawing.Size(32, 17);
            this.tsslRoomStatus.Text = "房间";
            // 
            // tsslDetails
            // 
            this.tsslDetails.Name = "tsslDetails";
            this.tsslDetails.Size = new System.Drawing.Size(737, 17);
            this.tsslDetails.Spring = true;
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.Color.Black;
            this.panelRooms.Controls.Add(this.pbSwitch);
            this.panelRooms.Location = new System.Drawing.Point(0, 25);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(726, 415);
            this.panelRooms.TabIndex = 4;
            // 
            // pbSwitch
            // 
            this.pbSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.pbSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSwitch.BackgroundImage")));
            this.pbSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSwitch.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbSwitch.Location = new System.Drawing.Point(502, 54);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(42, 56);
            this.pbSwitch.TabIndex = 3;
            this.pbSwitch.TabStop = false;
            this.pbSwitch.Click += new System.EventHandler(this.pbSwitch_Click);
            // 
            // flpBag
            // 
            this.flpBag.Controls.Add(this.label1);
            this.flpBag.Controls.Add(this.pbKeyKichen);
            this.flpBag.Controls.Add(this.pbKnife);
            this.flpBag.Controls.Add(this.pbKey);
            this.flpBag.Controls.Add(this.pbPicture);
            this.flpBag.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpBag.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBag.Location = new System.Drawing.Point(723, 25);
            this.flpBag.Name = "flpBag";
            this.flpBag.Size = new System.Drawing.Size(61, 415);
            this.flpBag.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "包裹";
            // 
            // pbKeyKichen
            // 
            this.pbKeyKichen.BackColor = System.Drawing.Color.Transparent;
            this.pbKeyKichen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbKeyKichen.BackgroundImage")));
            this.pbKeyKichen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKeyKichen.Location = new System.Drawing.Point(3, 15);
            this.pbKeyKichen.Name = "pbKeyKichen";
            this.pbKeyKichen.Size = new System.Drawing.Size(55, 49);
            this.pbKeyKichen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKeyKichen.TabIndex = 2;
            this.pbKeyKichen.TabStop = false;
            this.pbKeyKichen.Visible = false;
            this.pbKeyKichen.Click += new System.EventHandler(this.pbKeyKichen_Click);
            // 
            // pbKnife
            // 
            this.pbKnife.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbKnife.BackgroundImage")));
            this.pbKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKnife.Location = new System.Drawing.Point(3, 70);
            this.pbKnife.Name = "pbKnife";
            this.pbKnife.Size = new System.Drawing.Size(55, 49);
            this.pbKnife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKnife.TabIndex = 3;
            this.pbKnife.TabStop = false;
            this.pbKnife.Visible = false;
            this.pbKnife.Click += new System.EventHandler(this.pbKnife_Click);
            // 
            // pbKey
            // 
            this.pbKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbKey.BackgroundImage")));
            this.pbKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKey.Location = new System.Drawing.Point(3, 125);
            this.pbKey.Name = "pbKey";
            this.pbKey.Size = new System.Drawing.Size(55, 49);
            this.pbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKey.TabIndex = 4;
            this.pbKey.TabStop = false;
            this.pbKey.Visible = false;
            this.pbKey.Click += new System.EventHandler(this.pbKey_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPicture.BackgroundImage")));
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.Location = new System.Drawing.Point(3, 180);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(55, 49);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 5;
            this.pbPicture.TabStop = false;
            this.pbPicture.Visible = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // allTimer
            // 
            this.allTimer.Enabled = true;
            this.allTimer.Interval = 480000;
            this.allTimer.Tick += new System.EventHandler(this.allTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.flpBag);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 密室逃脱";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).EndInit();
            this.flpBag.ResumeLayout(false);
            this.flpBag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyKichen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKnife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVoice;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pbSwitch;
        private System.Windows.Forms.FlowLayoutPanel flpBag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbKeyKichen;
        private System.Windows.Forms.PictureBox pbKnife;
        private System.Windows.Forms.PictureBox pbKey;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.ToolStripStatusLabel tsslRoomStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileOpen;
        private System.Windows.Forms.Timer allTimer;
    }
}

