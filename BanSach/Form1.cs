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
using System.Data.SqlClient;


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

            SqlConnection connection= new SqlConnection(@"Data Source=LAPTOP-JDE5MGNQ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True");
            try
            {
                connection.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from QuanLySach where TenTaiKhoan = '" + tk + "' and MatKhau'" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");

                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");

                }


            }
           
                 catch (Exception)
                {
                    MessageBox.Show("Lỗi Kết Nối","Thông Báo !");
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

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
