using Project01_GaraLongSpeed.BUS;
using Project01_GaraLongSpeed.DAO;
using System;
using System.Windows.Forms;

namespace Project01_GaraLongSpeed.GUI
{
    public partial class fAdmin : Form
    {
        accountBUS accBUS = new accountBUS();
        private string username;
        public string Message
        {
            get { return username; }
            set { username = value; }
        }
        public fAdmin()
        {
            InitializeComponent();
        }
        private void fAdmin_Load_1(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            account acc = accBUS.getAccB(username);
            mS_Displayname.Text = acc.displayname;
            if (acc.type == 0)
            {
                mStripfMain.Items.Remove(quảnLýTàiKhoảnUserToolStripMenuItem);
                mStripfMain.Items.Remove(quảnLýNhânSựToolStripMenuItem);
                mStripfMain.Items.Remove(thốngKêToolStripMenuItem);
            }

        }
        private void mS_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mS_TTTK_Click(object sender, EventArgs e)
        {


            fTTTK f = new fTTTK(username);
            f.MdiParent = this;
            f.Show();
        }
        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHelp fHelp = new fHelp();
            fHelp.MdiParent = this;
            fHelp.Show();
        }

        // Chọn loại sản phẩm hiện lên khi load form QLSP
        private void tấtCảCácMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "all";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "XM";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void nhuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "AO";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void đènLedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "DL";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void biCầuLEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "BCL";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void biLazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "BL";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void lốpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "LX";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void phuộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "PGS";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void mâmBánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "MB";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void gươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "GX";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void xinNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "XN";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void yênXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "YX";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void cùmCônPhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "CP";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        private void khácToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fQLHH fQLHH = new fQLHH();
            fQLHH.Message = "SPK";
            fQLHH.MdiParent = this;
            fQLHH.Show();
        }

        
        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLnhansu f = new fQLnhansu();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýTàiKhoảnUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLtaikhoan f = new fQLtaikhoan();
            f.MdiParent = this;
            f.Show();
        }

        //QL giao dịch
        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLnhap f = new fQLnhap();
            f.MdiParent = this;
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNCC fNCC = new fNCC();
            fNCC.MdiParent = this;
            fNCC.Show();
        }

        private void KháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKH fKH = new fKH();
            fKH.MdiParent = this;
            fKH.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLban fQLban = new fQLban();
            fQLban.MdiParent = this;
            fQLban.Show();
        }

        //Thống kê
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongKe fTK = new fThongKe();
            fTK.MdiParent = this;
            fTK.Show();
        }
        
        private void qLLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLloai fLoai = new fQLloai();
            fLoai.MdiParent = this;
            fLoai.Show();
        }
    }
}
