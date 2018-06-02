namespace HistorySoftware.QuanLiSuKien
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstEvent = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch_Click = new System.Windows.Forms.Button();
            this.historySoftwareDataSet = new HistorySoftware.HistorySoftwareDataSet();
            this.historySoftwareDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historySoftwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historySoftwareDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên sự kiện :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(166, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(443, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lstEvent
            // 
            this.lstEvent.AllowUserToAddRows = false;
            this.lstEvent.AllowUserToDeleteRows = false;
            this.lstEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenSuKien,
            this.NgaySuKien,
            this.ThangSuKien,
            this.NamSuKien,
            this.NoiDungSuKien});
            this.lstEvent.Location = new System.Drawing.Point(12, 134);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.ReadOnly = true;
            this.lstEvent.Size = new System.Drawing.Size(776, 304);
            this.lstEvent.TabIndex = 2;
            this.lstEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstEvent_CellContentClick);
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
            this.NoiDungSuKien.HeaderText = "Nội Dung";
            this.NoiDungSuKien.Name = "NoiDungSuKien";
            this.NoiDungSuKien.ReadOnly = true;
            // 
            // btnSearch_Click
            // 
            this.btnSearch_Click.Location = new System.Drawing.Point(166, 105);
            this.btnSearch_Click.Name = "btnSearch_Click";
            this.btnSearch_Click.Size = new System.Drawing.Size(84, 23);
            this.btnSearch_Click.TabIndex = 3;
            this.btnSearch_Click.Text = "Tìm kiếm";
            this.btnSearch_Click.UseVisualStyleBackColor = true;
            this.btnSearch_Click.Click += new System.EventHandler(this.btnSearch_Click_Click_1);
            // 
            // historySoftwareDataSet
            // 
            this.historySoftwareDataSet.DataSetName = "HistorySoftwareDataSet";
            this.historySoftwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historySoftwareDataSetBindingSource
            // 
            this.historySoftwareDataSetBindingSource.DataSource = this.historySoftwareDataSet;
            this.historySoftwareDataSetBindingSource.Position = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(437, 105);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch_Click);
            this.Controls.Add(this.lstEvent);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historySoftwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historySoftwareDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView lstEvent;
        private System.Windows.Forms.Button btnSearch_Click;
        private System.Windows.Forms.BindingSource historySoftwareDataSetBindingSource;
        private HistorySoftwareDataSet historySoftwareDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungSuKien;
        private System.Windows.Forms.Button btnRefresh;
    }
}