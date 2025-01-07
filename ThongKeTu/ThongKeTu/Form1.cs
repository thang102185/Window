using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongKeTu
{
    public partial class Form1 : Form
    {
        private Tansuattu analyzer;
        public class Tansuattu
        {
            public Dictionary<string, int> Demtansuat(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("Input không được trống");
                }
                char[] loaibodau = new char[] { ' ', '.', ',', ':', '!', '?', '\n', '\t' };
                string[] tu = input.ToLower().Split(loaibodau, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> tansuat = new Dictionary<string, int>();
                foreach(string s1 in tu)
                {
                    if (tansuat.ContainsKey(s1))
                    {
                        tansuat[s1]++;
                    }
                    else
                    {
                        tansuat[s1] = 1;
                    }
                }
                return tansuat;
            }
        }
        public Form1()
        {
            InitializeComponent();
            analyzer = new Tansuattu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string inputtext = txtNhap.Text.Trim();
                if (string.IsNullOrWhiteSpace(inputtext))
                {
                    MessageBox.Show("Nhập văn bản vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dictionary<string, int>tansuat = analyzer.Demtansuat(inputtext);
                listView1.Items.Clear();
                foreach(var tu in tansuat)
                {
                    var i = new ListViewItem(tu.Key);
                    i.SubItems.Add(tu.Value.ToString());
                    listView1.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNhap.ResetText();
            listView1.Items.Clear();
        }
    }
}
