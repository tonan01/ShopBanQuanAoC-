namespace DoAnQLBanSach
{
    partial class ThongTinKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinKhach));
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_chinhsua = new System.Windows.Forms.Button();
            this.txt_Tenkhachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(788, 317);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(226, 22);
            this.txt_diachi.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(788, 264);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(226, 22);
            this.txt_dienthoai.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Điện thoai:";
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Image = ((System.Drawing.Image)(resources.GetObject("btn_chinhsua.Image")));
            this.btn_chinhsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chinhsua.Location = new System.Drawing.Point(831, 374);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(131, 30);
            this.btn_chinhsua.TabIndex = 35;
            this.btn_chinhsua.Text = "Chỉnh Sửa";
            this.btn_chinhsua.UseVisualStyleBackColor = true;
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // txt_Tenkhachhang
            // 
            this.txt_Tenkhachhang.Location = new System.Drawing.Point(788, 210);
            this.txt_Tenkhachhang.Name = "txt_Tenkhachhang";
            this.txt_Tenkhachhang.Size = new System.Drawing.Size(226, 22);
            this.txt_Tenkhachhang.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã khách Hàng:";
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.AllowUserToAddRows = false;
            this.dataGridViewKhachHang.AllowUserToDeleteRows = false;
            this.dataGridViewKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.ReadOnly = true;
            this.dataGridViewKhachHang.RowTemplate.Height = 24;
            this.dataGridViewKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(620, 413);
            this.dataGridViewKhachHang.TabIndex = 29;
            this.dataGridViewKhachHang.SelectionChanged += new System.EventHandler(this.dataGridViewKhachHang_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DienThoai";
            this.Column3.HeaderText = "Điện Thoại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(429, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quản Lý Thông Tin";
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(788, 157);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(226, 22);
            this.txt_makhachhang.TabIndex = 40;
            // 
            // ThongTinKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 501);
            this.Controls.Add(this.txt_makhachhang);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_chinhsua);
            this.Controls.Add(this.txt_Tenkhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin";
            this.Load += new System.EventHandler(this.ThongTinKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_chinhsua;
        private System.Windows.Forms.TextBox txt_Tenkhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_makhachhang;
    }
}