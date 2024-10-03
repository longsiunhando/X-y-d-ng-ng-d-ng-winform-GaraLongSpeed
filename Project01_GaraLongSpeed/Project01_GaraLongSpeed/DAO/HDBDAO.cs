using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class HDBDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();
        public List<HDB> danhSachHDB()
        {
            return cont.HDBs.ToList();
        }
        public List<HDB> danhSachHDB(string tuKhoa)
        {
            return cont.HDBs.Where(hdb =>
            tuKhoa == hdb.maHDB ||
            tuKhoa == hdb.maKH ||
            tuKhoa == hdb.maNV ||
            tuKhoa == hdb.maSP ||
            tuKhoa == hdb.soLuong.ToString() ||
            tuKhoa == hdb.giaBan.ToString() ||
            tuKhoa == hdb.thanhTien.ToString() ||
            tuKhoa == hdb.thoiGianB.ToString()).ToList();
        }
        public List<HDB> danhSachHDBtheoTG(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return cont.HDBs.Where(hdb => hdb.thoiGianB >= ngayBatDau && hdb.thoiGianB <= ngayKetThuc).ToList();
        }
        public HDB getHDB(string maHDB)
        {
            return cont.HDBs.Find(maHDB);
        }
        public void addHDB(HDB hdB)
        {
            cont.HDBs.Add(hdB);
            cont.SaveChanges();
        }
        public void removeHDB(HDB hdB)
        {
            cont.HDBs.Remove(hdB);
            cont.SaveChanges();
        }
    }
}
