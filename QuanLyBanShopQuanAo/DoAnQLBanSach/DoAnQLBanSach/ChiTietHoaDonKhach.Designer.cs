namespace DoAnQLBanSach
{
    partial class ChiTietHoaDonKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDonKhach));
            this.cbbmahoadon = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cbbMaHang = new System.Windows.Forms.ComboBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbmahoadon
            // 
            this.cbbmahoadon.FormattingEnabled = true;
            this.cbbmahoadon.Location = new System.Drawing.Point(859, 134);
            this.cbbmahoadon.Name = "cbbmahoadon";
            this.cbbmahoadon.Size = new System.Drawing.Size(226, 24);
            this.cbbmahoadon.TabIndex = 75;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(859, 244);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(226, 22);
            this.txt_soluong.TabIndex = 74;
            // 
            // cbbMaHang
            // 
            this.cbbMaHang.FormattingEnabled = true;
            this.cbbMaHang.Location = new System.Drawing.Point(859, 187);
            this.cbbMaHang.Name = "cbbMaHang";
            this.cbbMaHang.Size = new System.Drawing.Size(226, 24);
            this.cbbMaHang.TabIndex = 73;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(859, 295);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(226, 22);
            this.txt_dongia.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Số lượng";
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(818, 409);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 30);
            this.btn_sua.TabIndex = 68;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(988, 409);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 30);
            this.btn_xoa.TabIndex = 67;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // dataGridViewChiTietHoaDon
            // 
            this.dataGridViewChiTietHoaDon.AllowUserToAddRows = false;
            this.dataGridViewChiTietHoaDon.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewChiTietHoaDon.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewChiTietHoaDon.Name = "dataGridViewChiTietHoaDon";
            this.dataGridViewChiTietHoaDon.ReadOnly = true;
            this.dataGridViewChiTietHoaDon.RowTemplate.Height = 24;
            this.dataGridViewChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietHoaDon.Size = new System.Drawing.Size(691, 473);
            this.dataGridViewChiTietHoaDon.TabIndex = 63;
            this.dataGridViewChiTietHoaDon.SelectionChanged += new System.EventHandler(this.dataGridViewChiTietHoaDon_SelectionChanged);
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
            this.Column2.DataPropertyName = "MaHang";
            this.Column2.HeaderText = "Mã Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SL";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(430, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 62;
            this.label1.Text = "Quản Lý Chi Tiết Hóa Đơn";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(12, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(152, 29);
            this.btn_refresh.TabIndex = 76;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ChiTietHoaDonKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 545);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cbbmahoadon);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.cbbMaHang);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewChiTietHoaDon);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietHoaDonKhach";
            this.Text = "ChiTietHoaDonKhach";
            this.Load += new System.EventHandler(this.ChiTietHoaDonKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbmahoadon;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
    }
}