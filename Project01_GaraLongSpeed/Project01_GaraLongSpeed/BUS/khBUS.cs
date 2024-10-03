using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    public class khBUS
    {
        KHDAO khDAO = new KHDAO();
        public List<KH> danhSachKHBUS()
        {
            return khDAO.danhSachKH();
        }
        public List<KH> danhSachKHBUS(string tuKhoa)
        {
            return khDAO.danhSachKH(tuKhoa);
        }
        public KH GetKHBUS(string maKH)
        {
            return khDAO.getKH(maKH);
        }
        public void addKHBUS(KH kH)
        {
            khDAO.addKH(kH);
        }
        public void updateKHBUS(KH khN)
        {
            khDAO.update(khN);
        }
        public void removeKHBUS(KH kh)
        {
            khDAO.removeKH(kh);
        }
    }
}
