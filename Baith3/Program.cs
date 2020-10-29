using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Nguoi
    {
        private string hoten;
        private int namsinh;
        private double chieucao,cannang;
        public Nguoi()
        {
            hoten = " ";
            namsinh =  0;
            chieucao = 0;
            cannang = 0;
        }
        public Nguoi(string hoten,int namsinh,double chieucao,double cannang)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.cannang = cannang;
            this.chieucao = chieucao;
        }
        public Nguoi(Nguoi t2)
        {
            this.hoten = t2.hoten;
            this.chieucao = t2.chieucao;
            this.cannang = t2.cannang;
            this.namsinh = t2.namsinh;
        }
        
        public int Trave()
        {
            double k = cannang / (chieucao * chieucao); ;
            if (k > 25) return 1;
            else if (k < 19) return -1;
            else return 0;
         }
        public override string ToString()

        {
            return this.hoten + " " +this.namsinh +this. chieucao + this.cannang;
        }
        public string Hoten
        {
            get
            {
                int n = hoten.LastIndexOf(" ");
                return hoten.Substring(n + 1) + " " +hoten.Substring(0, n);
            }
        }
        public double Chieucao
        {
            get
            {
                return chieucao;

            }
            set
            {
                if (value > 1.8 || value < 1.2) chieucao = value;
            }
        }
        public double Cannang
        {
            get
            {
                return cannang;
            }
            set
            {
                if (value > 35 && value < 150) value = cannang;
            }
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten:");hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh:"); namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu cao:");chieucao = double.Parse(Console.ReadLine());
            Console.Write("Nhap can nang:"); cannang = double.Parse(Console.ReadLine());
        }
        
        public Nguoi Cong(Nguoi t2)
        {
            Nguoi t = new Nguoi();
            t.cannang = this.cannang + t2.cannang;
            return t;
        }
        public Nguoi Tong(double f)
        {
            Nguoi t = new Nguoi();
            t.cannang = this.cannang + f;
            return t;
        } 
    }
    class QlP
    {
        private Nguoi[] ds;
        public void Nhap()
        {

            ds = new Nguoi[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nhap nguoi thu {0}", i + 1);
                ds[i] = new Nguoi();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            for (int i = 0; i < 5; i++)
                ds[i].ToString();
        }
        public void Hiends()
        {
            for (int i = 0; i < 5; i++)
                if (ds[i].Chieucao > 1.7 && ds[i].Cannang > 70)
                    ds[i].ToString();
        }
        public void Hiensk()
        {
            for (int i = 0; i < 5; i++)
                do
                {
                    if (ds[i].Trave() == -1)
                    {
                        ds[i].Cannang++;

                        ds[i].ToString();
                    }
                } while (ds[i].Trave() != 1);
        }
    }
    class App
    {
        static void Main()
        {
            QlP t = new QlP();
            t.Nhap();
            t.Hien();
            t.Hiends();
            t.Hiensk();
            Console.ReadKey();

        }
    }
}