namespace HistorySoftware.QuanLiSuKien
{
    partial class View
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn Năm";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(239, 122);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtvList
            // 
            this.dtvList.AllowUserToAddRows = false;
            this.dtvList.AllowUserToDeleteRows = false;
            this.dtvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenSuKien,
            this.NgaySuKien,
            this.ThangSuKien,
            this.NamSuKien,
            this.NoiDungSuKien,
            this.HinhAnh});
            this.dtvList.Location = new System.Drawing.Point(12, 151);
            this.dtvList.Name = "dtvList";
            this.dtvList.ReadOnly = true;
            this.dtvList.Size = new System.Drawing.Size(776, 287);
            this.dtvList.TabIndex = 7;
            this.dtvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvList_CellContentClick);
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
            this.TenSuKien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(153, 76);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 8;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(379, 76);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(642, 75);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(486, 122);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.dtvList);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dtvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnRefresh;
    }
}