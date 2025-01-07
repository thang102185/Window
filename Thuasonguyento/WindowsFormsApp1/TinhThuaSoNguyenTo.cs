using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class TinhThuaSoNguyenTo
    {
        public List<int> TSNT(int n)
        {
            List<int> tsnt = new List<int>();
            int i = 2;
            while (n > 1)
            {
                while (n % i == 0)
                {
                    tsnt.Add(i);
                    n /= i;
                }

                i++;
            }
            return tsnt;
        }
    }
}
