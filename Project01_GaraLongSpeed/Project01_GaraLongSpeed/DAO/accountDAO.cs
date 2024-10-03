using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.DAO
{
    public class accountDAO
    {
        LongSpeedGaraMotorCycleEntities cont = new LongSpeedGaraMotorCycleEntities();

        public List<account> listAcc()
        {
            return cont.accounts.ToList();
        }
        public List<account> listAcc(string tuKhoa)
        {
            return cont.accounts.Where(acc=> 
            tuKhoa==acc.username.ToString()||
            tuKhoa == acc.pass.ToString()||
            tuKhoa == acc.displayname.ToString() ||
            tuKhoa == acc.diaChi.ToString() ||
            tuKhoa == acc.sdt.ToString() |
            tuKhoa == acc.email.ToString()).ToList();
        }
        public account getAcc(string username)
        {
            account acc = cont.accounts.Find(username);
            return acc;
        }
        public void addAcc(account acc) {
            cont.accounts.Add(acc);
            cont.SaveChanges();
        }
        public void updateAcc(account accN)
        {
            account acc = getAcc(accN.username);
            acc.displayname = accN.displayname;
            acc.pass = accN.pass;
            acc.sdt = accN.sdt;
            acc.email = accN.email;
            acc.diaChi = accN.diaChi;
            acc.type = accN.type;
            cont.SaveChanges();
        }
        public void removeAcc(account acc)
        {
            cont.accounts.Remove(acc);
            cont.SaveChanges() ;
        }
        
    }
}
