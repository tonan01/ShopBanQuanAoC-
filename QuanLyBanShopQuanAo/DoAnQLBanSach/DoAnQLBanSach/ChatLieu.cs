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
    public partial class ChatLieu : Form
    {
        public ChatLieu()
        {
            InitializeComponent();
        }
        XuLyChatLieu dt = new XuLyChatLieu();
        private void btnThem_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;

            txt_machatlieu.Clear();
            txt_tenchatlieu.Clear();
            txt_machatlieu.Focus();
        }

        private void dataGridViewChatLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChatLieu.CurrentRow != null)
            {
                btnLuu.Enabled = false;
                txt_machatlieu.Text = dataGridViewChatLieu.CurrentRow.Cells[0].Value.ToString();
                txt_tenchatlieu.Text = dataGridViewChatLieu.CurrentRow.Cells[1].Value.ToString();
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (txt_machatlieu.Text.Length == 0)//rong
                {
                    MessageBox.Show("Mã Chất Liệu không được để trống", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaC(txt_machatlieu.Text))//khong co khoa chinh
                {
                    MessageBox.Show("Mã Chất Liệu không tồn tại", "Thông Báo");
                    return;
                }
                if (dt.ktkhoaNgoai(txt_machatlieu.Text) == false)//có tồn tại khóa ngoại
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng \n Hãy kiểm tra Mã chất liệu của Hàng", "Thông Báo");
                    return;
                }
                if (dt.Xoa(txt_machatlieu.Text))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                    return;
                }
                txt_machatlieu.Clear();
                txt_tenchatlieu.Clear();
                txt_machatlieu.Focus();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
            txt_tenchatlieu.Focus();
        }
        //lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thêm tài khoản
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(txt_machatlieu.Text.Trim(), txt_tenchatlieu.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(txt_machatlieu.Text) == false)//có tồn tại khóa chnh
                {
                    MessageBox.Show("Mã chất liệu Đã tồn tại", "Thông Báo");
                    return;
                }
                if (dt.them(txt_machatlieu.Text, txt_tenchatlieu.Text))
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
                if (dt.KTRong(txt_machatlieu.Text, txt_tenchatlieu.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(txt_machatlieu.Text) == true)//có tồn tại khóa chnh
                {
                    MessageBox.Show("Mã chất Liệu Không  tồn tại", "Thông Báo");
                    return;
                }
                if (dt.Sua(txt_machatlieu.Text, txt_tenchatlieu.Text))
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

        private void ChatLieu_Load(object sender, EventArgs e)
        {
            //load grv tai khoan len
            dataGridViewChatLieu.DataSource = dt.LoadDataChatLieu();
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = false;
        }
    }
}
