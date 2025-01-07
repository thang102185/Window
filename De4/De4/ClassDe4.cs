using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De4
{
    internal class ClassDe4
    {
        public string chuanHoaChuoi(string s)
        {
            string r = s.Trim();
            while (r.Contains("  "))
            {
                r = r.Replace("  ", " ");
            }
            return r;
        }
        public string hoaDauTu(string s)
        {
            string r = chuanHoaChuoi(s);
            string kq = "";
            string[] tu = r.Split(' ');
            foreach (string str in tu)
            {
                string str1 = str[0].ToString();
                kq += str1.ToUpper();
                kq += str.Substring(1, str.Length-1);
                kq += " ";
            }
            return kq.Trim();
        }
    }
}
