using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    internal class nccBUS
    {
        NCCDAO nccDAO = new NCCDAO();
        public List<NCC> danhSachNCCBUS()
        {
            return nccDAO.danhSachNCC();
        }
        public List<NCC> danhSachNCCBUS(string tuKhoa)
        {
            return nccDAO.danhSachNCC(tuKhoa);
        }
        public NCC getNCCBUS(string maNCC)
        {
            return nccDAO.getNCC(maNCC);
        }
        public void addNCCBUS(NCC ncc)
        {
            nccDAO.addNCC(ncc);
        }
        public void updateNCCBUS (NCC nccN)
        {
            nccDAO.updateNCC(nccN);
        }

        public void removeNCCBUS(NCC ncc)
        {
            nccDAO.removeNCC(ncc);
        }
    }
}
