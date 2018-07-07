using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME.ThingForms
{
    public partial class SafeForm : Form
    {
        public SafeForm()
        {
            InitializeComponent();
        }

        private void SafeForm_Load(object sender, EventArgs e)
        {
            if(GlobalDatas.IsPassword == true && GlobalDatas.IsKey == true)
            {
                pbCloseBox.Visible = false;
                pbKey.Visible = false;
                tbPassWord.Visible = false;
                btSubmit.Visible = false;
            }
            else if(GlobalDatas.IsPassword == true && GlobalDatas.IsKey == false)
            {
                pbCloseBox.Visible = false;
                tbPassWord.Visible = false;
                btSubmit.Visible = false;
                pbKey.Visible = true;
            }
        }

        private void pbKey_Click(object sender, EventArgs e)
        {
            pbKey.Visible = false;
            GlobalDatas.IsKey = true;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if(tbPassWord.Text == GlobalDatas.password)
            {
                tbPassWord.Visible = false;
                btSubmit.Visible = false;
                pbCloseBox.Visible = false;
                pbKey.Visible = true;
                GlobalDatas.IsPassword = true;
            }
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
