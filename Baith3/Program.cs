using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith3_4
{
    class Doibong
    {
        private string tendb, huanlv;
        private int[] cauthu;
        public void Nhap()
        {
            Console.Write("Nhap ten doi bong:"); tendb = Console.ReadLine();
            Console.Write("Nhap ten huan luyen vien:"); huanlv = Console.ReadLine();
            cauthu = new int[11];
            for(int i = 0; i < 11; i++)
            {
                Console.Write("Nhap ten cau thu thu {0}:",i+1);
                cauthu[i] = int.Parse(Console.ReadLine());
            }
        }
    }
    class Bang
    {
        private Doibong[] db;
        public void Nhap()
        {
            db = new Doibong[32];
            Console.WriteLine("Nhap danh sach bang A");
            for (int i = 0; i < 4; i++)
            {
                db[i] = new Doibong();
                db[i].Nhap();
            }

            


        }

    }
    class App
    {
        static void Main()
        {
            Bang b = new Bang();
            b.Nhap();
            Console.ReadKey();
        }
    }
}