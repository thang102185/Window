using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            ClassDe3 c = new ClassDe3
            {
                HoTen = txtTen.Text,
                NgaySinh = DateTime.ParseExact(txtNgaysinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                GioTinh = txtGioiTinh.Text,
                DiemToan = double.Parse(txtDT.Text),
                DiemLy = double.Parse(txtDL.Text),
                DiemHoa = double.Parse(txtDH.Text)
            };
            txtXL.Text = c.xepLoai();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            ClassDe3 c = new ClassDe3
            {
                HoTen = txtTen.Text,
                NgaySinh = DateTime.ParseExact(txtNgaysinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                GioTinh = txtGioiTinh.Text,
                DiemToan = double.Parse(txtDT.Text),
                DiemLy = double.Parse(txtDL.Text),
                DiemHoa = double.Parse(txtDH.Text)
            };
            txtDTB.Text = string.Format("{0:0.00}", c.diemTB());
        }
    }
}
