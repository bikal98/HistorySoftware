namespace HistorySoftware.QuanLiSuKien
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chinhToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(79, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chinhToolStripMenuItem
            // 
            this.chinhToolStripMenuItem.Name = "chinhToolStripMenuItem";
            this.chinhToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.chinhToolStripMenuItem.Text = "Chỉnh Sửa";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenSuKien,
            this.NgaySuKien,
            this.ThangSuKien,
            this.NamSuKien,
            this.NoiDungSuKien,
            this.Image});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(79, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(721, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // TenSuKien
            // 
            this.TenSuKien.DataPropertyName = "TenSuKien";
            this.TenSuKien.HeaderText = "Tên Sự Kiện";
            this.TenSuKien.Name = "TenSuKien";
            this.TenSuKien.ReadOnly = true;
            // 
            // NgaySuKien
            // 
            this.NgaySuKien.DataPropertyName = "NgaySuKien";
            this.NgaySuKien.HeaderText = "Ngày Sự Kiện";
            this.NgaySuKien.Name = "NgaySuKien";
            this.NgaySuKien.ReadOnly = true;
            // 
            // ThangSuKien
            // 
            this.ThangSuKien.DataPropertyName = "ThangSuKien";
            this.ThangSuKien.HeaderText = "Tháng Sự Kiện";
            this.ThangSuKien.Name = "ThangSuKien";
            this.ThangSuKien.ReadOnly = true;
            // 
            // NamSuKien
            // 
            this.NamSuKien.DataPropertyName = "NamSuKien";
            this.NamSuKien.HeaderText = "Năm Sự Kiện";
            this.NamSuKien.Name = "NamSuKien";
            this.NamSuKien.ReadOnly = true;
            // 
            // NoiDungSuKien
            // 
            this.NoiDungSuKien.DataPropertyName = "NoiDungSuKien";
            this.NoiDungSuKien.HeaderText = "Nội Dung Sự Kiện";
            this.NoiDungSuKien.Name = "NoiDungSuKien";
            this.NoiDungSuKien.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 398);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Thoát";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.Button btnLogOut;
    }
}