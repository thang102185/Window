using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De4
{
    public partial class Form3 : Form
    {
        DateTime batdau1;
        DateTime batdau2;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBD1_Click(object sender, EventArgs e)
        {
            batdau1 = DateTime.Now;
            txtBD1.Text = batdau1.ToString("hh:mm:ss tt");
            btnBD1.Enabled = false;
            btnKT1.Enabled = true;
        }

        private void btnBD2_Click(object sender, EventArgs e)
        {
            batdau2 = DateTime.Now;
            txtBD2.Text = batdau2.ToString("hh:mm:ss tt");
            btnBD2.Enabled = false;
            btnKT2.Enabled = true;
        }

        private void btnKT1_Click(object sender, EventArgs e)
        {
            DateTime ketthuc1 = DateTime.Now;
            txtKT1.Text = ketthuc1.ToString("hh:mm:ss tt");
            btnBD1.Enabled = true;
            btnKT1.Enabled = false;

            DateTime bd = new DateTime(batdau1.Year, batdau1.Month, batdau1.Day, batdau1.Hour, batdau1.Minute, batdau1.Second);
            DateTime kt = new DateTime(ketthuc1.Year, ketthuc1.Month, ketthuc1.Day, ketthuc1.Hour, ketthuc1.Minute, ketthuc1.Second); 
            TimeSpan tg1 = kt - bd;
            double gio1 = tg1.TotalHours;
            double tien1 = gio1 * 3000;
            MessageBox.Show($"Tiền thuê máy 1 {tien1}");
        }

        private void btnKT2_Click(object sender, EventArgs e)
        {
            DateTime ketthuc2 = DateTime.Now;
            txtKT2.Text = ketthuc2.ToString("hh:mm:ss tt");
            btnBD2.Enabled = true;
            btnKT2.Enabled = false;

            DateTime bd = new DateTime(batdau2.Year, batdau2.Month, batdau2.Day, batdau2.Hour, batdau2.Minute, batdau2.Second);
            DateTime kt = new DateTime(ketthuc2.Year, ketthuc2.Month, ketthuc2.Day, ketthuc2.Hour, ketthuc2.Minute, ketthuc2.Second);
            TimeSpan tg2 = kt - bd;
            double gio2 = tg2.TotalHours;
            double tien2 = gio2 * 3000;
            MessageBox.Show($"Tiền thuê máy 2 {tien2}");
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            if(btnKT1.Enabled == false && btnKT2.Enabled == false)
            {
                Close();
            }
            else
            {
                if (btnKT1.Enabled)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn dừng máy số 1 không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        btnKT1_Click(sender, e);
                    }
                }
                if (btnKT2.Enabled)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn dừng máy số 2 không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        btnKT2_Click(sender, e);
                    }
                }
                if (btnKT1.Enabled == false && btnKT2.Enabled == false)
                {
                    Close();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnKT1.Enabled = false;
            btnKT2.Enabled = false;
        }
    }
}
