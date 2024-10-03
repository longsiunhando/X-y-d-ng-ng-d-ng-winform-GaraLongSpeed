using Project01_GaraLongSpeed.BUS;
using Project01_GaraLongSpeed.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01_GaraLongSpeed.GUI
{
    public partial class fBoSungTTHD : Form
    {
        public fBoSungTTHD()
        {
            InitializeComponent();
        }
        private string maSP;
        public string soLuong;
        public string giaNhap;
        SPBUS spBUS = new SPBUS();
        public string Message
        {
            get { return maSP; }
            set { maSP = value; }

        }


       
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                SP spN = new SP();
                spN.maSP = maSP;
                spN.tenSP = txbTenSP.Text;
                spN.soLuong = 0;
                spN.giaNhap = float.Parse(txbGiaNhap.Text);
                spN.giaBan = float.Parse(txbGiaBan.Text);
                spN.maLoai = txbMaLoai.Text;
                SPBUS spBUS = new SPBUS();
                spBUS.addSPB(spN);

            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm không thành công",
"Thông báo!", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
