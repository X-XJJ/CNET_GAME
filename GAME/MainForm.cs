using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GAME
{
    public partial class MainForm : Form
    {
        private LivingroomControl livingroomControl;
        private KitchenControl kitchenControl;
        private BedroomControl bedroomControl;

        //Game game = new Game();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();         
            
        public MainForm()
        {
            InitializeComponent();
            //实例化 以控件切换实现场景切换
            livingroomControl = new LivingroomControl();
            kitchenControl = new KitchenControl();
            bedroomControl = new BedroomControl();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"music.wav";
            player.Load();
            player.PlayLooping();

            tsslDetails.Text = "欢迎进入密室逃脱，如有需要，请查看逃生手册";
        }

        private void pbSwitch_Click(object sender, EventArgs e)
        {//开关打开 加载控件  初始为客厅状态（显示=true）
            panelRooms.Controls.Add(livingroomControl);
            livingroomControl.Dock = DockStyle.Fill;

            tsslRoomStatus.Text = "客厅";
            
            //Kitchen与bedroom的visible初始为false
            panelRooms.Controls.Add(kitchenControl);
            kitchenControl.Dock = DockStyle.Fill;
           
            panelRooms.Controls.Add(bedroomControl);
            bedroomControl.Dock = DockStyle.Fill;
            
            pbSwitch.Visible = false;
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            PictureForm form = new PictureForm();
            form.ShowDialog();//模式化窗体
        }

        private void pbTime_Click(object sender, EventArgs e)
        {
            TimerForm form = new TimerForm();
            form.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        { //刷新窗口 
            //包裹
            if (GlobalDatas.IsPictureOpen == true)
                pbPicture.Visible = true;
            if (GlobalDatas.IsKeyKicthen == true)
                pbKeyKichen.Visible = true;
            if (GlobalDatas.IsKinfe == true)
                pbKnife.Visible = true;
            if (GlobalDatas.IsKey == true)
                pbKey.Visible = true;

            //控件显示
            if(GlobalDatas.ChangetoKitchen == true)
            {
                kitchenControl.Visible = true;
                livingroomControl.Visible = false;
                bedroomControl.Visible = false;
                tsslRoomStatus.Text = "厨房";
            }
            else if (GlobalDatas.ChangetoBedroom == true)
            {
                livingroomControl.Visible = false;
                kitchenControl.Visible = false;
                bedroomControl.Visible = true;
                tsslRoomStatus.Text = "卧室";
            }
            else if(GlobalDatas.ChangetoLivingroom == true)
            {
                bedroomControl.Visible = false;
                kitchenControl.Visible = false;
                livingroomControl.Visible = true;
                tsslRoomStatus.Text = "客厅";
            }
        }
        
        private void pbKeyKichen_Click(object sender, EventArgs e)
        {
            //以资源和背景的切换 实现包裹中物品点击切换效果 
            if (GlobalDatas.Hand != Thing.KEYTOKITCHEN)
            {//没拿钥匙时 
                pbKeyKichen.Image = Resource1.kuangkeykic;
                if(GlobalDatas.Hand==Thing.KNIFE)
                {
                    pbKnife.Image = pbKnife.BackgroundImage;
                }
                else if(GlobalDatas.Hand==Thing.KEY)
                {
                    pbKey.Image = pbKey.BackgroundImage;
                }
                GlobalDatas.Hand = Thing.KEYTOKITCHEN;
            }
            else
            {//已经拿着钥匙 便将钥匙放下
                pbKeyKichen.Image = pbKeyKichen.BackgroundImage;
                GlobalDatas.Hand = Thing.NONETHING;
            }
        }

        private void pbKnife_Click(object sender, EventArgs e)
        {
            if (GlobalDatas.Hand!=Thing.KNIFE)
            {
                pbKnife.Image = Resource1.kuangknife;
                if(GlobalDatas.Hand==Thing.KEYTOKITCHEN)
                {
                    pbKeyKichen.Image = pbKeyKichen.BackgroundImage;
                }
                else if(GlobalDatas.Hand==Thing.KEY)
                {
                    pbKey.Image = pbKey.BackgroundImage;
                }
                GlobalDatas.Hand = Thing.KNIFE;
            }
            else
            {
                pbKnife.Image = pbKnife.BackgroundImage;
                GlobalDatas.Hand = Thing.NONETHING;
            }
        }

        private void pbKey_Click(object sender, EventArgs e)
        {
            if (GlobalDatas.Hand!=Thing.KEY)
            {
                pbKey.Image = Resource1.kuangkey;
                if (GlobalDatas.Hand == Thing.KEYTOKITCHEN)
                {
                    pbKeyKichen.Image = pbKeyKichen.BackgroundImage;
                }
                else if (GlobalDatas.Hand == Thing.KNIFE)
                {
                    pbKnife.Image = pbKnife.BackgroundImage;
                }
                GlobalDatas.Hand = Thing.KEY;
            }
            else
            {
                pbKey.Image = pbKey.BackgroundImage;
                GlobalDatas.Hand = Thing.NONETHING;
            }
        }

        private void tsmiVoice_Click(object sender, EventArgs e)
        {//声音控制
            if (tsmiVoice.Checked == false)
                player.Stop();
            if (tsmiVoice.Checked == true)
                player.PlayLooping();
        }

        private void tsmiFileOpen_Click(object sender, EventArgs e)
        {//逃生手册
            FileForm form = new FileForm();
            form.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {//关于
            MessageBox.Show("密室逃脱\n制作：徐嘉 于高晴");
        }

        private void allTimer_Tick(object sender, EventArgs e)
        {          
            timer.Enabled = false;
            if (MessageBox.Show("逃生时间已过，你被永远地锁在了这间屋子里，直到下一个人出现……", "", MessageBoxButtons.OK) == DialogResult.OK)
            {//点击确定
                this.Close();
            }
        }        
    }
}
