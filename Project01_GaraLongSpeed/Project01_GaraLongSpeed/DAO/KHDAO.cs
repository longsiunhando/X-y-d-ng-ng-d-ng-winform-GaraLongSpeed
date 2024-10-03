using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class KHDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();
        public List<KH> danhSachKH()
        {
            return cont.KHs.ToList();
        }
        public List<KH> danhSachKH(string tuKhoa)
        {
            return cont.KHs.Where(kh => 
            tuKhoa == kh.maKH ||
            tuKhoa == kh.tenKH ||
            tuKhoa == kh.diachi ||
            tuKhoa == kh.sdt).ToList();
        }
        public KH getKH(string maKH)
        {
            return cont.KHs.Find(maKH);
        }
        public void addKH(KH kH)
        {
            cont.KHs.Add(kH);
            cont.SaveChanges();
        }
        public void update(KH khN)
        {
            KH kh = getKH(khN.maKH);

            kh.tenKH = khN.tenKH;
            kh.sdt = khN.sdt;
            kh.diachi = khN.diachi;
            cont.SaveChanges();
        }
        public void removeKH(KH kH)
        {
            cont.KHs.Remove(kH);
            cont.SaveChanges();
        }
    }
}
