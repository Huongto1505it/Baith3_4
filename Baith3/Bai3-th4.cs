using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Person
    {
        private string Hoten;
        private int namsinh;
        private int[] dthi;
        public void Nhap()
        {
            Console.Write("Nhap ho ten:"); Hoten = Console.ReadLine();

            Console.Write("Nam sinh: "); namsinh = int.Parse(Console.ReadLine());
            dthi = new int[9];

            for (int i = 0; i < 9; i++)
            {
                Console.Write("Nhap dthi thu {0}=", i + 1); dthi[i] = int.Parse(Console.ReadLine());
            }
        }
        public int Ktr()
        {
            if (Ktra() == false)
            {
                if (Dtb() > 7)
                {
                    return 1;
                }
                else return -1;
            }
            else return 0;

        }

        public bool Ktra()
        {
            for (int i = 0; i < 9; i++)

                if (dthi[i] < 5)
                    return true;

            return false;
        }
        public int Dtb()
        {
            int t = 0;
            for (int i = 0; i < 9; i++)
            {
                t += dthi[i];

            }
            return t / 9;

        }
    }
    class QLP
    {
        private int n;
        private Person[] ds;
        public void Nhap()
        {
            Console.Write("Nhap so sinh vien:"); n = int.Parse(Console.ReadLine());
            ds = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                ds[i] = new Person();
                ds[i].Nhap();
            }
        }

        public int SOsvlamlv()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
                if (ds[i].Ktr() == 1)
                    a++;
            return a;

        }
        public int SOsvttn()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
                if (ds[i].Ktr() == -1)
                    a++;
            return a;

        }
        public int SOsvtl()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
                if (ds[i].Ktr() == 0)
                    a++;
            return a;

        }
    }
    class App7
    {
        static void Main8()
        {
            QLP t = new QLP();
            t.Nhap();
            Console.WriteLine("So sinh vien duoc lam luan van la:{0}", t.SOsvlamlv());
            Console.WriteLine("So sinh vien duoc thi tot nghiep la:{0}", t.SOsvttn());
            Console.WriteLine("So sinh vien thi lai la:{0}", t.SOsvtl());
            Console.ReadKey();
        }
    }
}