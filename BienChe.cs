using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BienChe:NhanVien
    {
        private int bacLuong;

        public BienChe() : base()
        {
            this.bacLuong = 0;
        }
        public BienChe(string soCMND, string hoTen, string phongBan, int bacLuong) : base(soCMND, hoTen, phongBan)
        {
            this.bacLuong = bacLuong;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap bac luong");
            bacLuong = Convert.ToInt32(Console.ReadLine());
        }
        public override float tinhLuong()
        {
            return bacLuong * 1490;
        }
        public override string loaiNV()
        {
            return " Bien che";
        }
    }
    }

