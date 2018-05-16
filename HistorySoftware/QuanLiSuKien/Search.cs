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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        clsConnect cls = new clsConnect();
        

        private void Search_List_Load(object sender,EventArgs e)
        {
            
        }
        private void showEventList()
        {
            
        }
        private void btnSearch_Click_Click(object sender, EventArgs e)
        {
            
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            lstEvent.DataSource = cls.LoadData();
        }
        DataTable dt;
        private void btnSearch_Click_Click_1(object sender, EventArgs e)
        {
            if(txtInput.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                dt = new DataTable();
                dt = cls.TimKiem(txtInput.Text.Trim());
                if (dt.Rows.Count >0 )
                {
                    lstEvent.DataSource = dt;
                }else
                {
                    MessageBox.Show("Bạn tìm : " + txtInput.Text + " không có trong dữ liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Search_Load(null, null);
                    txtInput.Text = "";
                }

            }
        }
    }
}
