namespace DoAnQLBanSach
{
    partial class InHoaDon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 30);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1343, 481);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(34, 2);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(174, 22);
            this.txt_mahoadon.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(215, 1);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(126, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 511);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txt_mahoadon);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "InHoaDon";
            this.Text = "In hóa Đơn";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Button btn_load;
    }
}