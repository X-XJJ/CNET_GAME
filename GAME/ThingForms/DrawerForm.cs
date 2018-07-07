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
    public partial class DrawerForm : Form
    {
        public DrawerForm()
        {
            InitializeComponent();
        }

        private void pbKinfe_Click(object sender, EventArgs e)
        {
            pbKinfe.Visible = false;
            GlobalDatas.IsKinfe = true;
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawerForm_Load(object sender, EventArgs e)
        {
            if (GlobalDatas.IsKinfe == true)
                pbKinfe.Visible = false;
        }
    }
}
