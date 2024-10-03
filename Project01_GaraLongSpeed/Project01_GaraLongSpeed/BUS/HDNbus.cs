using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    internal class HDNbus
    {
        HDNDAO hdNhapDAO = new HDNDAO();
        public List<HDN> danhSachHDNb()
        {
            return hdNhapDAO.danhSachHDN();
        }
        public List<HDN> danhSachHDNb(string tuKhoa)
        {
            return hdNhapDAO.danhSachHDN(tuKhoa);
        }
        public List<HDN> danhSachHDNtheoTGbus(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return hdNhapDAO.danhSachHDNtheoTG(ngayBatDau, ngayKetThuc);
        }
        public HDN GetHDNBUS(string maHDN)
        {
            return hdNhapDAO.getHDN(maHDN);
        }
        public void addHDNBUS(HDN hdN)
        {
            hdNhapDAO.addHDN(hdN);
        }
        public void removeHDNBUS(HDN hdN)
        {
            hdNhapDAO.removeHDN(hdN);
        }

    }
}
