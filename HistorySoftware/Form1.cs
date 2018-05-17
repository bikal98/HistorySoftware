using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistorySoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var form = new QuanLiSuKien.Search();
            form.ShowDialog();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Title { set; get; }
        public string content { set; get; }

        
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var form = new QuanLiSuKien.View();
            form.ShowDialog();
        }
    }
}
