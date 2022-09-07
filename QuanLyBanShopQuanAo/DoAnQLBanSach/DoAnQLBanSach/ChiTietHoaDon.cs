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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        XyLyChiTietHoaDon dt = new XyLyChiTietHoaDon();
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            //load chi tieet hoa don
            dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDon();
            //load combobox
            cbbMaHang.DataSource = dt.loadcbbMaHang();
            cbbMaHang.DisplayMember = "MaHang";
            cbbMaHang.ValueMember = "MaHang";
            //load combobox
            cbbmahoadon.DataSource = dt.loadcbbhoadon();
            cbbmahoadon.DisplayMember = "MaHD";
            cbbmahoadon.ValueMember = "MaHD";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = txt_dongia.Enabled = false;
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hien thi don gia khi chon combobox
            txt_dongia.Text = dt.showdongia(cbbMaHang.SelectedValue.ToString()).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //load combobox
            cbbmahoadon.DataSource = dt.loadmahoadonchuathanhtoan();
            cbbmahoadon.DisplayMember = "MaHD";
            cbbmahoadon.ValueMember = "MaHD";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;

            txt_soluong.Clear();
            txt_soluong.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //load combobox
            cbbmahoadon.DataSource = dt.loadmahoadonchuathanhtoan();
            cbbmahoadon.DisplayMember = "MaHD";
            cbbmahoadon.ValueMember = "MaHD";
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dt.KThddathanhtoan(cbbmahoadon.SelectedValue.ToString())==true)//hóa đơn đã thanh toán
            {
                MessageBox.Show("Hóa đơn này đã thanh toán", "Thông Báo");
                return;
            }
            if(txt_soluong.Text=="0")//so luong bang 0
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông Báo");
                return;
            }
            //thêm tài khoản
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(txt_soluong.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString()) == false)
                {
                    MessageBox.Show("Mã chi tiết hóa đơn đã tồn tại", "Thông Báo");
                    return;
                }
                if(dt.ktsoluong(cbbMaHang.SelectedValue.ToString(),int.Parse(txt_soluong.Text))==false)//khong du
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ yêu cầu", "Thông Báo");
                    return;
                }
                if (dt.them(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString(), int.Parse(txt_soluong.Text), int.Parse(txt_dongia.Text)))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDon();
                    //load combobox
                    cbbmahoadon.DataSource = dt.loadcbbhoadon();
                    cbbmahoadon.DisplayMember = "MaHD";
                    cbbmahoadon.ValueMember = "MaHD";
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
                if (dt.KTRong(txt_soluong.Text) == false)//không rỗng
                {
                    return;
                }
                if(dt.KTsoluonghang(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString(), int.Parse(txt_soluong.Text))==false)
                {
                    MessageBox.Show("Số lượng hàng không đủ đáp ứng", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaC(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString()) == true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã hóa đơn và mã hàng đã không tồn tại ", "Thông Báo");
                    return;
                }
                if (dt.sua(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString(), int.Parse(txt_soluong.Text), int.Parse(txt_dongia.Text)))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    //load combobox
                    cbbmahoadon.DataSource = dt.loadcbbhoadon();
                    cbbmahoadon.DisplayMember = "MaHD";
                    cbbmahoadon.ValueMember = "MaHD";
                    dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDon();
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

        private void dataGridViewChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTietHoaDon.CurrentRow != null)
            {
                cbbmahoadon.SelectedValue = dataGridViewChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
                cbbMaHang.SelectedValue = dataGridViewChiTietHoaDon.CurrentRow.Cells[1].Value.ToString();
                txt_soluong.Text = dataGridViewChiTietHoaDon.CurrentRow.Cells[2].Value.ToString();
                txt_dongia.Text = dataGridViewChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled = true;
                //btn vo hieu luc
                btnLuu.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dt.ktkhoaC(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString()) == true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã hóa đơn và mã hàng đã không tồn tại ", "Thông Báo");
                    return;
                }
                if (dt.xoa(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                    dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDon();
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                    return;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDon();
        }
    }
}
