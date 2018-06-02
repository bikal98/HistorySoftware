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
    public partial class View : Form
    {
        clsConnect cls = new clsConnect();
        public View()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            dtvList.DataSource = cls.LoadData();
        }
        DataTable dt;

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtDay.Text.Trim() == ""||txtMonth.Text.Trim()==""||txtYear.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                
                dt = new DataTable();
                dt = cls.TimKiemView(txtDay.Text.Trim());
                dt = cls.TimKiemView(txtMonth.Text.Trim());
                dt = cls.TimKiemView(txtYear.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dtvList.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn tìm : " + txtDay.Text + "-"+txtMonth.Text+"-"+txtYear.Text+" không có trong dữ liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    View_Load(null, null);
                    txtDay.Text = "";
                    txtMonth.Text = "";
                    txtYear.Text = "";
                }

            }
        }
        private void ShowList()
        {
            var db = new HistorySoftwareEntities2();
            var list = db.SuKiens.ToList();
            this.dtvList.DataSource = list;
        }

        private void dtvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detail dts = new Detail();
            dts.title = (dtvList.CurrentRow.Cells["TenSuKien"].Value.ToString());
            dts.content = (dtvList.CurrentRow.Cells["NoiDungSuKien"].Value.ToString());
            dts.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            this.ShowList();
        }
    }
}
