﻿namespace DoAnQLBanSach
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.lbe_tongthanhtien = new System.Windows.Forms.Label();
            this.cbb_mahoadon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_tenkhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thanhtoan);
            this.groupBox1.Controls.Add(this.lbe_tongthanhtien);
            this.groupBox1.Location = new System.Drawing.Point(725, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 193);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_thanhtoan.Image")));
            this.btn_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhtoan.Location = new System.Drawing.Point(271, 139);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(152, 48);
            this.btn_thanhtoan.TabIndex = 54;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // lbe_tongthanhtien
            // 
            this.lbe_tongthanhtien.AutoSize = true;
            this.lbe_tongthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbe_tongthanhtien.ForeColor = System.Drawing.Color.Red;
            this.lbe_tongthanhtien.Location = new System.Drawing.Point(13, 50);
            this.lbe_tongthanhtien.Name = "lbe_tongthanhtien";
            this.lbe_tongthanhtien.Size = new System.Drawing.Size(138, 17);
            this.lbe_tongthanhtien.TabIndex = 0;
            this.lbe_tongthanhtien.Text = "Tông Thành Tiền:";
            // 
            // cbb_mahoadon
            // 
            this.cbb_mahoadon.FormattingEnabled = true;
            this.cbb_mahoadon.Location = new System.Drawing.Point(858, 201);
            this.cbb_mahoadon.Name = "cbb_mahoadon";
            this.cbb_mahoadon.Size = new System.Drawing.Size(226, 24);
            this.cbb_mahoadon.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AllowUserToAddRows = false;
            this.dataGridViewHoaDon.AllowUserToDeleteRows = false;
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.ReadOnly = true;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(691, 443);
            this.dataGridViewHoaDon.TabIndex = 61;
            this.dataGridViewHoaDon.SelectionChanged += new System.EventHandler(this.dataGridViewHoaDon_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNV";
            this.Column2.HeaderText = "Mã Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBan";
            this.Column3.HeaderText = "Ngày Bán";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaKH";
            this.Column4.HeaderText = "Mã Khách Hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TinhTrang";
            this.Column6.HeaderText = "Trạng Thái";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(428, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 60;
            this.label1.Text = "Thanh Toán";
            // 
            // cbb_tenkhachhang
            // 
            this.cbb_tenkhachhang.FormattingEnabled = true;
            this.cbb_tenkhachhang.Location = new System.Drawing.Point(858, 244);
            this.cbb_tenkhachhang.Name = "cbb_tenkhachhang";
            this.cbb_tenkhachhang.Size = new System.Drawing.Size(226, 24);
            this.cbb_tenkhachhang.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(24, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(152, 29);
            this.btn_refresh.TabIndex = 68;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click_1);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 510);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cbb_tenkhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb_mahoadon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Label lbe_tongthanhtien;
        private System.Windows.Forms.ComboBox cbb_mahoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_tenkhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_refresh;
    }
}