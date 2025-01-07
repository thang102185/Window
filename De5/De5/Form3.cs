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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtNhapn, "Nhập một số bất kỳ");
        }

        public void TB()
        {
            MessageBox.Show("Mời bạn nhập n", "Thông báo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            if(int.TryParse(txtNhapn.Text, out n))
            {
                txtKQ.Text = Convert.ToString(n, 2);
            }
            else
            {
                TB();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhapn.Text, out n))
            {
                txtKQ.Text = Convert.ToString(n, 8);
            }
            else
            {
                TB();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhapn.Text, out n))
            {
                txtKQ.Text = n.ToString();
            }
            else
            {
                TB();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhapn.Text, out n))
            {
                txtKQ.Text = Convert.ToString(n, 16).ToUpper();
            }
            else
            {
                TB();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNhapn.ResetText();
            txtKQ.ResetText();
        }
    }
}
