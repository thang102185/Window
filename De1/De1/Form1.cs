using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            ClassDe1 c = new ClassDe1();
            string hoten = txtNhap.Text;
            txtKQ.Text = c.chuanHoaChuoi(hoten);
            txtSoLuong.Text = (c.dem(hoten)).ToString();
            string[] str = c.tach(hoten);
            foreach(string str2 in str)
            {
                lstDanhSach.Items.Add(str2);
            }
        }
    }
}
