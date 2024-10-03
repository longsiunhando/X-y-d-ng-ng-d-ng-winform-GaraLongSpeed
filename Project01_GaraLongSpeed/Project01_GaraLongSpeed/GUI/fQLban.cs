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
    public partial class fQLban : Form
    {
        public fQLban()
        {
            InitializeComponent();
        }
        HDBbus hdbBUS = new HDBbus();
        khBUS khBUS = new khBUS();
        NVBUS nvBUS = new NVBUS();
        SPBUS SPBUS = new SPBUS();
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        private void fQLban_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdbBUS.danhSachHDBb();
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
                if (dataGridView1.Rows[dong].Cells["maHDB"].Value != null)
                    txbMaHDB.Text = dataGridView1.Rows[dong].Cells["maHDB"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maKH"].Value != null)
                    txbMaKH.Text = dataGridView1.Rows[dong].Cells["maKH"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maNV"].Value != null)
                    txbMaNV.Text = dataGridView1.Rows[dong].Cells["maNV"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maSP"].Value != null)
                    txbMaSP.Text = dataGridView1.Rows[dong].Cells["maSP"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["soLuong"].Value != null)
                    txbSoLuong.Text = dataGridView1.Rows[dong].Cells["soLuong"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["giaBan"].Value != null)
                    txbGia.Text = dataGridView1.Rows[dong].Cells["giaBan"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["thanhTien"].Value != null)
                    txbThanhTien.Text = dataGridView1.Rows[dong].Cells["thanhTien"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["thoiGianB"].Value != null)
                    dateBan.Text = dataGridView1.Rows[dong].Cells["thoiGianB"].Value.ToString();
            }
            catch
            { }
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            txbMaHDB.Clear();
            txbMaKH.Clear();
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
                if (khBUS.GetKHBUS(txbMaKH.Text) == null)
                {
                    if (MessageBox.Show("Thêm thông tin khách hàng mới?", "Thông báo!!!",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        fBoSungTTKH fKH = new fBoSungTTKH();
                        fKH.Message = txbMaKH.Text;
                        fKH.ShowDialog();
                    }    
                    else
                    {
                        KH kH = new KH();
                        kH.maKH = txbMaKH.Text;
                        kH.tenKH = "Trống";
                        kH.diachi = "Trống";
                        kH.sdt = "Trống";
                        khBUS.addKHBUS(kH);
                    }    
                }
                if (SPBUS.getSPB(txbMaSP.Text) == null)
                {
                    MessageBox.Show("Trong kho không có sản phẩm mã " + txbMaSP+"!",
                        "Thông báo", MessageBoxButtons.OK);
                }    

                else if (SPBUS.getSPB(txbMaSP.Text).soLuong < int.Parse(txbSoLuong.Text))
                {
                    MessageBox.Show("Trong kho không có đủ số lượng sản phẩm!",
                        "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (SPBUS.getSPB(txbMaSP.Text).soLuong>=int.Parse(txbSoLuong.Text))
                    {
                        try
                        {
                            int soSP = 0 - int.Parse(txbSoLuong.Text);
                            SPBUS.updateSoLuongBUS(txbMaSP.Text, soSP);

                            SP spp = SPBUS.getSPB(txbMaSP.Text);
                            HDB hdb = new HDB();
                            hdb.maHDB = txbMaHDB.Text;
                            hdb.maKH = txbMaKH.Text;
                            hdb.maNV = txbMaNV.Text;
                            hdb.maSP = txbMaSP.Text;
                            hdb.soLuong = int.Parse(txbSoLuong.Text);
                            hdb.giaBan = spp.giaBan;
                            hdb.thanhTien = int.Parse(txbSoLuong.Text) * spp.giaBan;
                            hdb.thoiGianB = DateTime.Parse(dateBan.Text);

                            hdbBUS.addHDBBUS(hdb);
                            dataGridView1.DataSource = hdbBUS.danhSachHDBb();
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
                    else
                    {
                        MessageBox.Show("Hết hàng.",
"Thông báo", MessageBoxButtons.OK);
                    }    

                }    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txbMaHDB.Text == "" || hdbBUS.GetHDBBUS(txbMaHDB.Text) == null)
            {
                MessageBox.Show("Vui Lòng nhập đúng mã hóa đơn bán cần xóa.",
"Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int soSP = hdbBUS.GetHDBBUS(txbMaHDB.Text).soLuong;
                SPBUS.updateSoLuongBUS(hdbBUS.GetHDBBUS(txbMaHDB.Text).maSP, -soSP);
                hdbBUS.removeHDBBUS(hdbBUS.GetHDBBUS(txbMaHDB.Text));

                dataGridView1.DataSource = hdbBUS.danhSachHDBb();
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
            dataGridView1.DataSource = hdbBUS.danhSachHDBb(txbTimKiem.Text);
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
