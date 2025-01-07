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
    public partial class Form2 : Form
    {
        private Songuyento analyzer = new Songuyento();
        public class Songuyento 
        {
            public bool kiemtrasnt(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n%i==0) return false;
                }
                return true;
            }
            public List<int> TimSNTlist (string input)
            {
                List<int> songuyento = new List<int>();
                string[] numbers = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach(string number in numbers)
                {
                    if(int.TryParse(number, out int n) && kiemtrasnt(n))
                    {
                        songuyento.Add(n);
                    }
                }
                return songuyento;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            List<int> so = analyzer.TimSNTlist(input);
            txtKQ.Text = string.Join("; ", so);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtInput, "Nhập các số n bất kỳ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.ResetText();
            txtKQ.ResetText();
        }
    }
}
