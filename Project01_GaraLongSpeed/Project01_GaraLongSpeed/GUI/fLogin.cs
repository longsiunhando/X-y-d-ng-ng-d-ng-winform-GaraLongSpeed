 using Project01_GaraLongSpeed.BUS;
using Project01_GaraLongSpeed.DAO;
using Project01_GaraLongSpeed.GUI;
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

namespace Project01_GaraLongSpeed
{
    public partial class fLogin : Form
    {
        accountBUS accBUS = new accountBUS();
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo!!!", 
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDangKi_Click(object sender, EventArgs e)
        {
            fDangky f = new fDangky();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbAcc.Text;
            string pass= txbPass.Text;

            if (accBUS.getAccB(username) == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK);
            }
            else if(accBUS.getAccB(username).pass!=pass)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                fAdmin fA = new fAdmin();
                fA.Message = txbAcc.Text;
                fA.ShowDialog();
                

            }

        }
    }
}
