namespace GAME.ThingForms
{
    partial class SafeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeForm));
            this.panelOpenBox = new System.Windows.Forms.Panel();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.pbCloseBox = new System.Windows.Forms.PictureBox();
            this.pbKey = new System.Windows.Forms.PictureBox();
            this.panelOpenBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpenBox
            // 
            this.panelOpenBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOpenBox.BackgroundImage")));
            this.panelOpenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOpenBox.Controls.Add(this.pbReturn);
            this.panelOpenBox.Controls.Add(this.btSubmit);
            this.panelOpenBox.Controls.Add(this.tbPassWord);
            this.panelOpenBox.Controls.Add(this.pbCloseBox);
            this.panelOpenBox.Controls.Add(this.pbKey);
            this.panelOpenBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpenBox.Location = new System.Drawing.Point(0, 0);
            this.panelOpenBox.Name = "panelOpenBox";
            this.panelOpenBox.Size = new System.Drawing.Size(328, 285);
            this.panelOpenBox.TabIndex = 0;
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReturn.BackgroundImage")));
            this.pbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReturn.Location = new System.Drawing.Point(281, 241);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(44, 44);
            this.pbReturn.TabIndex = 1;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(225, 171);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(57, 22);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "确定";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(211, 138);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(87, 21);
            this.tbPassWord.TabIndex = 2;
            // 
            // pbCloseBox
            // 
            this.pbCloseBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseBox.BackgroundImage")));
            this.pbCloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCloseBox.Location = new System.Drawing.Point(1, 1);
            this.pbCloseBox.Name = "pbCloseBox";
            this.pbCloseBox.Size = new System.Drawing.Size(328, 284);
            this.pbCloseBox.TabIndex = 1;
            this.pbCloseBox.TabStop = false;
            // 
            // pbKey
            // 
            this.pbKey.BackColor = System.Drawing.Color.Transparent;
            this.pbKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbKey.BackgroundImage")));
            this.pbKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKey.Location = new System.Drawing.Point(43, 130);
            this.pbKey.Name = "pbKey";
            this.pbKey.Size = new System.Drawing.Size(195, 101);
            this.pbKey.TabIndex = 0;
            this.pbKey.TabStop = false;
            this.pbKey.Visible = false;
            this.pbKey.Click += new System.EventHandler(this.pbKey_Click);
            // 
            // SafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 285);
            this.Controls.Add(this.panelOpenBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SafeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeForm";
            this.Load += new System.EventHandler(this.SafeForm_Load);
            this.panelOpenBox.ResumeLayout(false);
            this.panelOpenBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpenBox;
        private System.Windows.Forms.PictureBox pbCloseBox;
        private System.Windows.Forms.PictureBox pbKey;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.PictureBox pbReturn;
    }
}