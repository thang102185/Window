using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtMa.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string email = "";
            // tên
            string s = txtHoTen.Text.Trim();
            string[] tu = s.Split(' ');
            string ten = tu[tu.Length - 1].ToLower();
            // họ
            string ho = tu[0].ToLower();
            //mã
            ten = XoaDauTiengViet(ten);
            ho = XoaDauTiengViet(ho);
            email += ten + ho + txtMa.Text;
            //giới tính
            if(radNam.Checked)
            {
                email += "1";
            }
            if(radNu.Checked)
            {
                email += "0";
            }
            email += "@st.vimaru.edu.vn";
            txtKQ.Text = email;
        }
        public static string XoaDauTiengViet(string input)
        {
            string[] tiengViet = new string[] {
                "aAeEoOuUiIdDyY",
                "áàạảãâấầậẩẫăắằặẳẵ",
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ",
                "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ",
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ",
                "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ",
                "ÍÌỊỈĨ",
                "đ",
                "Đ",
                "ýỳỵỷỹ",
                "ÝỲỴỶỸ"
            };

            for (int i = 1; i < tiengViet.Length; i++)
            {
                for (int j = 0; j < tiengViet[i].Length; j++)
                {
                    input = input.Replace(tiengViet[i][j], tiengViet[0][i - 1]);
                }
            }
            return input;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.ResetText();
            txtMa.ResetText();
            txtKQ.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
