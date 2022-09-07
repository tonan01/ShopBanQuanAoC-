namespace DoAnQLBanSach
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgHinhAnh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_tenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_donGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_donGiaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.cbbmachatlieu = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "SẢN PHẨM";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AllowUserToAddRows = false;
            this.dataGridViewSanPham.AllowUserToDeleteRows = false;
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.ReadOnly = true;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(756, 300);
            this.dataGridViewSanPham.TabIndex = 5;
            this.dataGridViewSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellContentClick);
            this.dataGridViewSanPham.SelectionChanged += new System.EventHandler(this.dataGridViewSanPham_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHang";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHang";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaChatLieu";
            this.Column3.HeaderText = "Mã Chất Liệu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SL";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonGiaNhap";
            this.Column5.HeaderText = "Đơn Giá Nhập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DonGiaBan";
            this.Column6.HeaderText = "Đơn Giá Bán";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GhiChu";
            this.Column7.HeaderText = "Ghi Chú";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Anh";
            this.Column8.HeaderText = "Hình Ảnh";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // ImgHinhAnh
            // 
            this.ImgHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("ImgHinhAnh.Image")));
            this.ImgHinhAnh.Location = new System.Drawing.Point(774, 51);
            this.ImgHinhAnh.Name = "ImgHinhAnh";
            this.ImgHinhAnh.Size = new System.Drawing.Size(310, 300);
            this.ImgHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHinhAnh.TabIndex = 6;
            this.ImgHinhAnh.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã hàng:";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(114, 363);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(226, 22);
            this.txt_mahang.TabIndex = 8;
            this.txt_mahang.TextChanged += new System.EventHandler(this.txt_mahang_TextChanged);
            // 
            // txt_tenHang
            // 
            this.txt_tenHang.Location = new System.Drawing.Point(114, 391);
            this.txt_tenHang.Name = "txt_tenHang";
            this.txt_tenHang.Size = new System.Drawing.Size(226, 22);
            this.txt_tenHang.TabIndex = 10;
            this.txt_tenHang.TextChanged += new System.EventHandler(this.txt_tenHang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(114, 447);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(226, 22);
            this.txt_soluong.TabIndex = 14;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số lượng:";
            // 
            // txt_donGiaNhap
            // 
            this.txt_donGiaNhap.Location = new System.Drawing.Point(114, 475);
            this.txt_donGiaNhap.Name = "txt_donGiaNhap";
            this.txt_donGiaNhap.Size = new System.Drawing.Size(226, 22);
            this.txt_donGiaNhap.TabIndex = 16;
            this.txt_donGiaNhap.TextChanged += new System.EventHandler(this.txt_donGiaNhap_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đơn giá nhập:";
            // 
            // txt_donGiaban
            // 
            this.txt_donGiaban.Location = new System.Drawing.Point(114, 503);
            this.txt_donGiaban.Name = "txt_donGiaban";
            this.txt_donGiaban.Size = new System.Drawing.Size(226, 22);
            this.txt_donGiaban.TabIndex = 18;
            this.txt_donGiaban.TextChanged += new System.EventHandler(this.txt_donGiaban_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Đơn giá bán:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(114, 531);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(226, 22);
            this.txtGhiChu.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ghi chú:";
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(374, 425);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 30);
            this.btn_sua.TabIndex = 23;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(371, 523);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 30);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(374, 475);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(167, 578);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 35);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(774, 368);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(301, 45);
            this.btn_Browse.TabIndex = 25;
            this.btn_Browse.Text = "BROWSE";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // cbbmachatlieu
            // 
            this.cbbmachatlieu.FormattingEnabled = true;
            this.cbbmachatlieu.Location = new System.Drawing.Point(114, 420);
            this.cbbmachatlieu.Name = "cbbmachatlieu";
            this.cbbmachatlieu.Size = new System.Drawing.Size(226, 24);
            this.cbbmachatlieu.TabIndex = 26;
            // 
            // btn_clear
            // 
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(629, 368);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(116, 45);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(15, 12);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(256, 22);
            this.txt_Tim.TabIndex = 28;
            this.txt_Tim.TextChanged += new System.EventHandler(this.txt_Tim_TextChanged);
            // 
            // btn_tim
            // 
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim.Location = new System.Drawing.Point(292, 6);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 34);
            this.btn_tim.TabIndex = 29;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(607, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(152, 29);
            this.btn_refresh.TabIndex = 78;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 625);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cbbmachatlieu);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_donGiaban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_donGiaNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgHinhAnh);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.label1);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.PictureBox ImgHinhAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_tenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_donGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_donGiaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.ComboBox cbbmachatlieu;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_refresh;
    }
}