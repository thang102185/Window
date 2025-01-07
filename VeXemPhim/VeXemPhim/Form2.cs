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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Updatetinhtien()
        {
            int gia = 0;
            if (radThuong.Checked) gia = 70000;
            else if (radVip.Checked) gia = 90000;
            else if (radSvip.Checked) gia = 120000;
            if (chkBongnuoc.Checked) gia += 150000;
            txtTien.Text = gia.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtHoTen.Text;
            string id = txtID.Text;
            string diachi = txtDiaChi.Text;
            string phim = cmbPhim.SelectedItem?.ToString();
            string loaive = "";
            string combo = chkBongnuoc.Checked ? "Có" : "Không";
            if (radThuong.Checked) loaive = "Vé thường";
            else if (radVip.Checked) loaive = "Vé vip";
            else if (radSvip.Checked) loaive = "Vé svip";

            int gia = 0;
            if (radThuong.Checked) gia = 70000;
            else if (radVip.Checked) gia = 90000;
            else if (radSvip.Checked) gia = 120000;
            if (chkBongnuoc.Checked) gia += 150000;

            string thongtin = $"Thông tin vé: \n" +
                $"Họ tên: {name}\n" +
                $"ID: {id}\n" +
                $"Địa chỉ: {diachi}\n" +
                $"Phim: {phim}\n" +
                $"Loại vé: {loaive}\n" +
                $"Combo bỏng nước: {combo}\n" +
                $"Thành tiền: {gia: 0} VND";
            MessageBox.Show(thongtin, "Thông tin vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void radThuong_CheckedChanged(object sender, EventArgs e)
        {
            Updatetinhtien();
        }

        private void radVip_CheckedChanged(object sender, EventArgs e)
        {
            Updatetinhtien();
        }

        private void radSvip_CheckedChanged(object sender, EventArgs e)
        {
            Updatetinhtien();
        }

        private void chkBongnuoc_CheckedChanged(object sender, EventArgs e)
        {
            Updatetinhtien();
        }
    }
}
