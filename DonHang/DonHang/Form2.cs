using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DonHang.Form1;
using DonHang;

namespace DonHang
{
    public partial class Form2 : Form
    {
        private List<Product> _products;
        public Form2(List<Product> products)
        {
            InitializeComponent();
            _products = products;
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < _products.Count; i++)
            {
                var product = _products[i];
                var item = new ListViewItem(product.ID);
                item.SubItems.Add(product.description);
                item.SubItems.Add(product.Quan.ToString());
                listView1.Items.Add(item);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Close();
        }
    }
}
