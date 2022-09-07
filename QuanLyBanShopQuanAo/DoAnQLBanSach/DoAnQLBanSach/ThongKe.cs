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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        XulyThongKe dt = new XulyThongKe();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            lb_soluongkhach.Text = lb_soluongkhach.Text + dt.HienThiTongkhach().ToString();
            lb_soluonghang.Text = lb_soluonghang.Text + dt.HienThiTonghang().ToString();
            lb_soluongnhanvien.Text = lb_soluongnhanvien.Text + dt.HienThiTongnhanvien().ToString();
            lb_slsanphamdaban.Text = lb_slsanphamdaban.Text + dt.HienThiTongsanphamdaban().ToString();
            lb_loaisanpham.Text = lb_loaisanpham.Text + dt.HienThiTongloaisanpham().ToString();
            lb_sldondathanhtoan.Text = lb_sldondathanhtoan.Text + dt.HienThiTonghoadathanhtoan().ToString();
            lbe_tongthanhtien.Text = lbe_tongthanhtien.Text + dt.HienThiTongTien().ToString() + "VNĐ";
            
        }
    }
}
