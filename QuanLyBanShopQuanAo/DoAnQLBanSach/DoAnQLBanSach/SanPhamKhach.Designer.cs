namespace DoAnQLBanSach
{
    partial class SanPhamKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamKhach));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgHinhAnh = new System.Windows.Forms.PictureBox();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_donGiaban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_mua = new System.Windows.Forms.Button();
            this.btn_xemgio = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-82, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Đơn giá bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-82, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Đơn giá nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-82, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tên hàng:";
            // 
            // ImgHinhAnh
            // 
            this.ImgHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("ImgHinhAnh.Image")));
            this.ImgHinhAnh.Location = new System.Drawing.Point(773, 51);
            this.ImgHinhAnh.Name = "ImgHinhAnh";
            this.ImgHinhAnh.Size = new System.Drawing.Size(310, 300);
            this.ImgHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHinhAnh.TabIndex = 30;
            this.ImgHinhAnh.TabStop = false;
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
            this.dataGridViewSanPham.Location = new System.Drawing.Point(11, 51);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.ReadOnly = true;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(756, 300);
            this.dataGridViewSanPham.TabIndex = 29;
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
            this.Column5.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "SẢN PHẨM";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(119, 437);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(226, 22);
            this.txt_soluong.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số lượng:";
            // 
            // txt_tenHang
            // 
            this.txt_tenHang.Location = new System.Drawing.Point(119, 409);
            this.txt_tenHang.Name = "txt_tenHang";
            this.txt_tenHang.Size = new System.Drawing.Size(226, 22);
            this.txt_tenHang.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên hàng:";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(119, 381);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(226, 22);
            this.txt_mahang.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã hàng:";
            // 
            // txt_donGiaban
            // 
            this.txt_donGiaban.Location = new System.Drawing.Point(119, 465);
            this.txt_donGiaban.Name = "txt_donGiaban";
            this.txt_donGiaban.Size = new System.Drawing.Size(226, 22);
            this.txt_donGiaban.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Đơn giá bán:";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(507, 381);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(226, 22);
            this.txt_mahoadon.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Mã Hóa Đơn:";
            // 
            // btn_mua
            // 
            this.btn_mua.Image = ((System.Drawing.Image)(resources.GetObject("btn_mua.Image")));
            this.btn_mua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mua.Location = new System.Drawing.Point(764, 437);
            this.btn_mua.Name = "btn_mua";
            this.btn_mua.Size = new System.Drawing.Size(148, 37);
            this.btn_mua.TabIndex = 53;
            this.btn_mua.Text = "Mua";
            this.btn_mua.UseVisualStyleBackColor = true;
            this.btn_mua.Click += new System.EventHandler(this.btn_mua_Click);
            // 
            // btn_xemgio
            // 
            this.btn_xemgio.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemgio.Image")));
            this.btn_xemgio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemgio.Location = new System.Drawing.Point(942, 437);
            this.btn_xemgio.Name = "btn_xemgio";
            this.btn_xemgio.Size = new System.Drawing.Size(148, 37);
            this.btn_xemgio.TabIndex = 54;
            this.btn_xemgio.Text = "Xem giỏ";
            this.btn_xemgio.UseVisualStyleBackColor = true;
            this.btn_xemgio.Click += new System.EventHandler(this.btn_xemgio_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim.Location = new System.Drawing.Point(292, 9);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 34);
            this.btn_tim.TabIndex = 56;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(15, 15);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(256, 22);
            this.txt_Tim.TabIndex = 55;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(615, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(152, 29);
            this.btn_refresh.TabIndex = 77;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // SanPhamKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 520);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_xemgio);
            this.Controls.Add(this.btn_mua);
            this.Controls.Add(this.txt_mahoadon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_donGiaban);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tenHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImgHinhAnh);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.label1);
            this.Name = "SanPhamKhach";
            this.Text = "SanPhamKhach";
            this.Load += new System.EventHandler(this.SanPhamKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgHinhAnh;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txt_donGiaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_mua;
        private System.Windows.Forms.Button btn_xemgio;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_refresh;
    }
}