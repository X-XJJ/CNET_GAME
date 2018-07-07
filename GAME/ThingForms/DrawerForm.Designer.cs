namespace GAME
{
    partial class DrawerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawerForm));
            this.panel = new System.Windows.Forms.Panel();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.pbKinfe = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKinfe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pbReturn);
            this.panel.Controls.Add(this.pbKinfe);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(354, 259);
            this.panel.TabIndex = 0;
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReturn.BackgroundImage")));
            this.pbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReturn.Location = new System.Drawing.Point(312, 218);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(42, 41);
            this.pbReturn.TabIndex = 1;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // pbKinfe
            // 
            this.pbKinfe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbKinfe.BackgroundImage")));
            this.pbKinfe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKinfe.Location = new System.Drawing.Point(103, 67);
            this.pbKinfe.Name = "pbKinfe";
            this.pbKinfe.Size = new System.Drawing.Size(162, 144);
            this.pbKinfe.TabIndex = 1;
            this.pbKinfe.TabStop = false;
            this.pbKinfe.Click += new System.EventHandler(this.pbKinfe_Click);
            // 
            // DrawerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawerForm";
            this.Load += new System.EventHandler(this.DrawerForm_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKinfe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbKinfe;
        private System.Windows.Forms.PictureBox pbReturn;
    }
}