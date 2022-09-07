namespace DoAnQLBanSach
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_makhachhang = new System.Windows.Forms.ComboBox();
            this.dtimep_ngayban = new System.Windows.Forms.DateTimePicker();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_inhoadon = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày bán:";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(877, 473);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 35);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(1056, 536);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 30);
            this.btn_sua.TabIndex = 35;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(877, 536);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 30);
            this.btn_xoa.TabIndex = 34;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(710, 536);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 30;
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
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.ReadOnly = true;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(691, 550);
            this.dataGridViewHoaDon.TabIndex = 29;
            this.dataGridViewHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellContentClick);
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
            this.Column6.HeaderText = "Tình Trạng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(429, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quản Lý Hóa Đơn";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(859, 291);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(226, 22);
            this.txt_tongtien.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Tổng tiền:";
            // 
            // cbb_makhachhang
            // 
            this.cbb_makhachhang.FormattingEnabled = true;
            this.cbb_makhachhang.Location = new System.Drawing.Point(859, 230);
            this.cbb_makhachhang.Name = "cbb_makhachhang";
            this.cbb_makhachhang.Size = new System.Drawing.Size(226, 24);
            this.cbb_makhachhang.TabIndex = 44;
            // 
            // dtimep_ngayban
            // 
            this.dtimep_ngayban.Location = new System.Drawing.Point(859, 184);
            this.dtimep_ngayban.Name = "dtimep_ngayban";
            this.dtimep_ngayban.Size = new System.Drawing.Size(226, 22);
            this.dtimep_ngayban.TabIndex = 45;
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(859, 139);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(226, 22);
            this.txt_mahoadon.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tình Trạng:";
            // 
            // cbb_tinhtrang
            // 
            this.cbb_tinhtrang.FormattingEnabled = true;
            this.cbb_tinhtrang.Location = new System.Drawing.Point(859, 344);
            this.cbb_tinhtrang.Name = "cbb_tinhtrang";
            this.cbb_tinhtrang.Size = new System.Drawing.Size(226, 24);
            this.cbb_tinhtrang.TabIndex = 49;
            // 
            // btn_huy
            // 
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(725, 62);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(113, 46);
            this.btn_huy.TabIndex = 50;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_inhoadon.Image")));
            this.btn_inhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inhoadon.Location = new System.Drawing.Point(1002, 62);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(148, 46);
            this.btn_inhoadon.TabIndex = 51;
            this.btn_inhoadon.Text = "In hóa đơn";
            this.btn_inhoadon.UseVisualStyleBackColor = true;
            this.btn_inhoadon.Click += new System.EventHandler(this.btn_inhoadon_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(12, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(152, 29);
            this.btn_refresh.TabIndex = 69;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 624);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_inhoadon);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.cbb_tinhtrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mahoadon);
            this.Controls.Add(this.dtimep_ngayban);
            this.Controls.Add(this.cbb_makhachhang);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.label1);
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_makhachhang;
        private System.Windows.Forms.DateTimePicker dtimep_ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_tinhtrang;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_inhoadon;
        private System.Windows.Forms.Button btn_refresh;
    }
}