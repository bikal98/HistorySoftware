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
        clsConnect cls = new clsConnect();

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công !", "Notification");
            this.Close();
            var form = new Form1();
            form.ShowDialog();
            Application.Exit();
           


        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dtlShow.DataSource = cls.LoadData();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new QuanLiSuKien.Add();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ShowList();
        }
        private void ShowList()
        {
            var db = new HistorySoftwareEntities2();
            var list = db.SuKiens.ToList();
            this.dtlShow.DataSource = list;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = new HistorySoftwareEntities2();
            if (MessageBox.Show("Do you want to delete", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < this.dtlShow.SelectedRows.Count; i++)
                {
                    var row = this.dtlShow.SelectedRows[i];
                    var item = (SuKien)row.DataBoundItem;

                    try
                    {
                        SuKien @class = db.SuKiens.Find(item.Id);
                        db.SuKiens.Remove(@class);
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot deletclass: " + item.Id);
                    }
                    this.ShowList();


                }
            }


        }

        private void dtlShow_doubleClick(object sender, EventArgs e)
        {
            if (this.dtlShow.SelectedRows.Count == 1)
            {
                
                    var row = this.dtlShow.SelectedRows[0];
                    var item = (SuKien)row.DataBoundItem;
                    var form = new QuanLiSuKien.Edit(item);
                    form.ShowDialog();
                    this.ShowList();
                
                
            }
        }
    }
}
