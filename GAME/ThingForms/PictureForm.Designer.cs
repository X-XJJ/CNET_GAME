namespace GAME
{
    partial class PictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.pbPictureClose = new System.Windows.Forms.PictureBox();
            this.pbPictureOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Black;
            this.pbReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReturn.BackgroundImage")));
            this.pbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReturn.Location = new System.Drawing.Point(366, 215);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(40, 35);
            this.pbReturn.TabIndex = 1;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // pbPictureClose
            // 
            this.pbPictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pbPictureClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPictureClose.BackgroundImage")));
            this.pbPictureClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPictureClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPictureClose.Location = new System.Drawing.Point(0, 0);
            this.pbPictureClose.Name = "pbPictureClose";
            this.pbPictureClose.Size = new System.Drawing.Size(406, 250);
            this.pbPictureClose.TabIndex = 2;
            this.pbPictureClose.TabStop = false;
            this.pbPictureClose.Click += new System.EventHandler(this.pbPictureClose_Click);
            // 
            // pbPictureOpen
            // 
            this.pbPictureOpen.BackColor = System.Drawing.Color.Transparent;
            this.pbPictureOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPictureOpen.BackgroundImage")));
            this.pbPictureOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPictureOpen.Location = new System.Drawing.Point(0, 0);
            this.pbPictureOpen.Name = "pbPictureOpen";
            this.pbPictureOpen.Size = new System.Drawing.Size(406, 250);
            this.pbPictureOpen.TabIndex = 3;
            this.pbPictureOpen.TabStop = false;
            this.pbPictureOpen.Visible = false;
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 249);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.pbPictureClose);
            this.Controls.Add(this.pbPictureOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureForm";
            this.Load += new System.EventHandler(this.PictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.PictureBox pbPictureClose;
        private System.Windows.Forms.PictureBox pbPictureOpen;
    }
}