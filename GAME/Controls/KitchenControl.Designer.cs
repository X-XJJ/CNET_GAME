namespace GAME
{
    partial class KitchenControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenControl));
            this.pbDrawer = new System.Windows.Forms.PictureBox();
            this.pbLivingroomDoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivingroomDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrawer
            // 
            this.pbDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDrawer.BackColor = System.Drawing.Color.Transparent;
            this.pbDrawer.Location = new System.Drawing.Point(261, 256);
            this.pbDrawer.Name = "pbDrawer";
            this.pbDrawer.Size = new System.Drawing.Size(43, 34);
            this.pbDrawer.TabIndex = 0;
            this.pbDrawer.TabStop = false;
            this.pbDrawer.Click += new System.EventHandler(this.pbDrawer_Click);
            // 
            // pbLivingroomDoor
            // 
            this.pbLivingroomDoor.BackColor = System.Drawing.Color.Transparent;
            this.pbLivingroomDoor.Location = new System.Drawing.Point(613, 79);
            this.pbLivingroomDoor.Name = "pbLivingroomDoor";
            this.pbLivingroomDoor.Size = new System.Drawing.Size(101, 324);
            this.pbLivingroomDoor.TabIndex = 1;
            this.pbLivingroomDoor.TabStop = false;
            this.pbLivingroomDoor.Click += new System.EventHandler(this.pbLivingroomDoor_Click);
            // 
            // KitchenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbLivingroomDoor);
            this.Controls.Add(this.pbDrawer);
            this.Name = "KitchenControl";
            this.Size = new System.Drawing.Size(726, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivingroomDoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawer;
        private System.Windows.Forms.PictureBox pbLivingroomDoor;
    }
}
