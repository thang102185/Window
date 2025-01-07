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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtNhapn, "Nhập số chuỗi bất kỳ");
        }

        private void txtNhapn_TextChanged(object sender, EventArgs e)
        {
            string s = txtNhapn.Text;
            if (string.IsNullOrEmpty(s))
            {
                txtKQ.Text = "0";
            }
            else
            {
                string[] tu = s.Split(' ');
                txtKQ.Text = tu.Length.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = txtNhapn.Text.Trim();
            if (!string.IsNullOrEmpty(s))
            {
                string kq = "";
                string[] tu = s.Split(' ');
                foreach(string s1 in tu)
                {
                    string s2 = s1[0].ToString();
                    kq += s2.ToUpper();
                    kq += s1.Substring(1, s1.Length - 1);
                    kq += " ";
                }
                txtNhapn.Text = kq.Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNhapn.ResetText();
            txtKQ.ResetText();
        }
    }
}
