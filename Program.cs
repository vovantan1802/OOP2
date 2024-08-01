using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSNV list = new DSNV();
            NhanVien nv;
            int chon;
            string tieptuc = "";
            do
            {
                Console.WriteLine("Nhap nhan vien:(1_NVHD,2_NVBC):");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new HopDong();
                        nv.nhap();
                        list.them(nv);
                        break;
                    case 2:
                        nv = new BienChe();
                        nv.nhap();
                        list.them(nv);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Ban co muon tiep tuc khong?(Y/N)");
                tieptuc += Console.ReadLine();
            } while (tieptuc.ToUpper() == "Y");
            list.hienthi();
            Console.ReadKey();
                
        }
    }
}
