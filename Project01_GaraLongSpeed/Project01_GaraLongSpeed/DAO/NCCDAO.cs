using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class NCCDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();
        public List<NCC> danhSachNCC()
        {
            return cont.NCCs.ToList();
        }
        public List<NCC> danhSachNCC(string tuKhoa)
        {
            return cont.NCCs.Where(ncc => 
            tuKhoa == ncc.tenNCC.ToString()||
            tuKhoa == ncc.maNCC.ToString()||
            tuKhoa == ncc.sdt.ToString()||
            tuKhoa == ncc.diaChi.ToString()).ToList();
        }
        public NCC getNCC(string maNCC)
        {
            return cont.NCCs.Find(maNCC);
        }

        public void addNCC(NCC nCC)
        {
            cont.NCCs.Add(nCC);
            cont.SaveChanges();
        }
        public void updateNCC(NCC nccN)
        {
            NCC ncc = getNCC(nccN.maNCC);
            ncc.tenNCC=nccN.tenNCC;
            ncc.diaChi=nccN.diaChi;
            ncc.sdt=nccN.sdt;
            cont.SaveChanges();
        }

        public void removeNCC(NCC nCC)
        {
            cont.NCCs.Remove(nCC);
            cont.SaveChanges();
        }
    }
}
