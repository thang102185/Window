using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tablechongoi_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TaoChoNgoi()
        {
            int rows = 10;
            int cols = 10;
            tablechongoi.RowCount = rows;
            tablechongoi.ColumnCount = cols;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button seatbutton = new Button
                    {
                        BackColor = Color.Gray,
                        Text = $"{(char)('A' + i)}{j + 1}",
                        Dock = DockStyle.Fill,
                        Tag = new { Row = i, Col = j }
                    };
                    seatbutton.Click += SeatButton_Click;
                    tablechongoi.Controls.Add(seatbutton, i, j);
                }
            }
        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null && btn.BackColor == Color.Gray)
            {
                using(Form f2 = new Form2())
                {
                    if(f2.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.Orange;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ghế đã được đặt", "Thông báo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoChoNgoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control control in tablechongoi.Controls)
            {
                if (control is Button seatButton)
                {
                    seatButton.BackColor = Color.Gray;
                }
            }
        }
    }
}
