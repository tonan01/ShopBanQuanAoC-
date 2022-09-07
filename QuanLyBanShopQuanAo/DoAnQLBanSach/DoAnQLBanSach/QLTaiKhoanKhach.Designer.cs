namespace DoAnQLBanSach
{
    partial class QLTaiKhoanKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTaiKhoanKhach));
            this.btn_doimk = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_doimk
            // 
            this.btn_doimk.Image = ((System.Drawing.Image)(resources.GetObject("btn_doimk.Image")));
            this.btn_doimk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doimk.Location = new System.Drawing.Point(921, 207);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(136, 30);
            this.btn_doimk.TabIndex = 20;
            this.btn_doimk.Text = "Change";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(689, 211);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(226, 22);
            this.txt_password.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password:";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(689, 158);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(226, 22);
            this.txt_taikhoan.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tài Khoản:";
            // 
            // dataGridViewTaiKhoan
            // 
            this.dataGridViewTaiKhoan.AllowUserToAddRows = false;
            this.dataGridViewTaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridViewTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewTaiKhoan.Location = new System.Drawing.Point(23, 79);
            this.dataGridViewTaiKhoan.Name = "dataGridViewTaiKhoan";
            this.dataGridViewTaiKhoan.ReadOnly = true;
            this.dataGridViewTaiKhoan.RowTemplate.Height = 24;
            this.dataGridViewTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTaiKhoan.Size = new System.Drawing.Size(484, 282);
            this.dataGridViewTaiKhoan.TabIndex = 13;
            this.dataGridViewTaiKhoan.SelectionChanged += new System.EventHandler(this.dataGridViewTaiKhoan_SelectionChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(440, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // QLTaiKhoanKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 393);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "QLTaiKhoanKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTaiKhoanKhach";
            this.Load += new System.EventHandler(this.QLTaiKhoanKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}