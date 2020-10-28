using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Phantu
    {
        private double heso;
        private int mu;
        public Phantu()
        {
            heso = mu = 0;
        }
        public Phantu(int mu, double heso)
        {
            this.mu = mu;
            this.heso = heso;
        }
        public void Nhap()
        {
            Console.Write("Nhap he so="); heso = double.Parse(Console.ReadLine());
            Console.Write("Nhap mu="); mu = int.Parse(Console.ReadLine());

        }
        public void Hien()
        {
            Console.Write("{0}*x^{1}+", heso, mu);

        }
        public double Tinh(int x)
        {
            return heso * Math.Pow(x, mu);
        }
    }
    class Dathuc
    {
        private int n;
        private Phantu[] p;
        public void Nhap()
        {
            Console.Write("Nhap n="); n = int.Parse(Console.ReadLine());
            p = new Phantu[n];
            for (int i = 0; i < n; i++)
            {
                p[i] = new Phantu();
                p[i].Nhap();
            }
        }
        public void Hien()
        {
            for (int i = 0; i < n; i++)
                p[i].Hien();
            Console.WriteLine();
        }
        public double Tinh(int x)
        {
            double t = 0;
            for (int i = 0; i < n; i++)
            {
                t += p[i].Tinh(x);
            }
            return t;
        }
    }

    class App8
    {
        static void Main9()
        {
            Dathuc t = new Dathuc();
            t.Nhap(); t.Hien();
            Console.WriteLine("Tong p(x)={0}", t.Tinh(4));
            Console.ReadKey();
        }
    }
}