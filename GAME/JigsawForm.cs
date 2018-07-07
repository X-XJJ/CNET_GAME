using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class JigsawForm : Form
    {
        public PictureBox[] pictures;

        public Game game;

        public JigsawForm()
        {//初始化
            InitializeComponent();
            game = new Game();

            pictures = new PictureBox[6];
            //pictures数组中，顺序与pb们一一对应
            pictures[0] = pbOne;
            pictures[1] = pbTwo;
            pictures[2] = pbThree;
            pictures[3] = pbFour;
            pictures[4] = pbFive;
            pictures[5] = pbSix;                    
        }

        private void JigsawForm_Load(object sender, EventArgs e)
        {
            //起始状态 game中已定义好初始顺序
            //当pictures[i].Image = ilPictures.Images[i]时 即为通关
            pictures[0].Image = ilPictures.Images[game.record[0]];
            pictures[1].Image = ilPictures.Images[game.record[1]];
            pictures[2].Image = ilPictures.Images[game.record[2]];
            pictures[3].Image = ilPictures.Images[game.record[3]];
            pictures[4].Image = ilPictures.Images[game.record[4]];
            pictures[5].Image = ilPictures.Images[game.record[5]]; 
            
        }

        //记录当前点击
        public int click;   

        public void SetTime()
        {//刷新图片    
            for (int i = 0; i < pictures.Length; i++)
            {//排序 放置顺序一定 ilPictures中图片顺序一定 
                pictures[i].Image = ilPictures.Images[game.record[i]];
            }           
        }

        private void jigTimer_Tick(object sender, EventArgs e)
        {
            SetTime();

            if (game.Win())
            {
                jigTimer.Enabled = false; //停止计时刷新图片
                GlobalDatas.IsBedroom = true;
                if (MessageBox.Show("耶~~胜利！！", "", MessageBoxButtons.OK) == DialogResult.OK)
                {//点击确定
                    this.Close();
                }
            }
        }

        private void pbOne_Click(object sender, EventArgs e)
        {
            click = 0;
            game.Turn(click);
        }

        private void pbThree_Click(object sender, EventArgs e)
        {
            click = 2;
            game.Turn(click);
        }

        private void pbTwo_Click(object sender, EventArgs e)
        {
            click = 1;
            game.Turn(click);
        }

        private void pbFour_Click(object sender, EventArgs e)
        {
            click = 3;
            game.Turn(click);
        }

        private void pbFive_Click(object sender, EventArgs e)
        {
            click = 4;
            game.Turn(click);
        }

        private void pbSix_Click(object sender, EventArgs e)
        {
            click = 5;
            game.Turn(click);
        }
    }
}
