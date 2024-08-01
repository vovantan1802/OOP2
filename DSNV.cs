using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DSNV
    {
        private ArrayList list;

        public DSNV()
        {
            list = new ArrayList();
        }
        public void them(NhanVien nv)
        { 
            list.Add(nv); 
        }
        public void hienthi()
        {
            foreach (NhanVien nv in list)
            {
                Console.WriteLine("So CMND:{0}",nv.SoCMND);
                Console.WriteLine("Ho ten:{0}", nv.HoTen);
                Console.WriteLine("Phong ban:{0}", nv.PhongBan);
                Console.WriteLine("Loai nhan vien:{0}", nv.loaiNV());
                Console.WriteLine("Luong:{0}.000VND", nv.tinhLuong());
            }
        }
    }
}
