using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Ctime
    {
        int h, m, s;
        public Ctime() // Constructor khong tham so
        {
            h = m = s=0;
        }
        public Ctime(int hh, int mm, int ss)// Constructor co tham so
        {
            h = hh;
            m = mm;
            s = ss;
        }
        public Ctime(Ctime t) // Constructor sao chep
        {
            h = t.h;
            m = t.m;
            s = t.s;
        }
        ~Ctime() // destructor 
        {
            Console.Write("Da huy");
            Console.ReadKey();
        }
        public void xuat()
        {
            Console.Write("{0}:{1}:{2}", h, m, s);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Ctime t1 = new Ctime();
            Ctime t2 = new Ctime(12,12,12);
            Ctime t3 = new Ctime(t2);
            t3.xuat();
          
            Console.ReadKey();

        }
    }
}
