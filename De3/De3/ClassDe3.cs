using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De3
{
    internal class ClassDe3
    {
        public string HoTen {  get; set; }
        public DateTime NgaySinh {  get; set; }
        public string GioTinh {  get; set; }
        public double DiemToan {  get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public double diemTB()
        {
            return (DiemToan + DiemLy + DiemHoa) / 3;
        }
        public string xepLoai()
        {
            double tb = diemTB();
            if (tb >= 8)
            {
                return "Giỏi";
            }
            else if (tb >= 6.5)
            {
                return "Khá";
            }
            else if (tb >= 5)
            {
                return "Trung bình";
            }
            else 
                return "Yếu";
        }
    }
}
