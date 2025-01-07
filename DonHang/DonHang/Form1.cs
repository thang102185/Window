using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonHang
{
    public partial class Form1 : Form
    {
        public class Product
        {
            public string ID { get; set; }
            public string description { get; set; }
            public int Quan { get; set; }
            public Product(string des, int quan)
            {
                description = des;
                Quan = quan;
                string id = "";
                if (description == "Hard Disk")
                {
                    id = "HD1-Hard Disk";
                }
                else if (description == "Monitor")
                {
                    id = "MF1-Monitor";
                }
                else if (description == "Key Board")
                {
                    id = "KB1-Key Board";
                }
                ID = id;
            }
        }
        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbName.SelectedItem == "Hard Disk")
            {
                txtPrice.Text = "800";
            }
            else if (cmbName.SelectedItem == "Monitor")
            {
                txtPrice.Text = "700";
            }
            else if(cmbName.SelectedItem == "Key Board")
            {
                txtPrice.Text = "600";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soluong;
            if(int.TryParse(txtQuantity.Text, out soluong) == false)
            {
                MessageBox.Show("Nhập 1 số");
            }
            else
            {
                int gia = int.Parse(txtPrice.Text);
                txtTotal.Text = (gia * soluong).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int soluong;
            if (string.IsNullOrWhiteSpace(txtON.Text)) errorProvider1.SetError(txtON, "Không được để trống");
            if (string.IsNullOrWhiteSpace(txtCN.Text)) errorProvider1.SetError(txtCN, "Không được để trống");
            if (string.IsNullOrWhiteSpace(txtQuantity.Text)) errorProvider1.SetError(txtQuantity, "Không được để trống");

            if (int.TryParse(txtQuantity.Text, out soluong))
            {
                var product = new Product(cmbName.SelectedItem.ToString(), soluong);
                products.Add(product);
                var f2 = new Form2(products);
                f2.ShowDialog();
            }
            else
            {
                errorProvider1.SetError(txtQuantity, "viết 1 số");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbName.SelectedIndex = 0;
        }
    }
}
