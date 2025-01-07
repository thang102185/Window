using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLiHocSinh.Form1;
using QuanLiHocSinh;

namespace QuanLiHocSinh
{
    public partial class Form2 : Form
    {
        public event Action<Student> StudentAdded;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = radNam.Checked ? "Nam" : "Nữ";
            var student = new Student(txtname.Text,
                txtmahs.Text,
                cmblop.SelectedItem.ToString(),
                dtpngaysinh.Value,
                gender,
                txtdiachi.Text,
                txtsdt.Text
                );
            StudentAdded?.Invoke(student);
            MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmblop.SelectedIndex = 0;
        }
    }
}
