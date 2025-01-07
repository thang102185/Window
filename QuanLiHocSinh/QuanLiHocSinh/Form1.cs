using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    public partial class Form1 : Form
    {
        public class Student
        {
            public string Name { get; set; }
            public string MHS { get; set; }
            public string Class { get; set; }
            public DateTime DOB { get; set; }
            public string Gender { get; set; }
            public string diachi { get; set; }
            public string sdt { get; set; }
            public Student(string name, string mHS, string nclass, DateTime dOB, string gender, string diachi, string sdt)
            {
                Name = name;
                MHS = mHS;
                Class = nclass;
                DOB = dOB;
                Gender = gender;
                this.diachi = diachi;
                this.sdt = sdt;
            }
            public override string ToString()
            {
                return $"{Name}-{MHS}-{Gender}";
            }
        }
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.StudentAdded += (student) =>
            {
                students.Add(student);
                UpdateListView();
            };
            f2.ShowDialog();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i <students.Count; i++)
            {
                var student = students[i];
                var item = new ListViewItem(student.Name);
                item.SubItems.Add(student.MHS);
                item.SubItems.Add(student.Class);
                item.SubItems.Add(student.DOB.ToString("dd/MM/yyyy"));
                item.SubItems.Add(student.Gender);
                item.SubItems.Add(student.diachi);
                item.SubItems.Add(student.sdt);
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedIndices[0];
                var selectedStudent = students[i];
                var f3 = new Form3(selectedStudent);
                f3.StudentEdited += (editedstudent) =>
                {
                    students[i] = editedstudent;
                    UpdateListView();
                };
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn học sinh cần sửa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedIndices[0];
                var selectedStudent = students[i];
                students.Remove(selectedStudent);
                UpdateListView();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chọn học sinh cần xóa");
            }
        }
    }
}
