namespace DoAnQLBanSach
{
    partial class ThongKe
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
            this.lb_soluongkhach = new System.Windows.Forms.Label();
            this.lb_soluongnhanvien = new System.Windows.Forms.Label();
            this.lb_soluonghang = new System.Windows.Forms.Label();
            this.lb_slsanphamdaban = new System.Windows.Forms.Label();
            this.lb_sldondathanhtoan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbe_tongthanhtien = new System.Windows.Forms.Label();
            this.lb_loaisanpham = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_soluongkhach
            // 
            this.lb_soluongkhach.AutoSize = true;
            this.lb_soluongkhach.Location = new System.Drawing.Point(52, 67);
            this.lb_soluongkhach.Name = "lb_soluongkhach";
            this.lb_soluongkhach.Size = new System.Drawing.Size(116, 17);
            this.lb_soluongkhach.TabIndex = 0;
            this.lb_soluongkhach.Text = "Số lượng Khách: ";
            // 
            // lb_soluongnhanvien
            // 
            this.lb_soluongnhanvien.AutoSize = true;
            this.lb_soluongnhanvien.Location = new System.Drawing.Point(391, 109);
            this.lb_soluongnhanvien.Name = "lb_soluongnhanvien";
            this.lb_soluongnhanvien.Size = new System.Drawing.Size(142, 17);
            this.lb_soluongnhanvien.TabIndex = 1;
            this.lb_soluongnhanvien.Text = "Số lượng Nhân Viên: ";
            // 
            // lb_soluonghang
            // 
            this.lb_soluonghang.AutoSize = true;
            this.lb_soluonghang.Location = new System.Drawing.Point(52, 109);
            this.lb_soluonghang.Name = "lb_soluonghang";
            this.lb_soluonghang.Size = new System.Drawing.Size(110, 17);
            this.lb_soluonghang.TabIndex = 2;
            this.lb_soluonghang.Text = "Số lượng Hàng: ";
            // 
            // lb_slsanphamdaban
            // 
            this.lb_slsanphamdaban.AutoSize = true;
            this.lb_slsanphamdaban.Location = new System.Drawing.Point(52, 162);
            this.lb_slsanphamdaban.Name = "lb_slsanphamdaban";
            this.lb_slsanphamdaban.Size = new System.Drawing.Size(191, 17);
            this.lb_slsanphamdaban.TabIndex = 3;
            this.lb_slsanphamdaban.Text = "Số lượng Sản Phẩm Đã bán: ";
            // 
            // lb_sldondathanhtoan
            // 
            this.lb_sldondathanhtoan.AutoSize = true;
            this.lb_sldondathanhtoan.Location = new System.Drawing.Point(391, 67);
            this.lb_sldondathanhtoan.Name = "lb_sldondathanhtoan";
            this.lb_sldondathanhtoan.Size = new System.Drawing.Size(206, 17);
            this.lb_sldondathanhtoan.TabIndex = 4;
            this.lb_sldondathanhtoan.Text = "Số lượng Đơn Đã Thanh Toán: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(361, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 37);
            this.label8.TabIndex = 61;
            this.label8.Text = "Thống Kê";
            // 
            // lbe_tongthanhtien
            // 
            this.lbe_tongthanhtien.AutoSize = true;
            this.lbe_tongthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbe_tongthanhtien.ForeColor = System.Drawing.Color.Red;
            this.lbe_tongthanhtien.Location = new System.Drawing.Point(240, 248);
            this.lbe_tongthanhtien.Name = "lbe_tongthanhtien";
            this.lbe_tongthanhtien.Size = new System.Drawing.Size(138, 17);
            this.lbe_tongthanhtien.TabIndex = 62;
            this.lbe_tongthanhtien.Text = "Tông Thành Tiền:";
            // 
            // lb_loaisanpham
            // 
            this.lb_loaisanpham.AutoSize = true;
            this.lb_loaisanpham.Location = new System.Drawing.Point(391, 162);
            this.lb_loaisanpham.Name = "lb_loaisanpham";
            this.lb_loaisanpham.Size = new System.Drawing.Size(167, 17);
            this.lb_loaisanpham.TabIndex = 63;
            this.lb_loaisanpham.Text = "Số lượng loại Sản Phẩm: ";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 294);
            this.Controls.Add(this.lb_loaisanpham);
            this.Controls.Add(this.lbe_tongthanhtien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_sldondathanhtoan);
            this.Controls.Add(this.lb_slsanphamdaban);
            this.Controls.Add(this.lb_soluonghang);
            this.Controls.Add(this.lb_soluongnhanvien);
            this.Controls.Add(this.lb_soluongkhach);
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_soluongkhach;
        private System.Windows.Forms.Label lb_soluongnhanvien;
        private System.Windows.Forms.Label lb_soluonghang;
        private System.Windows.Forms.Label lb_slsanphamdaban;
        private System.Windows.Forms.Label lb_sldondathanhtoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbe_tongthanhtien;
        private System.Windows.Forms.Label lb_loaisanpham;
    }
}