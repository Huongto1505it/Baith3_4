using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3
{
    class vecto
    {
        private int n;
        private int[] a;
        public vecto()
        {
            n = 2;
            a = new int[2];
        }
        public vecto(int n)
        {
            this.n = n;
            a = new int[n];
        }
        public vecto(vecto t2)
        {
            this.n = t2.n;
            this.a = new int[n];
            for (int i = 0; i < n; i++)
                this.a[i] = t2.a[i];
        }
        public vecto Tong(vecto t2)
        {
            vecto t = new vecto(this.n);
            for (int i = 0; i < n; i++)

                t.a[i] = this.a[i] + t2.a[i];

            return t;

        }
        public vecto Hieu(vecto t2)
        {
            vecto t = new vecto(this.n);
            for (int i = 0; i < n; i++)

                t.a[i] = this.a[i] - t2.a[i];

            return t;

        }
        public vecto Tich(vecto t2)
        {
            vecto t = new vecto(this.n);
            for (int i = 0; i < n; i++)

                t.a[i] = this.a[i] * t2.a[i];

            return t;


        }
        public void Nhap()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("gia tri vecto:");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Hien()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\t", a[i]);

            }
        }



    }
    class App4
    {
        static void Main5()
        {
            vecto t1 = new vecto(4);
            vecto t2 = new vecto(t1);
            Console.WriteLine("Vecto thu 1:");
            t1.Nhap(); Console.WriteLine("Vecto thu 2:"); t2.Nhap();
            Console.WriteLine("Tong 2 vecto la");
            vecto t3 = t1.Tong(t2);
            t3.Hien();
            Console.WriteLine("Hieu 2 vecto la");
            vecto t4 = t1.Hieu(t2);
            t4.Hien();
            Console.WriteLine("tich 2 vecto la");
            vecto t5 = t1.Tich(t2);
            t5.Hien();
            Console.ReadKey();
        }
    }
}
