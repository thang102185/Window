using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapa_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            TinhThuaSoNguyenTo c = new TinhThuaSoNguyenTo();
            int a;
            if (int.TryParse(txtNhapa.Text, out a) == false)
            {
                errorProvider1.SetError(txtNhapa, "Nhập 1 số");
                return;
            }
            List<int> kq = new List<int>();
            kq = c.TSNT(a);
            txtKQ.Text = string.Join("*", kq);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNhapa.ResetText();
            errorProvider1.Clear();
            txtKQ.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Close();
        }
    }
}
