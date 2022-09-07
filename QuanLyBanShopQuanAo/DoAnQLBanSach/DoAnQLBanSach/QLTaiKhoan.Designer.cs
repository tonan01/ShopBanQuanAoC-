namespace DoAnQLBanSach
{
    partial class QLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_quyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(429, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // dataGridViewTaiKhoan
            // 
            this.dataGridViewTaiKhoan.AllowUserToAddRows = false;
            this.dataGridViewTaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridViewTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewTaiKhoan.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewTaiKhoan.Name = "dataGridViewTaiKhoan";
            this.dataGridViewTaiKhoan.ReadOnly = true;
            this.dataGridViewTaiKhoan.RowTemplate.Height = 24;
            this.dataGridViewTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTaiKhoan.Size = new System.Drawing.Size(484, 530);
            this.dataGridViewTaiKhoan.TabIndex = 4;
            this.dataGridViewTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTaiKhoan_CellContentClick);
            this.dataGridViewTaiKhoan.SelectionChanged += new System.EventHandler(this.dataGridViewTaiKhoan_SelectionChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(678, 215);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(226, 22);
            this.txt_password.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(678, 162);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(226, 22);
            this.txt_taikhoan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài Khoản:";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(539, 370);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(712, 370);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 30);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(890, 370);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 30);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(953, 156);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 35);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TaiKhoan";
            this.Column1.HeaderText = "Tài Khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Pass";
            this.Column2.HeaderText = "Pass";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaQuyen";
            this.Column3.HeaderText = "Mã Quyền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cbb_quyen
            // 
            this.cbb_quyen.FormattingEnabled = true;
            this.cbb_quyen.Location = new System.Drawing.Point(678, 262);
            this.cbb_quyen.Name = "cbb_quyen";
            this.cbb_quyen.Size = new System.Drawing.Size(226, 24);
            this.cbb_quyen.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quyền:";
            // 
            // QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_quyen);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "QLTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.QLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTaiKhoan;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cbb_quyen;
        private System.Windows.Forms.Label label4;
    }
}