using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class NhanVien
    {
        protected string soCMND;
        protected string hoTen;
        protected string phongBan;

        public string HoTen { get => hoTen; set => hoTen = value;}

        public string SoCMND { get => soCMND; set => soCMND = value;}

        public string PhongBan { get => phongBan; set => phongBan = value;}
        public NhanVien()
        { 
            this.soCMND = "";
            this.phongBan = "";
            this.HoTen = "";
        }
        public NhanVien(string soCMND, string hoTen, string phongBan)
        {
            this.soCMND = soCMND;
            this.HoTen = hoTen;
            this.phongBan = phongBan;
        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhap so CMND");
            soCMND = (Console.ReadLine());
            Console.WriteLine("Nhap ho ten ");
            hoTen = (Console.ReadLine());
            Console.WriteLine("Nhap phong ban");
            phongBan = (Console.ReadLine());
        }
        abstract public float tinhLuong();

        public virtual string loaiNV()
        {
            return "";
        }
    }
}
