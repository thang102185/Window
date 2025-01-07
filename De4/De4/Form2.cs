using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTen.ResetText();
            txtSoLuong.ResetText();
            txtGia.ResetText();
            chkKhachQuen.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ClassDe4 c = new ClassDe4();
            bool check = true;
            if(txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Không để trống tên");
                check = false;
            }

            int soluong= 0;
            if (int.TryParse(txtSoLuong.Text, out soluong) == false || soluong < 0)
            {
                errorProvider1.SetError(txtSoLuong, "Nhập số nguyên lớn hơn 0");
                check = false;
            }

            int gia = 0;
            if (int.TryParse(txtGia.Text, out gia) == false || gia < 0)
            {
                errorProvider1.SetError(txtGia, "Nhập số lớn hơn 0");
                check = false;
            }

            if (check)
            {
                string ten = c.hoaDauTu(txtTen.Text);
                double thanhtien = 0;
                if (chkKhachQuen.Checked == false)
                {
                    thanhtien = gia * soluong;
                }
                else
                {
                    thanhtien = (gia * soluong) - ((gia * soluong) * 0.05);
                }
                ListViewItem item1 = new ListViewItem(ten);
                item1.SubItems.Add(thanhtien.ToString());
                lvDS.Items.Add(item1);
            }
        }
    }
}
