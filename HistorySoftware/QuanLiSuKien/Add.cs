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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SuKien sukien = new SuKien();
            sukien.Id = this.txtId.Text;
            sukien.TenSuKien = this.txtTitle.Text;
            sukien.NgaySuKien =this.txtDay.Text;
            sukien.ThangSuKien = this.txtMonth.Text;
            sukien.NamSuKien = this.txtYear.Text;
            sukien.NoiDungSuKien = this.rtxtContent.Text;

            try
            {
                var db = new HistorySoftwareEntities2();
                db.SuKiens.Add(sukien);
                db.SaveChanges();
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
