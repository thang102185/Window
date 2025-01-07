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
    public partial class Form3 : Form
    {
        private Student _student;
        public event Action<Student> StudentEdited;
        public Form3(Student student)
        {
            InitializeComponent();
            _student = student;
            LoadStudentData();
        }
        private void LoadStudentData()
        {
            if(_student != null)
            {
                txtname.Text = _student.Name;
                txtmahs.Text = _student.MHS;
                cmblop.SelectedItem = _student.Class;
                dtpngaysinh.Value = _student.DOB;
                if (_student.Gender == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                txtdiachi.Text = _student.diachi;
                txtsdt.Text = _student.sdt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _student.Name = txtname.Text;
            _student.MHS = txtmahs.Text;
            _student.Class = cmblop.SelectedItem.ToString();
            _student.DOB = dtpngaysinh.Value;
            _student.Gender = radNam.Checked ? "Nam" : "Nữ";
            StudentEdited?.Invoke(_student);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
