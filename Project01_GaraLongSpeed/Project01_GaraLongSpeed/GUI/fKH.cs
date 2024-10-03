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
    public partial class fKH : Form
    {
        khBUS khBUS = new khBUS();
        HDBbus hdbbus = new HDBbus();
        public fKH()
        {
            InitializeComponent();
        }
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        private void fKH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khBUS.danhSachKHBUS();
            dataGridView1.Columns[4].Visible = false;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[dong].Cells["tenKH"].Value != null)
                    txbTenKH.Text = dataGridView1.Rows[dong].Cells["tenKH"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maKH"].Value != null)
                    txbMaKH.Text = dataGridView1.Rows[dong].Cells["maKH"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["diaChi"].Value != null)
                    txbDiaChi.Text = dataGridView1.Rows[dong].Cells["diaChi"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["sdt"].Value != null)
                    txbSDT.Text = dataGridView1.Rows[dong].Cells["sdt"].Value.ToString();


            }
            catch
            { }
        }      
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbTenKH.Clear();
            txbMaKH.Clear();
            txbDiaChi.Clear();
            txbSDT.Clear();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khBUS.danhSachKHBUS(txbTimKiem.Text);
            dataGridView1.Columns[4].Visible = false;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (khBUS.GetKHBUS(txbMaKH.Text) != null)
            {
                if (txbTenKH.Text == "" || txbMaKH.Text == ""
                    || txbDiaChi.Text == "" || txbSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    KH khN = new KH();
                    khN.maKH = txbMaKH.Text;
                    khN.tenKH = txbTenKH.Text;
                    khN.diachi = txbDiaChi.Text;
                    khN.sdt = txbSDT.Text;

                    try
                    {
                        khBUS.updateKHBUS(khN);


                        dataGridView1.DataSource = khBUS.danhSachKHBUS();
                        dataGridView1.Columns[4].Visible = false;
                        DoRongCotTuDong(1);
                        DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công!",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng không thành công",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật thông tin",
"Thông báo!", MessageBoxButtons.OK);
            }
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
                exportToExcel.xuatEXCEL(dataGridView1, filePath, 4);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbTenKH.Text == "" || txbMaKH.Text == "" || txbDiaChi.Text == "" || txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (hdbbus.danhSachHDBb(txbMaKH.Text) == null)
                {
                    try
                    {
                        khBUS.removeKHBUS(khBUS.GetKHBUS(txbMaKH.Text));
                        dataGridView1.DataSource = khBUS.danhSachKHBUS();
                        dataGridView1.Columns[4].Visible = false;

                        DoRongCotTuDong(1);
                        DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                        MessageBox.Show("Xóa khách hàng thành công!",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Xóa khách hàng không thành công",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng đã trả hàng? Vui lòng xóa thông tin hóa đơn bán trước!",
"Thông báo!", MessageBoxButtons.OK);
                }

            }
        }
    }
}
