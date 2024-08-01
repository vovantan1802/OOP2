using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class HopDong:NhanVien
    {
        private float soGio;
        private float tienCongMotGio;

        public HopDong() : base() 
        { 
            this.soGio = 0.0f;
            this.tienCongMotGio = 0.0f;
        }
        public HopDong(string soCMND, string hoTen, string phongBan, float soGio, float tienCongMotGio): base(soCMND, hoTen, phongBan)
        {
            this.soGio = soGio;
            this.tienCongMotGio = tienCongMotGio;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap so gio");
            soGio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so luong tren 1 gio");
            tienCongMotGio = Convert.ToInt32(Console.ReadLine());
        }
        public override float tinhLuong()
        {
            return soGio * tienCongMotGio;
        }
        public override string loaiNV()
        {
            return "Hop Dong";
        }
    }
}
