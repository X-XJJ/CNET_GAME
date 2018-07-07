namespace GAME
{
    partial class SofaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SofaForm));
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pbKeyKitchen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyKitchen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReturn.BackgroundImage")));
            this.pbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReturn.Location = new System.Drawing.Point(237, 217);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(47, 44);
            this.pbReturn.TabIndex = 2;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pbReturn);
            this.panel.Controls.Add(this.pbKeyKitchen);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(284, 261);
            this.panel.TabIndex = 5;
            // 
            // pbKeyKitchen
            // 
            this.pbKeyKitchen.BackColor = System.Drawing.SystemColors.Control;
            this.pbKeyKitchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbKeyKitchen.BackgroundImage")));
            this.pbKeyKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKeyKitchen.Location = new System.Drawing.Point(119, 110);
            this.pbKeyKitchen.Name = "pbKeyKitchen";
            this.pbKeyKitchen.Size = new System.Drawing.Size(136, 82);
            this.pbKeyKitchen.TabIndex = 4;
            this.pbKeyKitchen.TabStop = false;
            this.pbKeyKitchen.Click += new System.EventHandler(this.pbKeyKitchen_Click);
            // 
            // SofaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SofaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofaForm";
            this.Load += new System.EventHandler(this.SofaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyKitchen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbKeyKitchen;
    }
}