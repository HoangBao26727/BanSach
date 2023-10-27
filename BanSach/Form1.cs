using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("vui lòng nhập tên tài khoản ! "); return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu !"); return; }
            else
            {
                string query = " select * from TaiKhoan where   TenTaiKhoan = '"+tentk+"' and MatKhau = '"+matkhau+"'";
                
          
            }
        }
  
        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenmatkhau = new QuenMatKhau();
            quenmatkhau.ShowDialog();
        }

        private void linkLabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangky dangky = new dangky();
            dangky.ShowDialog();
        }
    }
}
