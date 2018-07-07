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
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void FileForm_Load(object sender, EventArgs e)
        {
            string filePath = "逃生手册.txt";
            
            StreamReader sr;

            try
            {
                sr = new StreamReader(filePath, 
                    System.Text.Encoding.Default);
            }
            catch (IOException ex)
            {
                MessageBox.Show("文件打开失败");
                return;
            }

            //一个表示下一个要读取的字符的整数
            //如果没有更多可读取的字符或该流不支持查找，则为 -1
            while (sr.Peek() != -1)
            {
                String str = sr.ReadLine();

                StringBuilder builder = new StringBuilder();
                builder.Append(txtFile.Text);
                builder.Append(str);

                txtFile.Focus();
                txtFile.Text = builder.ToString();
                txtFile.SelectionStart = 0;
            }

            //MessageBox.Show("到达文件结尾");
            sr.Close();    
        }
    }
}
