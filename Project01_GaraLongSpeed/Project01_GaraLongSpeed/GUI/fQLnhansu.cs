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
    public partial class fQLnhansu : Form
    {
        public fQLnhansu()
        {
            InitializeComponent();
        }
        NVBUS NVBUS = new NVBUS();
        public void DoRongCotTuDong(int CotIndex)
        {
            dtgvShow.AllowUserToResizeColumns = true;
            dtgvShow.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvShow.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        private void fQLnhansu_Load(object sender, EventArgs e)
        {
            dtgvShow.DataSource = NVBUS.listNV();
            dtgvShow.Columns[4].Visible = false;
            dtgvShow.Columns[5].Visible = false;


            DoRongCotTuDong(1);
            DoRongCotTuDong(dtgvShow.ColumnCount - 1);
        }
        private void btRefesh_Click(object sender, EventArgs e)
        {
            txbTenNV.Clear();
            txbMaNV.Clear();
            txbDiaChi.Clear();
            txbSDT.Clear();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {

            if (txbTenNV.Text == "" || txbMaNV.Text == "" || txbDiaChi.Text == ""
                || txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                NV nvN = new NV();
                nvN.tenNV = txbTenNV.Text;
                nvN.maNV = txbMaNV.Text;
                nvN.diaChi = txbDiaChi.Text;
                nvN.sdt=txbSDT.Text;


                try
                {
                    NVBUS.addNVBUS(nvN);
                    dtgvShow.DataSource = NVBUS.listNV();
                    dtgvShow.Columns[4].Visible = false;
                    dtgvShow.Columns[5].Visible = false;

                    DoRongCotTuDong(1);
                    DoRongCotTuDong(dtgvShow.ColumnCount - 1);
                    MessageBox.Show("Thêm nhân sự thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm nhân sự không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txbTenNV.Text == "" || txbMaNV.Text == "" || txbDiaChi.Text == ""
    || txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                NV nvN = new NV();
                nvN.tenNV = txbTenNV.Text;
                nvN.maNV = txbMaNV.Text;
                nvN.diaChi = txbDiaChi.Text;
                nvN.sdt = txbSDT.Text;


                try
                {
                    NVBUS.updateNVBUS(nvN);
                    dtgvShow.DataSource = NVBUS.listNV();
                    dtgvShow.Columns[4].Visible = false;
                    dtgvShow.Columns[5].Visible = false;

                    DoRongCotTuDong(1);
                    DoRongCotTuDong(dtgvShow.ColumnCount - 1);
                    MessageBox.Show("Cập nhật thông tin thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thông tin không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txbTenNV.Text == "" || txbMaNV.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập tên hoặc mã nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    NVBUS.removeNVBUS(NVBUS.GetNVBUS(txbMaNV.Text));
                    dtgvShow.DataSource = NVBUS.listNV();
                    dtgvShow.DataSource = NVBUS.listNV();
                    dtgvShow.Columns[4].Visible = false;
                    dtgvShow.Columns[5].Visible = false;

                    DoRongCotTuDong(1);
                    DoRongCotTuDong(dtgvShow.ColumnCount - 1);
                    MessageBox.Show("Xóa nhân sự thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Xóa nhân sự không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvShow.DataSource=NVBUS.listNV(txbTimKiem.Text);
            dtgvShow.Columns[4].Visible = false;
            dtgvShow.Columns[5].Visible = false;

            DoRongCotTuDong(1);
            DoRongCotTuDong(dtgvShow.ColumnCount - 1);
        }

        private void dtgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = dtgvShow.CurrentCell.RowIndex;
                if (dtgvShow.Rows[dong].Cells["tenNV"].Value != null)
                    txbTenNV.Text = dtgvShow.Rows[dong].Cells["tenNV"].Value.ToString();
                if (dtgvShow.Rows[dong].Cells["maNV"].Value != null)
                    txbMaNV.Text = dtgvShow.Rows[dong].Cells["maNV"].Value.ToString();
                if (dtgvShow.Rows[dong].Cells["sdt"].Value != null)
                    txbSDT.Text = dtgvShow.Rows[dong].Cells["sdt"].Value.ToString();
                if (dtgvShow.Rows[dong].Cells["diaChi"].Value != null)
                    txbDiaChi.Text = dtgvShow.Rows[dong].Cells["diaChi"].Value.ToString();

            }
            catch
            { }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel exportToExcel = new ExportToExcel();
                exportToExcel.xuatEXCEL(dtgvShow, filePath,3);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }
    }
}
