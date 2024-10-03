using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class HDNDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();
        public List<HDN>danhSachHDN()
        {
            return cont.HDNs.ToList();
        }
        public List<HDN>danhSachHDN(string tuKhoa)
        {
            return cont.HDNs.Where(hdn=>
            tuKhoa==hdn.maHDN||
            tuKhoa == hdn.maNCC ||
            tuKhoa == hdn.maNV ||
            tuKhoa == hdn.maSP ||
            tuKhoa == hdn.soLuong.ToString() ||
            tuKhoa == hdn.giaNhap.ToString() ||
            tuKhoa == hdn.thanhTien.ToString()||
            tuKhoa == hdn.thoiGianN.ToString()).ToList();
        }
        public List<HDN>danhSachHDNtheoTG(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return cont.HDNs.Where(hdn => hdn.thoiGianN >= ngayBatDau && hdn.thoiGianN <= ngayKetThuc).ToList();
        }
        public HDN getHDN(string maHDN)
        {
            return cont.HDNs.Find(maHDN);
        }
        public void addHDN(HDN hdN)
        {
            cont.HDNs.Add(hdN);
            cont.SaveChanges();
        }
        public void removeHDN(HDN hdN)
        {
            cont.HDNs.Remove(hdN);
            cont.SaveChanges();
        }


    }
}
