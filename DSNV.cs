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
            double tongLuongBienChe = 0;
            double tongLuongHopDong = 0;

            foreach (NhanVien nv in list)
            {
                Console.WriteLine("So CMND:{0}",nv.SoCMND);
                Console.WriteLine("Ho ten:{0}", nv.HoTen);
                Console.WriteLine("Phong ban:{0}", nv.PhongBan);
                Console.WriteLine("Loai nhan vien:{0}", nv.loaiNV());

                double luong = nv.tinhLuong();
                Console.WriteLine("Luong: ${0}", luong);


                if (nv is BienChe)
                {
                    tongLuongBienChe += luong;
                }
                else if (nv is HopDong)
                {
                    tongLuongHopDong += luong;
                }
            }

            Console.WriteLine("Tong luong nhan vien bien che: ${0}", tongLuongBienChe);
            Console.WriteLine("Tong luong nhan vien hop dong: ${0}", tongLuongHopDong);
        }
        }
    }

