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
    public partial class SofaForm : Form
    {
        public SofaForm()
        {
            InitializeComponent();
        }

        private void SofaForm_Load(object sender, EventArgs e)
        {
            if(GlobalDatas.IsKeyKicthen==false)
            {
                pbKeyKitchen.Visible = true;
            }
            else
            {
                pbKeyKitchen.Visible = false;
            }          
        }

        private void pbKeyKitchen_Click(object sender, EventArgs e)
        {
            pbKeyKitchen.Visible = false;
            GlobalDatas.IsKeyKicthen = true;
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
