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
    public partial class BedroomControl : UserControl
    {
        public BedroomControl()
        {
            InitializeComponent();
        }

        private void pbBox_Click(object sender, EventArgs e)
        {
            SafeForm form = new SafeForm();
            form.ShowDialog();
        }

        private void pbLivingroomDoor_Click(object sender, EventArgs e)
        {
            GlobalDatas.ChangetoKitchen = false;
            GlobalDatas.ChangetoBedroom = false;

            GlobalDatas.ChangetoLivingroom = true;
        }
    }
}
