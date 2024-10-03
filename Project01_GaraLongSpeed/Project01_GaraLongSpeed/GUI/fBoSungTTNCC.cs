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
    public partial class fBoSungTTNCC : Form
    {
        public fBoSungTTNCC()
        {
            InitializeComponent();
        }
        private string maNCC;
        public string Message
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                NCC nCC = new NCC();
                nCC.maNCC = maNCC;
                nCC.tenNCC = txbTenNCC.Text;
                nCC.sdt = txbSDT.Text;
                nCC.diaChi = txbDiaChi.Text;
                nccBUS nccBUS = new nccBUS();
                nccBUS.addNCCBUS(nCC);

            }
            catch 
            {
                MessageBox.Show("Thêm NCC không thành công",
"Thông báo!", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
