using DocumentFormat.OpenXml.Office.CustomUI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project01_GaraLongSpeed.GUI
{
    public partial class fQLHH : Form
    {
        public fQLHH()
        {
            InitializeComponent();
        }

        private string maLoai;
        public string Message
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        SPBUS spBUS=new SPBUS();
        loaiSPBUS loaiSPBUS= new loaiSPBUS();
        List<SP> listSPs;


        private void fQLHH_Load(object sender, EventArgs e)
        {

            if (maLoai == "all")
            {
                dataGridView1.DataSource = spBUS.listSPB();
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);

            }
            else if (maLoai == "XM")
            {
                dataGridView1.DataSource = spBUS.listSPB("XM");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }

            else if (maLoai == "AO")
            {
                dataGridView1.DataSource = spBUS.listSPB("AO");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "DL")
            {
                dataGridView1.DataSource = spBUS.listSPB("DL");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "BCL")
            {
                dataGridView1.DataSource = spBUS.listSPB("BCL");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "BL")
            {
                dataGridView1.DataSource = spBUS.listSPB("BL");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "LX")
            {
                dataGridView1.DataSource = spBUS.listSPB("LX");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "PGS")
            {
                dataGridView1.DataSource = spBUS.listSPB("PGS");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "MB")
            {
                dataGridView1.DataSource = spBUS.listSPB("MB");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "GX")
            {
                dataGridView1.DataSource = spBUS.listSPB("GX");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "XN")
            {
                dataGridView1.DataSource = spBUS.listSPB("XN");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "CP")
            {
                dataGridView1.DataSource = spBUS.listSPB("CP");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "YX")
            {
                dataGridView1.DataSource = spBUS.listSPB("YX");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
            else if (maLoai == "SPK")
            {
                dataGridView1.DataSource = spBUS.listSPB("SPK");
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[dong].Cells["tenSP"].Value != null)
                    txbTenSP.Text = dataGridView1.Rows[dong].Cells["tenSP"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maSP"].Value != null)
                    txbMaSP.Text = dataGridView1.Rows[dong].Cells["maSP"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["soLuong"].Value != null)
                    txbSoLuong.Text = dataGridView1.Rows[dong].Cells["soLuong"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["giaNhap"].Value != null)
                    txbGiaN.Text = dataGridView1.Rows[dong].Cells["giaNhap"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["giaBan"].Value != null)
                    txbGiaB.Text = dataGridView1.Rows[dong].Cells["giaBan"].Value.ToString();
                if (dataGridView1.Rows[dong].Cells["maLoai"].Value != null)
                {
                    cboLoaiSP.Text = (loaiSPBUS.getLoaiSPBUS(dataGridView1.Rows[dong].
                        Cells["maLoai"].Value.ToString())).tenLoai;
                }    


            }
            catch
            { }
        }

        private void cboLoaiSP_MouseClick(object sender, MouseEventArgs e)
        {
            List<loaiSP> listLoaiSP;
            listLoaiSP = loaiSPBUS.listLoaiSPBUS();
            cboLoaiSP.DataSource = listLoaiSP;
            cboLoaiSP.DisplayMember = "tenLoai";
            cboLoaiSP.ValueMember = "maLoai";
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSPs = spBUS.listSPB(cboLoaiSP.SelectedValue.ToString());
            dataGridView1.DataSource = listSPs;
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbTenSP.Clear();
            txbMaSP.Clear();
            txbGiaN.Clear();
            txbGiaB.Clear();
            txbSoLuong.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbSoLuong.Text = "0";

            if (txbTenSP.Text == "" || txbMaSP.Text == ""
                || txbGiaB.Text == "" || txbGiaN.Text == "" || cboLoaiSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    SP spN = new SP();
                    spN.tenSP = txbTenSP.Text;
                    spN.maSP = txbMaSP.Text;
                    spN.soLuong = 0;
                    spN.giaNhap = float.Parse(txbGiaN.Text);
                    spN.giaBan = float.Parse(txbGiaB.Text);
                    spN.maLoai = cboLoaiSP.SelectedValue.ToString();



                    cboLoaiSP.SelectedItem = spN.maLoai;
                    spBUS.addSPB(spN);
                    listSPs.Add(spN);
                    dataGridView1.DataSource = spBUS.listSPB(cboLoaiSP.SelectedValue.ToString());
                    DoRongCotTuDong(1);
                    DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    MessageBox.Show("Thêm sản phẩm thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm sản phẩm không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (spBUS.getSPB(txbMaSP.Text) != null)
            {
                if (txbTenSP.Text == "" || txbMaSP.Text == ""
    || txbGiaB.Text == "" || txbGiaN.Text == "" || cboLoaiSP.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    SP spN = new SP();
                    spN.tenSP = txbTenSP.Text;
                    spN.maSP = txbMaSP.Text;
                    spN.soLuong = spBUS.getSPB(txbMaSP.Text).soLuong;
                    spN.giaNhap = float.Parse(txbGiaN.Text);
                    spN.giaBan = float.Parse(txbGiaB.Text);
                    spN.maLoai = cboLoaiSP.SelectedValue.ToString();
                    try
                    {
                        spBUS.updateSPB(spN);

                        dataGridView1.DataSource = spBUS.listSPB(cboLoaiSP.SelectedValue.ToString());
                        DoRongCotTuDong(1);
                        DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                        MessageBox.Show("Cập nhật thông tin sản phẩm thành công!",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật thông tin sản phẩm không thành công",
            "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mã sản phẩm cần cập nhật thông tin",
"Thông báo!", MessageBoxButtons.OK);
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbTenSP.Text == "" || txbMaSP.Text == "" || txbSoLuong.Text == ""
|| txbGiaB.Text == "" || txbGiaN.Text == "" || cboLoaiSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (txbMaSP.Text != "")
                    {
                        spBUS.removeSPB(spBUS.getSPB(txbMaSP.Text));
                        //dataGridView1.DataSource = spBUS.listSPB(cboLoaiSP.SelectedValue.ToString());
                        cboLoaiSP_SelectedIndexChanged(sender, e);
                        MessageBox.Show("Xóa sản phẩm thành công!",
                            "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (txbMaSP.Text == "")
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SPBUS spBUS = new SPBUS();
            if (textBox2.Text!="")
            {
                listSPs = spBUS.listSPB(textBox2.Text).ToList();
                dataGridView1.DataSource=listSPs.ToList();
                DoRongCotTuDong(1);
                DoRongCotTuDong(dataGridView1.ColumnCount - 1);
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }   
            else
            {
                MessageBox.Show("Nhập thông tin sản phẩm.",
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
                exportToExcel.xuatEXCEL(dataGridView1, filePath,5);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }
    }
}
