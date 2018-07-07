namespace GAME
{
    partial class JigsawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JigsawForm));
            this.panel = new System.Windows.Forms.Panel();
            this.pbSix = new System.Windows.Forms.PictureBox();
            this.pbFive = new System.Windows.Forms.PictureBox();
            this.pbFour = new System.Windows.Forms.PictureBox();
            this.pbThree = new System.Windows.Forms.PictureBox();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.ilPictures = new System.Windows.Forms.ImageList(this.components);
            this.jigTimer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pbSix);
            this.panel.Controls.Add(this.pbFive);
            this.panel.Controls.Add(this.pbFour);
            this.panel.Controls.Add(this.pbThree);
            this.panel.Controls.Add(this.pbTwo);
            this.panel.Controls.Add(this.pbOne);
            this.panel.Location = new System.Drawing.Point(0, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(571, 268);
            this.panel.TabIndex = 0;
            // 
            // pbSix
            // 
            this.pbSix.Location = new System.Drawing.Point(361, 130);
            this.pbSix.Name = "pbSix";
            this.pbSix.Size = new System.Drawing.Size(163, 123);
            this.pbSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSix.TabIndex = 5;
            this.pbSix.TabStop = false;
            this.pbSix.Click += new System.EventHandler(this.pbSix_Click);
            // 
            // pbFive
            // 
            this.pbFive.Location = new System.Drawing.Point(200, 130);
            this.pbFive.Name = "pbFive";
            this.pbFive.Size = new System.Drawing.Size(163, 123);
            this.pbFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFive.TabIndex = 4;
            this.pbFive.TabStop = false;
            this.pbFive.Click += new System.EventHandler(this.pbFive_Click);
            // 
            // pbFour
            // 
            this.pbFour.Location = new System.Drawing.Point(39, 130);
            this.pbFour.Name = "pbFour";
            this.pbFour.Size = new System.Drawing.Size(163, 123);
            this.pbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFour.TabIndex = 3;
            this.pbFour.TabStop = false;
            this.pbFour.Click += new System.EventHandler(this.pbFour_Click);
            // 
            // pbThree
            // 
            this.pbThree.Location = new System.Drawing.Point(361, 10);
            this.pbThree.Name = "pbThree";
            this.pbThree.Size = new System.Drawing.Size(163, 123);
            this.pbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThree.TabIndex = 2;
            this.pbThree.TabStop = false;
            this.pbThree.Click += new System.EventHandler(this.pbThree_Click);
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(200, 10);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(163, 123);
            this.pbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTwo.TabIndex = 1;
            this.pbTwo.TabStop = false;
            this.pbTwo.Click += new System.EventHandler(this.pbTwo_Click);
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(39, 10);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(163, 123);
            this.pbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOne.TabIndex = 0;
            this.pbOne.TabStop = false;
            this.pbOne.Click += new System.EventHandler(this.pbOne_Click);
            // 
            // ilPictures
            // 
            this.ilPictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPictures.ImageStream")));
            this.ilPictures.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPictures.Images.SetKeyName(0, "Jpicture1.jpg");
            this.ilPictures.Images.SetKeyName(1, "Jpicture2.jpg");
            this.ilPictures.Images.SetKeyName(2, "Jpicture3.jpg");
            this.ilPictures.Images.SetKeyName(3, "Jpicture4.jpg");
            this.ilPictures.Images.SetKeyName(4, "Jpicture5.jpg");
            this.ilPictures.Images.SetKeyName(5, "Jpicture6.jpg");
            // 
            // jigTimer
            // 
            this.jigTimer.Enabled = true;
            this.jigTimer.Interval = 50;
            this.jigTimer.Tick += new System.EventHandler(this.jigTimer_Tick);
            // 
            // JigsawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.panel);
            this.Name = "JigsawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "拼图";
            this.Load += new System.EventHandler(this.JigsawForm_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbSix;
        private System.Windows.Forms.PictureBox pbFive;
        private System.Windows.Forms.PictureBox pbFour;
        private System.Windows.Forms.PictureBox pbThree;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.ImageList ilPictures;
        private System.Windows.Forms.Timer jigTimer;
    }
}