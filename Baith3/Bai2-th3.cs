using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Units
    {

        public static double Tinh(int x)
        {
            return Math.Pow(x, (float)1 / 3);

        }
        public static int C(int k, int n)
        {
            if (k == 0 || k == n) return 1;
            if (k == 1) return n;
            return C(k - 1, n - 1) + C(k, n - 1);
        }
        public static int giaithua(int n)
        {
            if (n == 0) return 1;
            else return n * giaithua(n - 1);
        }
        public static int A(int k, int n)
        {
            if (n == k) return giaithua(n);
            if (k == 0) return 1;
            return n * A(k - 1, n - 1);
        }

    }
    class App2
    {
        static void Main3()
        {
            Units t = new Units();
            Console.WriteLine("Gia tri bieu thuc={0}", Units.Tinh(8));
            Console.WriteLine("Gia tri bieu thuc C(6,9)={0}", Units.C(6, 9));
            Console.WriteLine("Gia tri bieu thuc A={0}", Units.A(2, 6));
            Console.ReadKey();
        }

    }
}
