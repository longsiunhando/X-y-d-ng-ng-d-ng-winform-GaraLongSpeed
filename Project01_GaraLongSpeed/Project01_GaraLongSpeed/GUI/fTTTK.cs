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
    public partial class fTTTK : Form
    {
        public fTTTK()
        {
            InitializeComponent();
        }
        accountBUS accBUS= new accountBUS();
        public fTTTK(string usename):this()
        {
            account acc = accBUS.getAccB(usename);
            txbUsername.Text = usename;
            txbDisplayName.Text = acc.displayname;
            txbEmail.Text = acc.email;
            txbSĐT.Text = acc.sdt;
            txbAddress.Text = acc.diaChi;
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangePass f = new fChangePass();
            f.Message = txbUsername.Text;
            f.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            account acc = accBUS.getAccB(txbUsername.Text);
            account accN = new account();

            
            try
            {
                accN.username = txbUsername.Text;
                accN.pass = acc.pass;
                accN.displayname = txbDisplayName.Text;
                accN.email = txbEmail.Text;
                accN.sdt = txbSĐT.Text;
                accN.diaChi = txbAddress.Text;
                accN.type=acc.type;

                accBUS.updateAccBUS(accN);

                MessageBox.Show("Cập nhật thông tin thành công!",
                    "Thông báo!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin yêu cầu!",
                    "Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            fHelp fHelp = new fHelp();
            fHelp.ShowDialog();
        }
    }
}
