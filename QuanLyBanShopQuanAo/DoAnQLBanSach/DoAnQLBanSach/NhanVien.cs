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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        XuLyNhanVien dt = new XuLyNhanVien();
        private void btnThem_Click(object sender, EventArgs e)
        {
            //load combobox tai khoản nhân viên
            cbb_manhanvien.DataSource = dt.loadcbbTaiKhoanChuaCoNhanVien();
            cbb_manhanvien.DisplayMember = "TaiKhoan";
            cbb_manhanvien.ValueMember = "TaiKhoan";
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
            txt_Tennhanvien.Clear();
            txt_dienthoai.Clear();
            txt_diachi.Clear();
        }
        public string chonrdb()
        {
            if(rdb_nam.Checked==true)//chọn nam
            {
                return "Nam";
            }
            else//chọn nữ
            {
                return "Nữ";
            }
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            //load combobox tai khoản nhân viên
            cbb_manhanvien.DataSource = dt.loadcbbAllTaiKhoanNV();
            cbb_manhanvien.DisplayMember="TaiKhoan";
            cbb_manhanvien.ValueMember = "TaiKhoan";
            //load du lieu nhân viên
            dataGridViewNhanVien.DataSource = dt.LoadDataNhanVien();
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = false;
        }

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.CurrentRow != null)
            {
                btnLuu.Enabled = false;
                cbb_manhanvien.SelectedValue = dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString();
                txt_Tennhanvien.Text = dataGridViewNhanVien.CurrentRow.Cells[1].Value.ToString();
                if(rdb_nam.Text == dataGridViewNhanVien.CurrentRow.Cells[2].Value.ToString())
                {
                    rdb_nam.Checked = true;//chon nam
                }
                else
                {
                    rdb_Nu.Checked = true;//chọn nữ
                }
                txt_dienthoai.Text = dataGridViewNhanVien.CurrentRow.Cells[3].Value.ToString();
                txt_diachi.Text = dataGridViewNhanVien.CurrentRow.Cells[4].Value.ToString();
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                if (dt.ktkhoaNgoai(cbb_manhanvien.SelectedValue.ToString()) == false)//có tồn tại khóa ngoại
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng \n Hãy kiểm tra mã nhân viên của Hóa Đơn Bán", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaC(cbb_manhanvien.SelectedValue.ToString()) == true)//không có nhan vien nay
                {
                    MessageBox.Show("Mã nhân viên không tồn tại ", "Thông Báo");
                    return;
                }
                if (dt.Xoa(cbb_manhanvien.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thêm 
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(cbb_manhanvien.SelectedValue.ToString(), txt_Tennhanvien.Text, txt_dienthoai.Text, txt_diachi.Text) == false)// rỗng
                {
                    return;
                }

                if (dt.them(cbb_manhanvien.SelectedValue.ToString(), txt_Tennhanvien.Text,chonrdb(), txt_dienthoai.Text, txt_diachi.Text))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                    return;
                }
            }
            //Sửa 
            if (btn_sua.Enabled == true)//btn Sửa co hieu luc
            {
                if (dt.KTRong(cbb_manhanvien.SelectedValue.ToString(), txt_Tennhanvien.Text, txt_dienthoai.Text, txt_diachi.Text) == false)//không rỗng
                {
                    return;
                }
                if (dt.Sua(cbb_manhanvien.SelectedValue.ToString(), txt_Tennhanvien.Text, chonrdb(), txt_dienthoai.Text, txt_diachi.Text))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                    return;
                }
            }
            //load combobox tai khoản nhân viên
            cbb_manhanvien.DataSource = dt.loadcbbTaiKhoanChuaCoNhanVien();
            cbb_manhanvien.DisplayMember = "TaiKhoan";
            cbb_manhanvien.ValueMember = "TaiKhoan";
            //vô hiệu hóa btn
            btnLuu.Enabled = false;
            //btn có hiệu lực
            btn_sua.Enabled = btn_xoa.Enabled = btnThem.Enabled = true;
        }
    }
}
