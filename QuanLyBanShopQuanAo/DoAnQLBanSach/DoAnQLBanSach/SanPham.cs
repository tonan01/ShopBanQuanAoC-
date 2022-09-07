using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public partial class SanPham : Form
    {
        String DuongDanFile = "";//đường dẫn file
        Image DefaultImage;// ảnh mặc định khi chạy code
        Byte[] ImageByteArray;// mã hóa ảnh thành mảng băm
        //ham ket noi
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
       
        XuLySanPham dt = new XuLySanPham();
        public SanPham()
        {
            InitializeComponent();
            DefaultImage = ImgHinhAnh.Image;//ảnh mặc định


        }
        void Clear()// reset
        {
            txt_mahang.Clear();
            txt_tenHang.Clear();
            txt_soluong.Clear();
            txt_donGiaNhap.Clear();
            txt_donGiaban.Clear();
            txtGhiChu.Clear();
            ImgHinhAnh.Image = DefaultImage;
            DuongDanFile = "";//reset lai duong dan file
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            if(dt.KTQuyenAdmin()==false)//khong phai admin
            {
                //ẩn chuc năng
                btn_clear.Hide(); 
                btn_sua.Hide();
                btn_xoa.Hide();
                btnLuu.Hide();
                btn_Browse.Hide();
                btnThem.Hide();
            }
            //load hang
            dataGridViewSanPham.DataSource = dt.LoadDataHang();
            //vo hieu hóa button
            btn_clear.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btnLuu.Enabled = false;
            //load combobox chat lieu
            cbbmachatlieu.DataSource = dt.loadcbbchatlieu();
            cbbmachatlieu.DisplayMember = "TenChatLieu"; //hien thi
            cbbmachatlieu.ValueMember = "MaChatLieu";//gia tri
        }
        //mo file anh
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            //mở cửa sổ chọn ảnh
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg"; //chọn các file có duôi là png và jpg
            if (ofd.ShowDialog() == DialogResult.OK)//nếu chọn oke
            {
                DuongDanFile = ofd.FileName;//đường dẫn ảnh bằng đường dẫn đã chọn
                ImgHinhAnh.Image = new Bitmap(DuongDanFile);// ảnh mặc định dc thay bằng đường dẫn ảnh dòng trên
            }
            //btn co hiệu lực
            btn_clear.Enabled = true;
        }
        //btn clear
        private void button1_Click(object sender, EventArgs e)
        {
            txt_mahang.Focus();
            btn_clear.Enabled = false;//vo hieu luc
            Clear();//reset
        }
        
        private void txt_mahang_TextChanged(object sender, EventArgs e)
        {
            if (dt.ktClear(txt_mahang.Text) == false)//đã nhập
            {
                //btn co hiệu lực
                btn_clear.Enabled = true;
            }
        }

        private void txt_tenHang_TextChanged(object sender, EventArgs e)
        {
            if (dt.ktClear(txt_tenHang.Text) == false)//đã nhập
            {
                //btn co hiệu lực
                btn_clear.Enabled = true;
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            if (dt.ktClear(txt_soluong.Text) == false)//đã nhập
            {
                //btn co hiệu lực
                btn_clear.Enabled = true;
            }
        }

        private void txt_donGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (dt.ktClear(txt_donGiaNhap.Text) == false)//đã nhập
            {
                //btn co hiệu lực
                btn_clear.Enabled = true;
            }
        }

        private void txt_donGiaban_TextChanged(object sender, EventArgs e)
        {
            if (dt.ktClear(txt_donGiaban.Text) == false)//đã nhập
            {
                //btn co hiệu lực
                btn_clear.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            //vô hiệu hóa btn
            btn_sua.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
            txt_mahang.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //vô hiệu hóa btn
            btnThem.Enabled = btn_xoa.Enabled = false;
            //btn có hiệu lực
            btnLuu.Enabled = true;
            txt_tenHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thêm sản phẩm
            if (btnThem.Enabled == true)//btn them co hieu luc
            {
                if (dt.KTRong(txt_mahang.Text, txt_tenHang.Text, txt_soluong.Text, txt_donGiaNhap.Text,txt_donGiaban.Text,txtGhiChu.Text) == false)// rỗng
                {
                    return;
                }
                if (dt.ktkhoaC(txt_mahang.Text)==false)//trung khoa chinh
                {
                    MessageBox.Show("Mã hàng đã tồn tại", "Thông Báo");
                    return;
                }
                if (DuongDanFile == "")
                {
                    MessageBox.Show("Bạn Chưa chọn Ảnh", "Thông Báo");
                    return;
                }
                else
                {
                    Image temp = new Bitmap(DuongDanFile);// ánh xạ đường dẫn ảnh
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);//Lưu ảnh
                    ImageByteArray = strm.ToArray();// mã hóa ảnh thành mãng băm
                }
                if (dt.them(txt_mahang.Text,txt_tenHang.Text,cbbmachatlieu.SelectedValue.ToString(), int.Parse(txt_soluong.Text) , int.Parse(txt_donGiaNhap.Text) , int.Parse(txt_donGiaban.Text),txtGhiChu.Text,ImageByteArray))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                    return;
                }
            }
            //Sửa sản phẩm
            if (btn_sua.Enabled == true)//btn Sửa co hieu luc
            {
                if (dt.KTRong(txt_mahang.Text, txt_tenHang.Text, txt_soluong.Text, txt_donGiaNhap.Text, txt_donGiaban.Text, txtGhiChu.Text) == false)// rỗng
                {
                    return;
                }
                //kt khóa chính
                if (dt.ktkhoaC(txt_mahang.Text) == true)//không tồn tại khóa chnh
                {
                    MessageBox.Show("Mã hàng Không  tồn tại", "Thông Báo");
                    return;
                }
                if(DuongDanFile=="")
                {
                    MessageBox.Show("Bạn Chưa chọn Ảnh", "Thông Báo");
                    return;
                }
                else
                {
                    Image temp = new Bitmap(DuongDanFile);// ánh xạ đường dẫn ảnh
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);//Lưu ảnh
                    ImageByteArray = strm.ToArray();// mã hóa ảnh thành mãng băm
                }
                if (dt.Sua(txt_mahang.Text, txt_tenHang.Text, cbbmachatlieu.SelectedValue.ToString(), int.Parse(txt_soluong.Text), int.Parse(txt_donGiaNhap.Text), int.Parse(txt_donGiaban.Text), txtGhiChu.Text, ImageByteArray))
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
            btnLuu.Enabled=btn_clear.Enabled = false;
            //btn có hiệu lực
            btn_sua.Enabled = btn_xoa.Enabled = btnThem.Enabled = true;
            Clear();
        }

        private void dataGridViewSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.CurrentRow != null)
            {
                btnLuu.Enabled = false;
                //btn có hiệu lực
                btn_sua.Enabled = btn_xoa.Enabled = true;
                //hien thi
                txt_mahang.Text = dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString();
                txt_tenHang.Text = dataGridViewSanPham.CurrentRow.Cells[1].Value.ToString();
                cbbmachatlieu.SelectedValue = dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString();
                txt_soluong.Text = dataGridViewSanPham.CurrentRow.Cells[3].Value.ToString();
                txt_donGiaNhap.Text = dataGridViewSanPham.CurrentRow.Cells[4].Value.ToString();
                txt_donGiaban.Text = dataGridViewSanPham.CurrentRow.Cells[5].Value.ToString();
                txtGhiChu.Text = dataGridViewSanPham.CurrentRow.Cells[6].Value.ToString();
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (txt_mahang.Text.Length == 0)//rong
                {
                    MessageBox.Show("mã hàng  không được để trống", "Thông Báo");
                    return;
                }
                //kt khóa chính
                if (dt.ktkhoaC(txt_mahang.Text) == true)//không tồn tại khóa chinh
                {
                    MessageBox.Show("Mã hàng Không  tồn tại", "Thông Báo");
                    return;
                }
                //kt khóa ngoại
                if (dt.ktkhoaNgoai(txt_mahang.Text) == false)//có khóa ngoại
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng hãy kiểm tra mã hàng Bảng chi tiết hóa đơn", "Thông Báo");
                    return;
                }
                if (dt.Xoa(txt_mahang.Text))
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            //tim
            dataGridViewSanPham.DataSource = dt.Timhang(txt_Tim.Text);
        }

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //load hang
            dataGridViewSanPham.DataSource = dt.LoadDataHang();
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
