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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (lstDS.Items.Contains(lstDV.SelectedItem))
            {
                errorProvider1.SetError(lstDV, "Dịch vụ đã được chọn");
            }
            else
            {
                lstDS.Items.Add(lstDV.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lstDS.Items.Count > 0)
            {
                lstDS.Items.Remove(lstDS.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtTen.Text == "") {
                errorProvider1.SetError(txtTen, "Không để trống tên");
                check = false;
            }
            if (txtNgay.Text == "") {
                errorProvider1.SetError(txtNgay, "Không để trống ngày");
                check = false;
            }
            if (txtThang.Text == "")
            {
                errorProvider1.SetError(txtThang, "Không để trống tháng");
                check = false;
            }
            if (txtNam.Text == "")
            {
                errorProvider1.SetError(txtNam, "Không để trống năm");
                check = false;
            }
            if (lstDS.Items.Count == 0)
            {
                errorProvider1.SetError(lstDS, "Phải chọn ít nhất 1 dịch vụ");
                check = false;
            }
            if (check)
            {
                lstXacNhan.Items.Add(txtTen.Text);
                lstXacNhan.Items.Add("Ngày sinh: " + txtNgay.Text + "/" + txtThang.Text + "/" + txtNam.Text);
                string s = "";
                foreach(string i in lstDS.Items)
                {
                    s += i + ", ";
                }

                string v = s.Substring(0, s.LastIndexOf(", "));
                lstXacNhan.Items.Add("Dịch vụ đã chọn: " + v);
            }
        }
    }
}
