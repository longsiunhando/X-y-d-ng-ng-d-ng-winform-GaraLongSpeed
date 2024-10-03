using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    internal class HDBbus
    {
        HDBDAO hdBanDAO = new HDBDAO();
        public List<HDB> danhSachHDBb()
        {
            return hdBanDAO.danhSachHDB();
        }
        public List<HDB> danhSachHDBb(string tuKhoa)
        {
            return hdBanDAO.danhSachHDB(tuKhoa);
        }
        public List<HDB> danhSachHDBtheoTGbus(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return hdBanDAO.danhSachHDBtheoTG(ngayBatDau, ngayKetThuc);
        }
        public HDB GetHDBBUS(string maHDB)
        {
            return hdBanDAO.getHDB(maHDB);
        }
        public void addHDBBUS(HDB hdB)
        {
            hdBanDAO.addHDB(hdB);
        }
        public void removeHDBBUS(HDB hdB)
        {
            hdBanDAO.removeHDB(hdB);
        }
    }
}
