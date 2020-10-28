using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3
{
    class Phanso
    {
        private int ts, ms;
        public Phanso()
        {
            ts = 0; ms = 1;
        }
        public Phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public void Nhap()
        {
            Console.Write("Nhap ts=");
            ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap ms=");
            ms = int.Parse(Console.ReadLine());

        }
        public Phanso Tong(Phanso t2)
        {
            Phanso t = new Phanso();
            t.ts = this.ts * t2.ms + t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public Phanso Tongpsvoi1s(int a)
        {
            Phanso t = new Phanso();
            t.ts = this.ts + this.ms * a;
            t.ms = this.ms;
            return t;
        }
        public Phanso Hieu(Phanso t2)
        {
            Phanso t = new Phanso();
            t.ts = this.ts * t2.ms - t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public Phanso THieupsvoi1s(int a)
        {
            Phanso t = new Phanso();
            t.ts = this.ts - this.ms * a;
            t.ms = this.ms;
            return t;
        }
        public void Hien()
        {
            Console.WriteLine("={0}/{1}", ts, ms);
        }

    }
    class App1
    {
        static void Main2()
        {
            Phanso t1 = new Phanso();
            Phanso t2 = new Phanso();
            Console.WriteLine("Nhap phan so thu 1");
            t1.Nhap();
            Console.WriteLine("Nhap phan so thu 1"); t2.Nhap();
            Console.Write("Tong hai phan so");
            Phanso t3 = t1.Tong(t2);
            t3.Hien();
            Console.Write("Tong phan so voi 1 so ");
            Phanso t4 = t1.Tongpsvoi1s(6);
            t4.Hien();
            Console.Write("Hieu hai phan so");
            Phanso t5 = t1.Hieu(t2);
            t5.Hien();
            Console.Write("Hieu phan so voi 1 so la");
            Phanso t6 = t1.THieupsvoi1s(8);
            t6.Hien();
            Console.ReadKey();
        }
    }
}
