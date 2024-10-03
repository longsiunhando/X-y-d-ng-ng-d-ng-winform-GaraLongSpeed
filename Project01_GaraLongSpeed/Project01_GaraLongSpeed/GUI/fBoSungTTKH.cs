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
    public partial class fBoSungTTKH : Form
    {
        public fBoSungTTKH()
        {
            InitializeComponent();
        }
        private string maKH;
        public string Message
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                KH kh = new KH();
                kh.maKH = maKH;
                kh.tenKH = txbTenKH.Text;
                kh.sdt = txbSDT.Text;
                kh.diachi = txbDiaChi.Text;
                khBUS khBUS = new khBUS();
                khBUS.addKHBUS(kh);

            }
            catch
            {
                MessageBox.Show("Thêm khách hàng không thành công",
"Thông báo!", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
