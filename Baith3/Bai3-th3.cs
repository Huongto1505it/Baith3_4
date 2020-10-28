using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3
{
    class Bai3_th3
    {
        class Time
        {
            private int gio, phut, giay;
            public Time()
            {
                gio = phut = giay = 0;
            }
            public Time(int gio, int phut, int giay)
            {
                this.gio = gio;
                this.phut = phut;
                this.giay = giay;
            }
            public int Gio
            {
                get
                {
                    return gio;
                }
                set
                {
                    gio = value;
                }
            }
            public int Phut
            {
                get
                {
                    return phut;
                }
                set
                {
                    phut = value;
                }
            }
            public int Giay
            {
                get
                {
                    return giay;
                }
                set
                {
                    giay = value;
                }
            }
            public Time normlize()
            {

                this.phut += giay / 60;
                this.giay = giay % 60;
                this.gio += phut / 60;
                this.phut = phut % 60;
                this.gio = gio % 24;
                return this;
            }
            public Time advance(int h, int m, int s)
            {
                Time t = new Time();
                t.giay = giay + s;
                t.phut = phut + m;
                t.gio = gio + h;
                t.normlize();
                return t;
            }
            public Time reset(int h, int m, int s)
            {
                Time t = new Time();
                t.giay = s;
                t.phut = m;
                t.gio = h;
                t.normlize();
                return t;
            }
            public void Hien()
            {

                Console.WriteLine("Thoi gian hien hanh {0}-{1}-{2}", gio, phut, giay);

            }

        }
        class Program
        {
            static void Main1(string[] args)
            {
                Time t = new Time(15, 134, 67);
                Time t2 = t.normlize();
                t2.Hien();
                Time t3 = t.advance(2, 46, 7);
                t3.Hien();
                Time t4 = t.reset(15, 23, 45);
                t4.Hien();
                Console.ReadKey();
            }
        }
    }
}
