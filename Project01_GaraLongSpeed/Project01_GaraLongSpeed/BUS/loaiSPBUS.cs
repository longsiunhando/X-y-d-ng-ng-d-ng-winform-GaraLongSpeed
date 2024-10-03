using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    public class loaiSPBUS
    {
        loaiSPDAO loaiSPDAO = new loaiSPDAO();
        List<loaiSP> listLoaiSP;
        public List<loaiSP> listLoaiSPBUS()
        {
            return listLoaiSP= loaiSPDAO.listLoaiSP().ToList();
        }
        public List<loaiSP> listLoaiSPBUS(string tuKhoa)
        {
            return listLoaiSP = loaiSPDAO.listLoaiSP(tuKhoa).ToList();
        }
        public loaiSP getLoaiSPBUS(string tuKhoa)
        {
            return loaiSPDAO.getLoaiSP(tuKhoa);
        }
        public void addLoaiSP(loaiSP loaiSP)
        {
            loaiSPDAO.addLoaiSP(loaiSP);
        }
        public void updateLSPBUS(loaiSP loaiSPN)
        {
            loaiSPDAO.updatLSP(loaiSPN);
        }
        public void removeLoaiSPBUS(loaiSP loaiSP) 
        {
            loaiSPDAO.removeLoaiSP(loaiSP);
        }
    }
}
