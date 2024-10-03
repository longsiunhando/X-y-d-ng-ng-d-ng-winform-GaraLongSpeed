using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Office.Interop.Word;
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
    public partial class fQLloai : Form
    {
        public fQLloai()
        {
            InitializeComponent();
        }
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        loaiSPBUS loaiSPBUS = new loaiSPBUS();
        SPBUS spBUS = new SPBUS();
        private void fQLloai_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loaiSPBUS.listLoaiSPBUS();
            dataGridView1.Columns[2].Visible = false;

            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[dong].Cells["tenLoai"].Value != null)
                    txbTenLoai.Text = dataGridView1.Rows[dong].Cells["tenLoai"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maLoai"].Value != null)
                    txbMaLoai.Text = dataGridView1.Rows[dong].Cells["maLoai"].Value.ToString();
            }
            catch
            { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbTenLoai.Clear();
            txbMaLoai.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)

        {

            if (txbTenLoai.Text == "" || txbMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    loaiSP loaiSPN = new loaiSP();
                    loaiSPN.tenLoai = txbTenLoai.Text;
                    loaiSPN.maLoai = txbMaLoai.Text;
                    
                    loaiSPBUS.addLoaiSP(loaiSPN);
                    dataGridView1.DataSource = loaiSPBUS.listLoaiSPBUS();
                    DoRongCotTuDong(1);
                    DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                    dataGridView1.Columns[2].Visible = false;
                    MessageBox.Show("Thêm loại sản phẩm thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm loại sản phẩm không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (loaiSPBUS.getLoaiSPBUS(txbMaLoai.Text) != null)
            {
                if (txbTenLoai.Text == "" || txbMaLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    loaiSP loaiSPN = new loaiSP();
                    loaiSPN.tenLoai = txbTenLoai.Text;
                    loaiSPN.maLoai = txbMaLoai.Text;

                    try
                    {
                        loaiSPBUS.updateLSPBUS(loaiSPN);
                        dataGridView1.DataSource = loaiSPBUS.listLoaiSPBUS();
                        DoRongCotTuDong(1);
                        DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                        dataGridView1.Columns[2].Visible = false;
                        MessageBox.Show("Cập nhật thông tin loại sản phẩm thành công!",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật thông tin loại sản phẩm không thành công",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mã loại sản phẩm cần cập nhật thông tin",
"Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbTenLoai.Text == "" || txbMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (txbMaLoai.Text != "")
                    {
                        if (spBUS.listSPB(txbMaLoai.Text) == null)
                        {
                            loaiSPBUS.removeLoaiSPBUS(loaiSPBUS.getLoaiSPBUS(txbMaLoai.Text));
                            dataGridView1.DataSource = loaiSPBUS.listLoaiSPBUS();
                            DoRongCotTuDong(1);
                            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                            dataGridView1.Columns[2].Visible = false;


                            MessageBox.Show("Xóa loại sản phẩm thành công!",
                                "Thông báo!", MessageBoxButtons.OK);
                        }    

                        else
                        {
                            MessageBox.Show("Vẫn còn các sản phẩm thuộc loại này! Vui lòng xóa " +
                                "hoặc thay đổi loại của các sản phẩm đó!","Thông báo!", MessageBoxButtons.OK);
                        }    

                    }
                    else if (txbMaLoai.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa!",
                            "Thông báo!", MessageBoxButtons.OK);
                    }

                }
                catch
                {
                    MessageBox.Show("Xóa sản phẩm không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
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
                exportToExcel.xuatEXCEL(dataGridView1, filePath,2);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                dataGridView1.DataSource = loaiSPBUS.listLoaiSPBUS(textBox2.Text);
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                dataGridView1.Columns[2].Visible = false;
            }
            else
            {
                MessageBox.Show("Nhập thông tin loại sản phẩm.",
                "Thông báo!", MessageBoxButtons.OK);
            }
        }
    }
}
