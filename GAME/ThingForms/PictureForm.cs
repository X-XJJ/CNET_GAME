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
    public partial class PictureForm : Form
    {    
        public PictureForm()
        {
            InitializeComponent();
        }
        
        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            if(GlobalDatas.IsPictureOpen ==true)
            {
                pbPictureClose.Visible = false;
                pbPictureOpen.Visible = true;             
            }
            else
            {
                pbPictureOpen.Visible = false;
                pbPictureClose.Visible = true;
            }
        }

        private void pbPictureClose_Click(object sender, EventArgs e)
        {          
            if (GlobalDatas.Hand == Thing.KNIFE)
            {
                pbPictureClose.Visible = false;
                pbPictureOpen.Visible = true;
                GlobalDatas.IsPictureOpen = true;
            }         
        }
    }
}
