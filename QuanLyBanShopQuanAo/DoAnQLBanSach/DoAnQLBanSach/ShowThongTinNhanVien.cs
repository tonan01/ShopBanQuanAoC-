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
    public partial class ShowThongTinNhanVien : Form
    {
        public ShowThongTinNhanVien()
        {
            InitializeComponent();
        }
        ThongTinNhanVien dt = new ThongTinNhanVien();
        private void ShowThongTinNhanVien_Load(object sender, EventArgs e)
        {
            //hien thi
            dataGridViewNhanVien.DataSource = dt.LoadShowNV();
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
