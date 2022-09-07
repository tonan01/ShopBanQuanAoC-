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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        XuLyKhachHang dt = new XuLyKhachHang();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            //load du lieu khach hang
            dataGridViewKhachHang.DataSource = dt.LoadDataKhach();
            //load combobox all tai khoan
            cbbmakhachhang.DataSource = dt.loadcbbAllTaiKhoan();
            cbbmakhachhang.DisplayMember = "TaiKhoan";
            cbbmakhachhang.ValueMember = "TaiKhoan";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = false;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //load combobox chưa được sử dụng cho khách hàng vì khóa chính của table dangnhap là cũng vừa là khóa chính và vừa là khóa ngoại
            //của table khach vì vậy làm combobox này để người dùng dễ phân biệt không bị ghi sai
            cbbmakhachhang.DataSource = dt.loadcbbTaiKhoanChuaCoKhach();
            cbbmakhachhang.DisplayMember = "TaiKhoan";
            cbbmakhachhang.ValueMember = "TaiKhoan";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
        }
        //xoa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dt.ktkhoaNgoai(cbbmakhachhang.SelectedValue.ToString().Trim()) == false)//có tồn tại khóa ngoại
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng \n Hãy kiểm tra khóa chính của Hóa Đơn Bán", "Thông Báo");
                    return;
                }
                if(dt.ktkhoaC(cbbmakhachhang.SelectedValue.ToString())==true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã khách hàng chưa được áp dụng cho khác hàng xin vui lòng chọn mã khác ", "Thông Báo");
                    return;
                }
                if (dt.Xoa(cbbmakhachhang.SelectedValue.ToString().Trim()))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thêm tài khoản
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(cbbmakhachhang.SelectedValue.ToString(), txt_Tenkhachhang.Text,txt_dienthoai.Text,txt_diachi.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.them(cbbmakhachhang.SelectedValue.ToString(), txt_Tenkhachhang.Text, txt_dienthoai.Text, txt_diachi.Text))
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
                if (dt.KTRong(cbbmakhachhang.SelectedValue.ToString(), txt_Tenkhachhang.Text, txt_dienthoai.Text, txt_diachi.Text) == false)//không rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(cbbmakhachhang.SelectedValue.ToString()) == true)//không có mã khách trong bảng khách
                {
                    MessageBox.Show("Mã khách hàng chưa được áp dụng cho khách hàng xin vui lòng chọn mã khác ", "Thông Báo");
                    return;
                }
                if (dt.Sua(cbbmakhachhang.SelectedValue.ToString(), txt_Tenkhachhang.Text, txt_dienthoai.Text, txt_diachi.Text))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                    return;
                }
            }
            //load combobox all tai khoan
            cbbmakhachhang.DataSource = dt.loadcbbAllTaiKhoan();
            cbbmakhachhang.DisplayMember = "TaiKhoan";
            cbbmakhachhang.ValueMember = "TaiKhoan";
            //vô hiệu hóa btn
            btnLuu.Enabled = false;
            //btn có hiệu lực
            btn_sua.Enabled = btn_xoa.Enabled = btnThem.Enabled = true;
        }

        private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.CurrentRow != null)
            {
                
                cbbmakhachhang.SelectedValue = dataGridViewKhachHang.CurrentRow.Cells[0].Value.ToString().Trim();
                txt_Tenkhachhang.Text = dataGridViewKhachHang.CurrentRow.Cells[1].Value.ToString();
                txt_dienthoai.Text = dataGridViewKhachHang.CurrentRow.Cells[2].Value.ToString();
                txt_diachi.Text = dataGridViewKhachHang.CurrentRow.Cells[3].Value.ToString();
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled = true;
                //btn vo hieu luc
                btnLuu.Enabled = false;
            }
        }
    }
}
