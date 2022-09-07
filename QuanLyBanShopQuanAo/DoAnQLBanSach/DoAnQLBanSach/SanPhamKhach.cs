using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public partial class SanPhamKhach : Form
    {
        Image DefaultImage;// ảnh mặc định khi chạy code
        Byte[] ImageByteArray;// mã hóa ảnh thành mảng băm
        public SanPhamKhach()
        {
            InitializeComponent();
            DefaultImage = ImgHinhAnh.Image;//ảnh mặc định
        }
        public static string TenDangNhap = "";
        XuLySanPhamKhach dt = new XuLySanPhamKhach();
        private void SanPhamKhach_Load(object sender, EventArgs e)
        {
            //load hang
            dataGridViewSanPham.DataSource = dt.LoadDataHang();
            //vo hieu qua
            txt_donGiaban.Enabled = false;
            //hien thi tong so luong san pham
            btn_xemgio.Text = "(" + dt.TongGioHang().ToString() + ") Xem giỏ";

        }

        private void dataGridViewSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.CurrentRow != null)
            {
                //hien thi
                txt_mahang.Text = dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString();
                txt_tenHang.Text = dataGridViewSanPham.CurrentRow.Cells[1].Value.ToString();
                txt_donGiaban.Text = dataGridViewSanPham.CurrentRow.Cells[5].Value.ToString();
                //hien thi hinh anh
                byte[] ImageArray = (byte[])dataGridViewSanPham.CurrentRow.Cells[7].Value;// lấy lại ảnh đã mã hóa và xuất lên ảnh mặc định
                if (ImageArray.Length == 0)// nếu mảng băm của ảnh rỗng hoặc sai
                    ImgHinhAnh.Image = DefaultImage;// ảnh hiện tại =ảnh mặc định
                else//thành công
                {
                    ImageByteArray = ImageArray;
                    ImgHinhAnh.Image = Image.FromStream(new MemoryStream(ImageArray));// lấy lại ảnh đã mã hóa và xuất lên ảnh mặc định
                }
            }
        }

        private void btn_mua_Click(object sender, EventArgs e)
        {
            
            if (dt.KTRong(txt_mahang.Text,txt_soluong.Text,txt_donGiaban.Text,txt_mahoadon.Text)==false)
            {
                return;
            }
            if(txt_soluong.Text=="0")//so luong bang 0
            {
                MessageBox.Show("Số lượng Đặt hàng phải lớn hơn 0", "Thông báo");
                return;
            }
            if(dt.SoLuongKho(txt_mahang.Text,int.Parse(txt_soluong.Text))==false)//không đủ số lượng đáp ứng
            {
                MessageBox.Show("Số lượng mặc hàng không đủ", "Thông báo");
                return;
            }
            if(dt.ktMuaTep(txt_mahoadon.Text,txt_mahang.Text)==true)//chưa có sản phẩm này trông giỏ
            {
                //kiem tra ma hoa don
                if (txt_mahoadon.Enabled == true)
                {
                    if (dt.ktkhoaCHoaDon(txt_mahoadon.Text) == false)
                    {
                        MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông báo");
                        return;
                    }
                    //vo hieu qua
                    txt_mahoadon.Enabled = false;
                }
                if (dt.Mua(txt_mahoadon.Text,TenDangNhap,txt_mahang.Text,int.Parse(txt_soluong.Text),int.Parse(txt_donGiaban.Text))==true)//mua thanh cong
                {
                    //load hang
                    dataGridViewSanPham.DataSource = dt.LoadDataHang();
                    MessageBox.Show("Sản Phẩm được thêm vào giỏ", "Thông báo");
                    btn_xemgio.Text = "(" + dt.TongGioHang().ToString() + ") Xem giỏ";
                    txt_soluong.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Mua Hàng Thất Bại", "Thông Báo");
                    return;
                }
            }
            else//đã có sản phẩm này trong giỏ
            {
                if(dt.MuaTiep(txt_mahoadon.Text,TenDangNhap,txt_mahang.Text,int.Parse(txt_soluong.Text))==true)//thanh cong
                {
                    //load hang
                    dataGridViewSanPham.DataSource = dt.LoadDataHang();
                    MessageBox.Show("Sản Phẩm Tiếp tục được thêm vào giỏ", "Thông báo");
                    btn_xemgio.Text = "(" + dt.TongGioHang().ToString() + ") Xem giỏ";
                    txt_soluong.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Mua Tiếp Hàng Thất Bại", "Thông Báo");
                    return;
                }
            }
        }

        private void btn_xemgio_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonKhach k = new ChiTietHoaDonKhach();
            k.Show();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            //tim
            dataGridViewSanPham.DataSource = dt.Timhang(txt_Tim.Text);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //load hang
            dataGridViewSanPham.DataSource = dt.LoadDataHang();
        }
    }
}
