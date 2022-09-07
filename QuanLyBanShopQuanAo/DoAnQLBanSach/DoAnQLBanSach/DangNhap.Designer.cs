namespace DoAnQLBanSach
{
    partial class DangNhap
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
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.labdangky = new System.Windows.Forms.Label();
            this.chk_online = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(237, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(229, 162);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(226, 22);
            this.txt_taikhoan.TabIndex = 2;
            this.txt_taikhoan.TextChanged += new System.EventHandler(this.txt_taikhoan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(229, 215);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(226, 22);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Location = new System.Drawing.Point(263, 299);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(126, 29);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // labdangky
            // 
            this.labdangky.AutoSize = true;
            this.labdangky.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdangky.ForeColor = System.Drawing.Color.Blue;
            this.labdangky.Location = new System.Drawing.Point(260, 355);
            this.labdangky.Name = "labdangky";
            this.labdangky.Size = new System.Drawing.Size(114, 16);
            this.labdangky.TabIndex = 6;
            this.labdangky.Text = "Đăng ký tài khoản";
            this.labdangky.Click += new System.EventHandler(this.labdangky_Click);
            // 
            // chk_online
            // 
            this.chk_online.AutoSize = true;
            this.chk_online.Location = new System.Drawing.Point(12, 12);
            this.chk_online.Name = "chk_online";
            this.chk_online.Size = new System.Drawing.Size(71, 21);
            this.chk_online.TabIndex = 7;
            this.chk_online.Text = "Online";
            this.chk_online.UseVisualStyleBackColor = true;
            this.chk_online.CheckedChanged += new System.EventHandler(this.chk_online_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 400);
            this.Controls.Add(this.chk_online);
            this.Controls.Add(this.labdangky);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label labdangky;
        private System.Windows.Forms.CheckBox chk_online;
    }
}