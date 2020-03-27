using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap_Operator
{
    class Nhanvien
    {
        private int manv;
        private string tennv;
        private string chucvu;
        private double tienluong;

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public double Tienluong
        {
            get { return tienluong; }
            set { tienluong = value; }
        }
        public Nhanvien()
        {
            this.manv = 0;
            this.tennv = string.Empty;
            this.chucvu = string.Empty;
            this.tienluong = 0;
        }
        public Nhanvien(int ma, string ten, string cv, double luong)
        {
            this.manv = ma;
            this.tennv = ten;
            this.chucvu = cv;
            this.tienluong = luong;
        }
        public void nhap()
        {
            Console.WriteLine("\n Nhap ma nhan vien:");
            manv = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Nhap Ten nhan vien:");
            tennv = Console.ReadLine();
            Console.WriteLine("\n Nhap Chuc vu nhan vien:");
            chucvu = Console.ReadLine();
            Console.WriteLine("\n Nhap luong nhan vien:");
            tienluong = int.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \n", manv, tennv, chucvu, tienluong);
        }

        public static bool operator >(Nhanvien a, Nhanvien b)
        {
            return a.tienluong > b.tienluong;
        }
        public static bool operator <(Nhanvien a, Nhanvien b)
        {
            return a.tienluong < b.tienluong;
        }

    }
}
