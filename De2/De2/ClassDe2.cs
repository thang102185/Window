using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De2
{
    internal class ClassDe2
    {
        public int UCLN(int a, int b)
        {
            while (a * b != 0)
            {
                if (a >= b) a = a % b;
                else b = b % a;
            }
            return a + b;
        }
        public int BCNN(int a, int b)
        {
            return (a*b)/UCLN(a, b);
        }
    }
}
