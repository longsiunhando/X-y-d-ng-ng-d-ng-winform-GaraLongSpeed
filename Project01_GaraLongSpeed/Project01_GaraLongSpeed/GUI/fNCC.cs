using DocumentFormat.OpenXml.Drawing.Diagrams;
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
    public partial class fNCC : Form
    {
        public fNCC()
        {
            InitializeComponent();
        }
        nccBUS nccBUS = new nccBUS();   
        HDNbus hdnBUS = new HDNbus();
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        private void fNCC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nccBUS.danhSachNCCBUS();
            dataGridView1.Columns[4].Visible = false;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbMaNCC.Clear();
            txbTenNCC.Clear();
            txbDiaChi.Clear();
            txbSDT.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (nccBUS.getNCCBUS(txbMaNCC.Text) != null)
            {
                if (txbTenNCC.Text == "" || txbMaNCC.Text == ""
                    || txbDiaChi.Text == "" || txbSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    NCC nccN = new NCC();
                    nccN.maNCC = txbMaNCC.Text;
                    nccN.tenNCC = txbTenNCC.Text;
                    nccN.diaChi = txbDiaChi.Text;
                    nccN.sdt = txbSDT.Text;

                    try
                    {
                        nccBUS.updateNCCBUS(nccN);

                        dataGridView1.DataSource = nccBUS.danhSachNCCBUS();
                        dataGridView1.Columns[4].Visible = false;
                        DoRongCotTuDong(1);
                        DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công!",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp không thành công",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần cập nhật thông tin",
"Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nccBUS.danhSachNCCBUS(txbTimKiem.Text);
            dataGridView1.Columns[4].Visible = false;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[dong].Cells["tenNCC"].Value != null)
                    txbTenNCC.Text = dataGridView1.Rows[dong].Cells["tenNCC"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maNCC"].Value != null)
                    txbMaNCC.Text = dataGridView1.Rows[dong].Cells["maNCC"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["diaChi"].Value != null)
                    txbDiaChi.Text = dataGridView1.Rows[dong].Cells["diaChi"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["sdt"].Value != null)
                    txbSDT.Text = dataGridView1.Rows[dong].Cells["sdt"].Value.ToString();


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
                exportToExcel.xuatEXCEL(dataGridView1, filePath, 4);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbTenNCC.Text == "" || txbMaNCC.Text == "" || txbDiaChi.Text == "" || txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (hdnBUS.danhSachHDNb(txbMaNCC.Text) == null)
                {
                    try
                    {
                        nccBUS.removeNCCBUS(nccBUS.getNCCBUS(txbMaNCC.Text));
                        dataGridView1.DataSource = nccBUS.danhSachNCCBUS();
                        dataGridView1.Columns[4].Visible = false;

                        DoRongCotTuDong(1);
                        DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                        MessageBox.Show("Xóa nhà cung cấp thành công!",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Xóa nhà cung cấp không thành công",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Vẫn còn sản phẩm đến từ nhà cung cấp này trong cửa hàng",
"Thông báo!", MessageBoxButtons.OK);
                }    

            }
        }
    }
}
