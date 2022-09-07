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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";
        public static string HoaDonCanIn = "";//hoadon can in
        XuLyHoaDon dt = new XuLyHoaDon();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            //load dl hoa don
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDon();
            //load cbb mã khách
            cbb_makhachhang.DataSource = dt.loadcbbMaKhach();
            cbb_makhachhang.DisplayMember = "MaKH";
            cbb_makhachhang.ValueMember = "MaKH";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled=btn_huy.Enabled  = false;
            //combobox tình trạng
            string[] s = { "Trong giỏ", "Đang xử lý", "Đã thanh toán" };
            foreach(string item in s)
            {
                cbb_tinhtrang.Items.Add(item);
            }
        }
        //kiểm tra người làm hoa đơn la ai
        public string KTquyenadmin()
        {
            string tr = "";
            if(dt.KTQuyenAdmin(TenDangNhap)==true)//la admin
            {
                return tr = "null";
            }
            else
            {
                return tr = TenDangNhap;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
            txt_mahoadon.Clear();
            txt_mahoadon.Focus();
            txt_tongtien.Text = "0";
        }

        private void dataGridViewHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewHoaDon.CurrentRow!=null)
            {
                txt_mahoadon.Text = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
                dtimep_ngayban.Text = dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString();
                cbb_makhachhang.SelectedValue = dataGridViewHoaDon.CurrentRow.Cells[3].Value.ToString();
                txt_tongtien.Text = dataGridViewHoaDon.CurrentRow.Cells[4].Value.ToString();
                cbb_tinhtrang.SelectedItem = dataGridViewHoaDon.CurrentRow.Cells[5].Value.ToString();
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled=btn_huy.Enabled = true;
                //btn vo hieu luc
                btnLuu.Enabled = false;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dt.ktkhoaNgoai(txt_mahoadon.Text) == false)//có tồn tại khóa ngoại
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng \n Hãy kiểm tra khóa chính của chi tiết Hóa Đơn ", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaC(txt_mahoadon.Text) == true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại ", "Thông Báo");
                    return;
                }
                if (dt.Xoa(txt_mahoadon.Text))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thêm tài khoản
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(txt_mahoadon.Text) == false)// rỗng
                {
                    return;
                }
                if(dt.ktkhoaC(txt_mahoadon.Text)==false)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông Báo");
                    return;
                }
                if (dt.them(txt_mahoadon.Text,KTquyenadmin(),dtimep_ngayban.Value.ToShortDateString(), cbb_makhachhang.SelectedValue.ToString(),txt_tongtien.Text, cbb_tinhtrang.SelectedItem.ToString()))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                    return;
                }
            }
            //Sửa tài khoản
            if (btn_sua.Enabled == true)//btn Sửa co hieu luc
            {
                if (dt.KTRong(txt_mahoadon.Text) == false)//không rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(txt_mahoadon.Text) == true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại", "Thông Báo");
                    return;
                }
                if (dt.Sua(txt_mahoadon.Text, KTquyenadmin(), dtimep_ngayban.Value.ToShortDateString(), cbb_makhachhang.SelectedValue.ToString(),txt_tongtien.Text, cbb_tinhtrang.SelectedItem.ToString()))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                    return;
                }
            }
            //vô hiệu hóa btn
            btnLuu.Enabled = false;
            //btn có hiệu lực
            btn_sua.Enabled = btn_xoa.Enabled = btnThem.Enabled = true;
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn hủy bỏ hóa đơn này \nLưu ý:sẽ xóa luôn tất cả hóa đơn liên quan đến hóa đơn này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dt.ktkhoaC(txt_mahoadon.Text) == true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại ", "Thông Báo");
                    return;
                }
                if (dt.HuyHoaDon(txt_mahoadon.Text))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
            }
        }

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            //hoa don can in
            InHoaDon.HoaDonCanIn = txt_mahoadon.Text;
            InHoaDon i = new InHoaDon();
            i.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //load dl hoa don
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDon();
            //load cbb mã khách
            cbb_makhachhang.DataSource = dt.loadcbbMaKhach();
            cbb_makhachhang.DisplayMember = "MaKH";
            cbb_makhachhang.ValueMember = "MaKH";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = btn_huy.Enabled = false;
        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
