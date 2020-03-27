using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    class sinhvien
    {
        int MaSV;
        string TenSV;
        double Diem;
        public sinhvien()
        {
            MaSV = 0;
            TenSV = " ";
            Diem = 0;
        }
        public sinhvien(int _MaSV,String _Tensv,double _Diem)
        {
            MaSV = _MaSV;
            TenSV = _Tensv;
            Diem = _Diem;
        }
        public void Nhap()
        {
            Console.Write("\n Nhap ma sv:");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("\n Nhap ten: ");
            TenSV = Console.ReadLine();
            Console.Write("\n Nhap Diem sv:");
            Diem = Double.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("\n {0}\t{1}\t{2}", MaSV, TenSV, Diem);
        }
        public static sinhvien operator -(sinhvien sv)
        {
            sinhvien a = new sinhvien();
            a.TenSV = sv.TenSV;
            a.MaSV = sv.MaSV;
            if (sv.Diem < 0) a.Diem = -sv.Diem;
            else
                a.Diem = sv.Diem;
            return a;
        }
        public static bool operator >(sinhvien sva,sinhvien svb)
        {
            return sva.Diem > svb.Diem;
        }
        public static bool operator <(sinhvien sva, sinhvien svb)
        {
            return sva.Diem < svb.Diem;
        }
        public static bool operator ==(sinhvien sva, sinhvien svb)
        {
            return sva.Diem == svb.Diem;
        }
        public static bool operator !=(sinhvien sva, sinhvien svb)
        {
            return sva.Diem != svb.Diem;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            sinhvien sv1 = new sinhvien();
            sinhvien sv2 = new sinhvien();
            Console.WriteLine("\n nhap sinh vien thu 1:");
            sv1.Nhap();
            Console.WriteLine("\n nhap sinh vien thu 2:");
            sv2.Nhap();
            Console.WriteLine("\n thong tin hai sinh vien : ");
            sv1.Hienthi();
            sv2.Hienthi();
            Console.WriteLine("\n thong tin sinh vien thu nhat sau khi doi dau: ");
            sv1 = -sv1;
            sv1.Hienthi();
            Console.WriteLine("\n thong tin sinh vien thu hai sau khi doi dau: ");
            sv2 = -sv2;
            sv2.Hienthi();
            Console.WriteLine("\n so sanh diem hai sinh vien 1 va 2");
            if(sv1>sv2)Console.WriteLine("\n Diem sinh vien sv1 lon hon diem sv2");
            else if(sv1<sv2)Console.WriteLine("\n Diem sinh vien sv1 nho hon diem sv2");
            else
            {
                if (sv1 == sv2) Console.WriteLine("\n hai sinh vien bang diem nhau");
            }
            Console.ReadKey();

        }
    }
}
