using Project01_GaraLongSpeed.BUS;
using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01_GaraLongSpeed.GUI
{
    public partial class fDangky : Form
    {
        public fDangky()
        {
            InitializeComponent();
        }
        accountBUS accBUS= new accountBUS();

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            account accN = new account();
            accN.displayname = txbDisplayName.Text;
            accN.username = txbUsername.Text;
            accN.pass = txbPass.Text;
            accN.email = txbEmail.Text;
            accN.sdt = txbSĐT.Text;
            accN.diaChi = txbAddress.Text;

            try
            {
                if (txbPass.Text == txbPassAgain.Text)
                {
                    accBUS.addAccB(accN);
                    MessageBox.Show("Đăng ký thành công!\n Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin yêu cầu!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch 
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin yêu cầu!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
