using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class loaiSPDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();
        public List<loaiSP> listLoaiSP()
        {
            return cont.loaiSPs.ToList();
        }
        public List<loaiSP> listLoaiSP(string tuKhoa)
        {
            return cont.loaiSPs.Where(lsp=>tuKhoa==lsp.tenLoai.ToString()||tuKhoa==lsp.maLoai.ToString()).ToList();
        }
        public loaiSP getLoaiSP(string tuKhoa)
        {
            return cont.loaiSPs.Find(tuKhoa);
        }
        public void addLoaiSP(loaiSP loaiSP)
        {
            cont.loaiSPs.Add(loaiSP);
            cont.SaveChanges();
        }
        public void updatLSP(loaiSP loaiSPN)
        {
            loaiSP loaiSP = getLoaiSP(loaiSPN.maLoai);
            loaiSP.tenLoai = loaiSPN.tenLoai;
            cont.SaveChanges();
        }
        public void removeLoaiSP(loaiSP loaiSP)
        {
            cont.loaiSPs.Remove(loaiSP);
            cont.SaveChanges();
        }
    }
}
