using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    public class NVBUS
    {
        NVDAO NVDAO = new NVDAO();
        public List<NV>listNV()
        {
            return NVDAO.listNV();
        }
        public List<NV> listNV(string tuKhoa)
        {
            return NVDAO.listNV(tuKhoa);
        }
        public NV GetNVBUS(string maNV)
        {
            return NVDAO.GetNV(maNV);
        }
        public void addNVBUS(NV nv) 
        {
            NVDAO.addNV(nv);
        }
        public void updateNVBUS(NV nvN)
        {
            NVDAO.updateNV(nvN);
        }
        public void removeNVBUS(NV nv)
        {
            NVDAO.removeNV(nv);
        }
    }
}
