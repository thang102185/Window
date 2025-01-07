using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    internal class ClassDe1
    {
        public int dem(string s)
        {
            const char Space = ' ';
            string ht = chuanHoaChuoi(s);
            int cnt = ht.Split(Space).Length;
            return cnt;
        }
        public string chuanHoaChuoi(string s)
        {
            string ht = s.Trim();
            while (ht.Contains("  "))
            {
               ht = ht.Replace("  ", " ");
            }
            return ht;
        }
        public string[] tach(string s)
        {
            const char Space = ' ';
            string ht = chuanHoaChuoi(s);
            string[] result = ht.Split(Space);
            return result;
        }
    }
}
