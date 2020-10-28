using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Hocsinh
    {
        private string ten;
        private double dtoan, dli, dhoa;
        public void Nhap()
        {
            Console.Write("Nhap ten hoc sinh:"); ten = Console.ReadLine();
            Console.Write("Nhap diem toan:"); dtoan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem li:"); dli = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa:"); dhoa = double.Parse(Console.ReadLine());
        }
        public double Dtoan
        {
            get
            {
                return dtoan;
            }
            set
            {
                if (value >= 0 && value <= 10) dtoan = value;
            }
        }
        public double Dli
        {
            get
            {
                return dli;
            }
            set
            {
                if (value >= 0 && value <= 10) dli = value;
            }
        }
        public double Dhoa
        {
            get
            {
                return dhoa;
            }
            set
            {
                if (value >= 0 && value <= 10) dhoa = value;
            }
        }
        public void Hien()
        {
            Console.WriteLine("Ho ten:{0}\tDiem toan:{1}\tDiem li:{2}\tDiem hoa:{3}", ten, dtoan, dli, dhoa);
        }

    }
    class QLHS
    {
        private Hocsinh[] ds;
        private int sohs;
        public void Nhap()
        {
            Console.Write("Nhap so hoc sinh:"); sohs = int.Parse(Console.ReadLine());
            ds = new Hocsinh[sohs];
            for (int i = 0; i < sohs; i++)
            {
                Console.WriteLine("Nhap thong tin cho sinh  vien thu {0}", i + 1);
                ds[i] = new Hocsinh();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            for (int i = 0; i < sohs; i++)
                ds[i].Hien();
        }
        public void Dsthilai()
        {

            Console.WriteLine("Danh sach sinh vien thi lai la");
            int j = 0;
            for (int i = 0; i < ds.Length; i++)
            {

                if (ds[i].Dhoa < 5 || ds[i].Dli < 5 || ds[i].Dtoan < 5)
                {
                    ds[i].Hien();
                    j++;
                }


            }
            if (j == 0) Console.WriteLine("Khong co hoc sinh nao thi lai!");
        }
    }
    class App3
    {
        static void Main4()
        {
            QLHS t = new QLHS();
            t.Nhap();
            Console.WriteLine("Danh sach hoc sinh ");
            t.Hien();
            t.Dsthilai();
            Console.ReadKey();

        }
    }
}

