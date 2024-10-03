using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class NVDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();
        public List<NV> listNV()
        {
            return cont.NVs.ToList();
        }
        public List<NV> listNV(string tuKhoa)
        {
            return cont.NVs.Where(nv=>
            tuKhoa == nv.tenNV.ToString()||
            tuKhoa == nv.maNV.ToString() ||
            tuKhoa == nv.diaChi.ToString() ||
            tuKhoa == nv.sdt.ToString()).ToList();
        }
        public NV GetNV(string maNV)
        {
            return cont.NVs.Find(maNV);
        }
        public void addNV(NV nv) 
        {
            cont.NVs.Add(nv);
            cont.SaveChanges();
        }
        public void updateNV(NV nvN)
        {
            NV nv = GetNV(nvN.maNV);
            nv.tenNV = nvN.tenNV;
            nv.diaChi = nvN.diaChi;
            nv.sdt = nvN.sdt;
            cont.SaveChanges();
        }
        public void removeNV(NV nV)
        {
            cont.NVs.Remove(nV);
            cont.SaveChanges();
        }
    }
}
