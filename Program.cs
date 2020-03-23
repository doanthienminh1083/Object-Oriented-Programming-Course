using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    public static class mymath // static class
    {
        public static float pi = 3.14f; //static varible
        public static int luythua(int n)//static method
        {
            return n * n * n; ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n gia tri cua pi la: {0}", mymath.pi);
            Console.WriteLine("\n luy thua cua n la: {0}", mymath.luythua(2));
            Console.ReadKey();
        }
    }
}
