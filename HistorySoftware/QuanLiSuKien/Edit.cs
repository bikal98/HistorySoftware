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
    public partial class Edit : Form
    {
        
        public Edit(SuKien sukien)
        {
            InitializeComponent();
            this.sukien = sukien;
        }
        private SuKien sukien;

        private void Edit_Load(object sender, EventArgs e)
        {
            this.txtId.Text = this.sukien.Id;
            this.txtDay.Text = this.sukien.NgaySuKien;
            this.txtMonth.Text = this.sukien.ThangSuKien;
            this.txtYear.Text = this.sukien.NamSuKien;
            this.txtTitle.Text = this.sukien.TenSuKien;
            this.rtxtContent.Text = this.sukien.NoiDungSuKien;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new HistorySoftwareEntities2();
                var newClass = db.SuKiens.Find(this.sukien.Id);
                
                newClass.Id = this.txtId.Text;
                newClass.TenSuKien = this.txtTitle.Text;
                newClass.NgaySuKien = this.txtDay.Text;
                newClass.ThangSuKien = this.txtMonth.Text;
                newClass.NamSuKien = this.txtYear.Text;
                newClass.NoiDungSuKien = this.rtxtContent.Text;
                db.Entry(newClass).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
