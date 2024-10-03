using Project01_GaraLongSpeed.BUS;
using Project01_GaraLongSpeed.Export_file;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Project01_GaraLongSpeed.GUI
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }
        public void DoRongCotTuDong(int CotIndex)
        {
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        HDNbus hdnBUS = new HDNbus();
        HDBbus hdbBUS = new HDBbus();

        public float tinhTien(DataGridView dt)
        {
            int sc = dt.Rows.Count + 1;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells["thanhTien"].Value.ToString());
            }
            return thanhtien;
        }
        private void fThongKe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdnBUS.danhSachHDNb();
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView2.DataSource = hdbBUS.danhSachHDBb();
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView2.ColumnCount - 1);
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;


            txbTongChi.Text = tinhTien(dataGridView1).ToString();

            txbTongThu.Text = tinhTien(dataGridView2).ToString();

        }

        private void btnAllHDB_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = hdbBUS.danhSachHDBb();
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView2.ColumnCount - 1);
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
        }

        private void btnAllHDN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdnBUS.danhSachHDNb();
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void format(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";

        }
        private void btnTKnhap_Click(object sender, EventArgs e)
        {
            format(dateTKstartN);
            format(dateTKendN);
            DateTime ngayBatDau = dateTKstartN.Value;
            DateTime ngayKetThuc = dateTKendN.Value;


            dataGridView1.DataSource = hdnBUS.danhSachHDNtheoTGbus(ngayBatDau, ngayKetThuc);
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView1.ColumnCount - 1);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            txbGThdn.Text = tinhTien(dataGridView1).ToString();

        }

        private void btnTKban_Click(object sender, EventArgs e)
        {
            format(dateTKstartB);
            format(dateTKendB);
            DateTime ngayBatDau = dateTKstartB.Value;
            DateTime ngayKetThuc = dateTKendB.Value;


            dataGridView2.DataSource = hdbBUS.danhSachHDBtheoTGbus(ngayBatDau, ngayKetThuc);
            DoRongCotTuDong(1);
            DoRongCotTuDong(dataGridView2.ColumnCount - 1);
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            txbGThdb.Text = tinhTien(dataGridView2).ToString();
        }

        private void btnExport1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel exportToExcel = new ExportToExcel();
                exportToExcel.xuatEXCEL(dataGridView2, filePath, 8);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel exportToExcel = new ExportToExcel();
                exportToExcel.xuatEXCEL(dataGridView1, filePath, 8);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }

    }
}