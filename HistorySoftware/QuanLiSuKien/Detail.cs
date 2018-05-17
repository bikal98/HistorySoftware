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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            lbTitle.Text = title+"";
            txtContent.Text = content+"";
            
        }
        public string title { set; get; }
        public string content { set; get; }
        
       

    }
}
