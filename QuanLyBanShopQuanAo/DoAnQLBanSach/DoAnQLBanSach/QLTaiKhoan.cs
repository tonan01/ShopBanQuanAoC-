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
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }
        XuLyQLTaiKhoan dt = new XuLyQLTaiKhoan();

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            //load grv tai khoan len
            dataGridViewTaiKhoan.DataSource = dt.LoadDataTaiKhoan();
            //load tên quyền
            cbb_quyen.DataSource = dt.LoadQuyen();
            cbb_quyen.DisplayMember = "TenQuen";
            cbb_quyen.ValueMember = "MaQuyen";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = false;
        }

        //hien thi ra textbox
        private void dataGridViewTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTaiKhoan.CurrentRow != null)
            {
                btnLuu.Enabled = false;
                txt_taikhoan.Text = dataGridViewTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                txt_password.Text = dataGridViewTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                cbb_quyen.SelectedValue = dataGridViewTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;

            txt_taikhoan.Clear();
            txt_password.Clear();
            txt_taikhoan.Focus();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
            txt_password.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thêm tài khoản
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(txt_taikhoan.Text.Trim(), txt_password.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(txt_taikhoan.Text) == false)//có tồn tại khóa chnh
                {
                    MessageBox.Show("Tài khoản Đã tồn tại", "Thông Báo");
                    return;
                }
                if (dt.them(txt_taikhoan.Text, txt_password.Text,cbb_quyen.SelectedValue.ToString()))
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
                if (txt_taikhoan.Text == "admin")
                {
                    MessageBox.Show("Bạn không thể sửa quyền tài khoản Admin", "Thông Báo");
                    return;
                }
                if (dt.KTRong(txt_taikhoan.Text, txt_password.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(txt_taikhoan.Text) == true)//có tồn tại khóa chnh
                {
                    MessageBox.Show("Tài khoản Không  tồn tại", "Thông Báo");
                    return;
                }
                if (dt.Sua(txt_taikhoan.Text, txt_password.Text, cbb_quyen.SelectedValue.ToString()))
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
            btnLuu.Enabled =  false;
            //btn có hiệu lực
            btn_sua.Enabled = btn_xoa.Enabled =btnThem.Enabled= true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(txt_taikhoan.Text=="admin")
                {
                    MessageBox.Show("Không được xóa tài khoản Admin", "Thông Báo");
                    return;
                }
                if (txt_taikhoan.Text.Length == 0)//rong
                {
                    MessageBox.Show("Tài khoản không được để trống", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaC(txt_taikhoan.Text))//khong co khoa chinh
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaNgoai(txt_taikhoan.Text) == false)//có tồn tại khóa ngoại
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng \n Hãy kiểm tra khóa chính của khách hàng", "Thông Báo");
                    return;
                }
                if (dt.Xoa(txt_taikhoan.Text))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                    return;
                }
                txt_taikhoan.Clear();
                txt_password.Clear();
                txt_taikhoan.Focus();
            }
            
        }

        private void dataGridViewTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
