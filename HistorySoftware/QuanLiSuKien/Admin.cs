using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistorySoftware.QuanLiSuKien
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công !", "Notification");
            this.Close();
            var form = new Form1();
            form.ShowDialog();
            Application.Exit();
           


        }
    }
}
