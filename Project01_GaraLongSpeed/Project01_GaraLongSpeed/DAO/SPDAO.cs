using Project01_GaraLongSpeed.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class SPDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();

        public List<SP>listSP()
        {
            return cont.SPs.ToList();
        }

        //Tim kiem cac san pham
        public List<SP> listSP(string tuKhoa)
        {
            return cont.SPs.Where(sp =>
            tuKhoa == sp.maSP.ToString() ||
            tuKhoa == sp.tenSP.ToString() || 
            tuKhoa==sp.soLuong.ToString()||
            tuKhoa == sp.giaNhap.ToString() ||
            tuKhoa == sp.giaBan.ToString() ||
            tuKhoa==sp.maLoai.ToString()).ToList<SP>();
        }

        //Tìm kiếm chính xác 1 sản phẩm
        public SP GetSP(string maSP)
        {
            return cont.SPs.Find(maSP);
        }

        public void AddSP(SP sp)
        {
            cont.SPs.Add(sp);
            cont.SaveChanges();
        }
        public void RemoveSP(SP sp) 
        {
            cont.SPs.Remove(sp);
            cont.SaveChanges();
        }
        public void updateSP(SP spN)
        {
            SP sP = GetSP(spN.maSP);
            sP.tenSP=spN.tenSP;
            sP.soLuong=spN.soLuong;
            sP.giaNhap=spN.giaNhap;
            sP.giaBan = spN.giaBan;
            sP.maLoai = spN.maLoai;
            cont.SaveChanges();

        }

        public void updateSL(string maSP, int sSP)
        {
            SP sP = GetSP(maSP);
            sP.soLuong=sP.soLuong+sSP;
            cont.SaveChanges();
        }

        public void updateSoLuong(string maSP, int soSP)
        {
            SP sp = cont.SPs.Find(maSP);
            sp.soLuong += soSP  ;
            cont.SaveChanges();

        }
    }
}
