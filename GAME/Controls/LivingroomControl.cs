using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAME.ThingForms;

namespace GAME
{
    public partial class LivingroomControl : UserControl
    {
        public LivingroomControl()
        {
            InitializeComponent();
        }

        private void LivingroomControl_Load(object sender, EventArgs e){}

        private void pbKitchenDoor_Click(object sender, EventArgs e)
        {
            if(GlobalDatas.IsKeyKicthen == true && GlobalDatas.Hand == Thing.KEYTOKITCHEN)
            {
                GlobalDatas.ChangetoLivingroom = false;
                GlobalDatas.ChangetoBedroom = false;
                GlobalDatas.ChangetoKitchen = true;                
            }
        }

        private void pbBedroomDoor_Click(object sender, EventArgs e)
        {
            if (GlobalDatas.IsBedroom == false)
            {
                JigsawForm form1 = new JigsawForm();
                form1.ShowDialog();
            }
            else
            {
                GlobalDatas.ChangetoLivingroom = false;
                GlobalDatas.ChangetoKitchen = false;
                GlobalDatas.ChangetoBedroom = true;
            }
        }

        private void pbDoor_Click(object sender, EventArgs e)
        {
            if (GlobalDatas.IsKey == true && GlobalDatas.Hand == Thing.KEY)
            {
                GlobalDatas.ChangetoLivingroom = false;
                GlobalDatas.ChangetoKitchen = false;
                GlobalDatas.ChangetoBedroom = false;

                MessageBox.Show("恭喜你，走出密室，逃生成功！");
            }           
        }

        private void pbSofa_Click(object sender, EventArgs e)
        {
            SofaForm form = new SofaForm();
            form.ShowDialog();
        }

        private void pbTimer_Click(object sender, EventArgs e)
        {
            TimerForm form = new TimerForm();
            form.ShowDialog();
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            PictureForm form = new PictureForm();
            form.ShowDialog();
        }
    }
}
