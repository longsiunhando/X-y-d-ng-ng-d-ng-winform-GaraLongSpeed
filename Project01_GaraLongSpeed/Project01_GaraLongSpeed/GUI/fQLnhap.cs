using Project01_GaraLongSpeed.BUS;
using Project01_GaraLongSpeed.DAO;
using Project01_GaraLongSpeed.Export_file;
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
    public partial class fQLnhap : Form
    {
        HDNbus hdnBUS = new HDNbus();
        nccBUS nccBUS = new nccBUS();
        NVBUS nvBUS = new NVBUS(); 
        SPBUS SPBUS = new SPBUS();
        public fQLnhap()
        {
            InitializeComponent();
        }
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }

        private void fQLnhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdnBUS.danhSachHDNb();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[dong].Cells["maHDN"].Value != null)
                    txbMaHDN.Text = dataGridView1.Rows[dong].Cells["maHDN"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maNCC"].Value != null)
                    txbMaNCC.Text = dataGridView1.Rows[dong].Cells["maNCC"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maNV"].Value != null)
                    txbMaNV.Text = dataGridView1.Rows[dong].Cells["maNV"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maSP"].Value != null)
                    txbMaSP.Text = dataGridView1.Rows[dong].Cells["maSP"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["soLuong"].Value != null)
                    txbSoLuong.Text = dataGridView1.Rows[dong].Cells["soLuong"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["giaNhap"].Value != null)
                    txbGia.Text = dataGridView1.Rows[dong].Cells["giaNhap"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["thanhTien"].Value != null)
                    txbThanhTien.Text = dataGridView1.Rows[dong].Cells["thanhTien"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["thoiGianN"].Value != null)
                    dateNhap.Text = dataGridView1.Rows[dong].Cells["thoiGianN"].Value.ToString();
                
            }
            catch  
            { }
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            txbMaHDN.Clear();
            txbMaNCC.Clear();
            txbMaNV.Clear();
            txbMaSP.Clear();
            txbSoLuong.Clear();
            txbGia.Clear();
            txbThanhTien.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (nvBUS.GetNVBUS(txbMaNV.Text) == null)
            {
                MessageBox.Show("Không tồn tại nhân viên có mã như trên!",
                    "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (nccBUS.getNCCBUS(txbMaNCC.Text) == null)
                {
                    MessageBox.Show("Thêm thông tin nhà cung cấp mới?",
    "Thông báo", MessageBoxButtons.OK);
                    fBoSungTTNCC f = new fBoSungTTNCC();
                    f.Message = txbMaNCC.Text;
                    f.ShowDialog();
                }


                if (SPBUS.getSPB(txbMaSP.Text) == null)
                {
                    MessageBox.Show("Thêm thông tin sản phẩm mới?",
    "Thông báo", MessageBoxButtons.OK);
                    fBoSungTTHD f = new fBoSungTTHD();
                    f.Message = txbMaSP.Text;
                    f.ShowDialog();
                }




                try
                {
                    int soSP = int.Parse(txbSoLuong.Text);
                    SPBUS.updateSoLuongBUS(txbMaSP.Text, soSP);

                    SP spp = SPBUS.getSPB(txbMaSP.Text);
                    HDN hdn = new HDN();
                    hdn.maHDN = txbMaHDN.Text;
                    hdn.maNCC = txbMaNCC.Text;
                    hdn.maNV = txbMaNV.Text;
                    hdn.maSP = txbMaSP.Text;
                    hdn.soLuong = int.Parse(txbSoLuong.Text);
                    hdn.giaNhap = spp.giaNhap;
                    hdn.thanhTien = int.Parse(txbSoLuong.Text) * spp.giaNhap;
                    hdn.thoiGianN = DateTime.Parse(dateNhap.Text);





                    hdnBUS.addHDNBUS(hdn);
                    dataGridView1.DataSource = hdnBUS.danhSachHDNb();
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    DoRongCotTuDong(1);
                    DoRongCotTuDong(dataGridView1.ColumnCount - 1);


                }
                catch
                {
                    MessageBox.Show("Vui Lòng nhập đúng thông tin sản phẩm.",
    "Thông báo", MessageBoxButtons.OK);
                }
            }
            

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txbMaHDN.Text == "" || hdnBUS.GetHDNBUS(txbMaHDN.Text) == null)
            {
                MessageBox.Show("Vui Lòng nhập đúng mã hóa đơn nhập cần xóa.",
"Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                int soSP = hdnBUS.GetHDNBUS(txbMaHDN.Text).soLuong;
                SPBUS.updateSoLuongBUS(hdnBUS.GetHDNBUS(txbMaHDN.Text).maSP,soSP);
                hdnBUS.removeHDNBUS(hdnBUS.GetHDNBUS(txbMaHDN.Text));

                dataGridView1.DataSource = hdnBUS.danhSachHDNb();
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);

                MessageBox.Show("Xóa hóa đơn nhập thành công",
"Thông báo", MessageBoxButtons.OK);
            }    
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdnBUS.danhSachHDNb(txbTimKiem.Text);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel exportToExcel = new ExportToExcel();
                exportToExcel.xuatEXCEL(dataGridView1, filePath,8);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }

        }
    }
}
