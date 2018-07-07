using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class KitchenControl : UserControl
    {
        public KitchenControl()
        {
            InitializeComponent();
        }

        private void pbDrawer_Click(object sender, EventArgs e)
        {
            DrawerForm form = new DrawerForm();
            form.ShowDialog();
        }

        private void pbLivingroomDoor_Click(object sender, EventArgs e)
        {
            GlobalDatas.ChangetoKitchen = false;
            GlobalDatas.ChangetoLivingroom = true;
        }
    }
}
