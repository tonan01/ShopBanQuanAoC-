using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        public static string ServerNameAdmin = "";//ten servername
        public static string HoaDonCanIn = "";//hoadon can in
        XuLyInHoaDon dt = new XuLyInHoaDon();
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            txt_mahoadon.Text = HoaDonCanIn;
            //vo hieu
            txt_mahoadon.Enabled = false;
            
        }

        private void cbb_chonhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            MyReport rpt = new MyReport();
            rpt.SetDataSource(dt.loadinhoadon(txt_mahoadon.Text));//hien thi du lieu in
            crystalReportViewer1.ReportSource = rpt;//lấy du liệu bảng myreport da thiết kế
            //Setdatabaselogon ko cần nhập lại khi showreport
            rpt.SetDatabaseLogon("sa", "123", ServerNameAdmin, "ShopQuanAo");
            
            

            crystalReportViewer1.DisplayStatusBar = false;//tắt hiển thị thanh trạng thái
            crystalReportViewer1.DisplayToolbar = true;//hiển thị thanh công cụ
            
        }
    }
}
