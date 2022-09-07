namespace DoAnQLBanSach
{
    partial class ChatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatLieu));
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txt_tenchatlieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_machatlieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewChatLieu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(948, 144);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 35);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(885, 358);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 30);
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(707, 358);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 30);
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(534, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_tenchatlieu
            // 
            this.txt_tenchatlieu.Location = new System.Drawing.Point(673, 203);
            this.txt_tenchatlieu.Name = "txt_tenchatlieu";
            this.txt_tenchatlieu.Size = new System.Drawing.Size(226, 22);
            this.txt_tenchatlieu.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên chất liệu:";
            // 
            // txt_machatlieu
            // 
            this.txt_machatlieu.Location = new System.Drawing.Point(673, 150);
            this.txt_machatlieu.Name = "txt_machatlieu";
            this.txt_machatlieu.Size = new System.Drawing.Size(226, 22);
            this.txt_machatlieu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã chất liệu:";
            // 
            // dataGridViewChatLieu
            // 
            this.dataGridViewChatLieu.AllowUserToAddRows = false;
            this.dataGridViewChatLieu.AllowUserToDeleteRows = false;
            this.dataGridViewChatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewChatLieu.Location = new System.Drawing.Point(7, 71);
            this.dataGridViewChatLieu.Name = "dataGridViewChatLieu";
            this.dataGridViewChatLieu.ReadOnly = true;
            this.dataGridViewChatLieu.RowTemplate.Height = 24;
            this.dataGridViewChatLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChatLieu.Size = new System.Drawing.Size(484, 530);
            this.dataGridViewChatLieu.TabIndex = 14;
            this.dataGridViewChatLieu.SelectionChanged += new System.EventHandler(this.dataGridViewChatLieu_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản Lý Chất Liệu";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaChatLieu";
            this.Column1.HeaderText = "Mã Chất Liệu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenChatLieu";
            this.Column2.HeaderText = "Tên Chất Liệu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 610);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txt_tenchatlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_machatlieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewChatLieu);
            this.Controls.Add(this.label1);
            this.Name = "ChatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chất Liệu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txt_tenchatlieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_machatlieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}