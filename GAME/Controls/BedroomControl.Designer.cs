namespace GAME
{
    partial class BedroomControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedroomControl));
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.pbLivingroomDoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivingroomDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBox
            // 
            this.pbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBox.BackColor = System.Drawing.Color.Transparent;
            this.pbBox.Location = new System.Drawing.Point(95, 216);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(48, 27);
            this.pbBox.TabIndex = 0;
            this.pbBox.TabStop = false;
            this.pbBox.Click += new System.EventHandler(this.pbBox_Click);
            // 
            // pbLivingroomDoor
            // 
            this.pbLivingroomDoor.BackColor = System.Drawing.Color.Transparent;
            this.pbLivingroomDoor.Location = new System.Drawing.Point(660, 76);
            this.pbLivingroomDoor.Name = "pbLivingroomDoor";
            this.pbLivingroomDoor.Size = new System.Drawing.Size(63, 294);
            this.pbLivingroomDoor.TabIndex = 1;
            this.pbLivingroomDoor.TabStop = false;
            this.pbLivingroomDoor.Click += new System.EventHandler(this.pbLivingroomDoor_Click);
            // 
            // BedroomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbLivingroomDoor);
            this.Controls.Add(this.pbBox);
            this.Name = "BedroomControl";
            this.Size = new System.Drawing.Size(726, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivingroomDoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.PictureBox pbLivingroomDoor;
    }
}
