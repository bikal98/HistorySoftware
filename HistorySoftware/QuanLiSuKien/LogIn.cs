using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HistorySoftware.QuanLiSuKien
{
    public partial class frmLogIn : Form
    {
        Admin ad;
        string strConnection = @"Data Source=LAPTOP-8NMH6R3U\SQL;Initial Catalog=HistorySoftware;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            try {
                string sql = "Select Count(*) From Login where TaiKhoan=@acc And MatKhau =@pass";
                conn = new SqlConnection(strConnection);
                conn.Open();
               
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtAccount.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtPassword.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {// đăng nhập thành công 
                    MessageBox.Show("Đăng nhập thành công !", "Notification");
                    this.Hide();
                    
                    ad = new Admin();
                    ad.Show();

                }
                else
                {// đăng nhập thất bại
                    lblIncorrect.Text = "Tên đăng nhập hoặc Mật khẩu sai !";
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                    txtAccount.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
