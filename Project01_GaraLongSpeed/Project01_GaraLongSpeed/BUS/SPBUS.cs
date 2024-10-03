using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    public class SPBUS
    {
        SPDAO spDAO=new SPDAO();
        public List<SP> listSPB()
        {
            return spDAO.listSP().ToList();
        }
        public List<SP> listSPB(string tuKhoa)
        {
            return spDAO.listSP(tuKhoa).ToList();
        }
        public SP getSPB(string maSP) 
        {
            return spDAO.GetSP(maSP);
        }
        public void addSPB(SP sp) 
        {
            spDAO.AddSP(sp);
        }
        public void removeSPB(SP sp) 
        {
            spDAO.RemoveSP(sp);
        }
        public void updateSPB(SP spN)
        {
            spDAO.updateSP(spN);
        }

        public void updateSLBUS(string maSP, int sSP)
        {
            spDAO.updateSL(maSP, sSP);
        }

        public void updateSoLuongBUS(string maSP, int soSP)
        {
            spDAO.updateSoLuong(maSP, soSP);
        }
    }
}
