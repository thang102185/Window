using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txt1.ResetText();
            txt2.ResetText();
            txtUCLN.ResetText();
            txtBCNN.ResetText();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ClassDe2 c = new ClassDe2();
            int a;
            int b;
            if(int.TryParse(txt1.Text, out a) == false || int.TryParse(txt2.Text, out b) == false)
            {
                if (int.TryParse(txt1.Text, out a) == false)
                    errorProvider1.SetError(txt1, "Nhập 1 số nguyên");
                if (int.TryParse(txt2.Text, out a) == false)
                    errorProvider1.SetError(txt2, "Nhập 1 số nguyên");
            }
            else
            {
                if(a == 0 || b == 0)
                {
                    if (a == 0)
                        errorProvider1.SetError(txt1, "Nhập 1 số khác 0");
                    if (b == 0)
                        errorProvider1.SetError(txt2, "Nhập 1 số khác 0");
                }
                else
                {
                    txtUCLN.Text = c.UCLN(a, b).ToString();
                    txtBCNN.Text = c.BCNN(a, b).ToString();
                }
            }
            
        }
    }
}
