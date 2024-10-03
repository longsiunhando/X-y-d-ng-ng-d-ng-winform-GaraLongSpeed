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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project01_GaraLongSpeed.GUI
{
    public partial class fChangePass : Form
    {
        public fChangePass()
        {
            InitializeComponent();
        }
        accountBUS accBUS= new accountBUS();
        private string username;
        public string Message
        { 
            get { return username; }
            set { username = value; }
        }
        private void btnConfirmPass_Click(object sender, EventArgs e)
        {

            account acc = accBUS.getAccB(username);
            account accN = new account();

            if (acc.pass == txbPass.Text && txbNewPass.Text == txbPassAgain.Text)
            {
                try
                {
                    accN.username = username;
                    accN.pass = txbNewPass.Text;
                    accN.displayname = acc.displayname;
                    accN.email = acc.email;
                    accN.sdt = acc.sdt;
                    accN.diaChi = acc.diaChi;
                    accBUS.updateAccBUS(accN);

                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi nhập liệu!\nVui lòng nhập lại thông tin <3", "Thông báo!", MessageBoxButtons.OK);
                    txbPass.Clear();
                    txbNewPass.Clear();
                    txbPassAgain.Clear();
                    txbPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lỗi nhập liệu!\nVui lòng nhập lại thông tin <3", "Thông báo!", MessageBoxButtons.OK);
                txbPass.Clear();
                txbNewPass.Clear();
                txbPassAgain.Clear();
                txbPass.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
