using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 高校学生成绩管理系统
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "admin" && textBox2.Text.ToString() == "123456789")
            {
                
                Application.Exit();
            }
            else { MessageBox.Show("你输入的密码或用户名是错误的"); }
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainInterface frmManager = new MainInterface();
            frmManager.ShowDialog();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
