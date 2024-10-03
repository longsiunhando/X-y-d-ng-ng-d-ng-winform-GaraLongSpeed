using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_GaraLongSpeed.BUS
{
    public class accountBUS
    {
        accountDAO accDAO= new accountDAO();
        public List<account> listAccB() { return accDAO.listAcc(); }
        public List<account> listAccB(string tuKhoa) { return accDAO.listAcc(tuKhoa).ToList(); }
        public void addAccB(account acc) { accDAO.addAcc(acc); }
        public void updateAccBUS(account accN)
        {
            accDAO.updateAcc(accN);
        }
        public void removeAccB(account acc) { accDAO.removeAcc(acc); }
        public account getAccB(string usename) { return accDAO.getAcc(usename); }
    }
}
