using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Nhanvien
    {
        private string Hten, QQ;
        private double hsl;
        private static int luongcb = 3000;
        public static int Luongcb
        {
            get
            {
                return luongcb;
            }
            set
            {
                if (value > 3000) luongcb = value;
            }
        }
        public string hten
        {
            get
            {
                int n = Hten.LastIndexOf(" ");
                return Hten.Substring(n + 1) + " " + Hten.Substring(0, n);
            }
        }
        public double Hsl
        {
            get
            {
                return hsl;
            }
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten: "); Hten = Console.ReadLine();
            Console.Write("Nhap que quan: "); QQ = Console.ReadLine();
            Console.Write("Nhap he so luong: "); hsl = double.Parse(Console.ReadLine());

        }
        public double Luong
        {
            get
            {
                return hsl * luongcb;
            }
        }
        public void Hien()

        {
            Console.WriteLine("Ho ten\tque quan\tHe so luong\tLuong");
            Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", Hten, QQ, hsl, Luong);
        }


    }
    class QLNV
    {
        private int sonv;
        private Nhanvien[] ds;
        public void Nhap()
        {
            Console.Write("Nhap n= "); sonv = int.Parse(Console.ReadLine());
            ds = new Nhanvien[sonv];
            for (int i = 0; i < sonv; i++)
            {
                Console.WriteLine("Nhap nhan vien thu {0}:", i + 1);
                ds[i] = new Nhanvien();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            for (int i = 0; i < sonv; i++)
                ds[i].Hien();
        }
        public double Maxhsl()
        {
            double max = ds[0].Hsl;
            for (int i = 0; i < sonv; i++)
                if (ds[i].Hsl > max) max = ds[i].Hsl;
            return max;
        }
        public void HienMaxhsl()
        {
            double max = Maxhsl();
            for (int i = 0; i < sonv; i++)
                if (ds[i].Hsl == max) ds[i].Hien();
        }
        public void Sapxep()
        {
            for (int i = 0; i < sonv - 1; i++)
                for (int j = i + 1; j < sonv; j++)
                    if (string.Compare(ds[i].hten, ds[i].hten) > 0)
                    {
                        Nhanvien t = ds[i];
                        ds[i] = ds[j];
                        ds[j] = t;
                    }
        }
    }
    class App6
    {
        static void Main7()
        {
            QLNV t = new QLNV();
            t.Nhap();
            Console.WriteLine("Nhan vien co hsl max la");
            t.HienMaxhsl();
            Console.WriteLine("Nhan vien sau khi sap xep:");
            t.Sapxep();
            t.Hien();
            Console.ReadKey();
        }
    }
}