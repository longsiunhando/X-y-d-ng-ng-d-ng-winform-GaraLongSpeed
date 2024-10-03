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
    public partial class fQLtaikhoan : Form
    {
        public fQLtaikhoan()
        {
            InitializeComponent();
        }

        accountBUS accBUS = new accountBUS();

        private void fQLtaikhoan_Load(object sender, EventArgs e)
        {
            dtgvAccount.DataSource = accBUS.listAccB();
        }
        public void DoRongCotTuDong(int CotIndex)
        {
            dtgvAccount.AllowUserToResizeColumns = true;
            dtgvAccount.Columns[CotIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvAccount.Columns[CotIndex].Resizable = DataGridViewTriState.True;
        }
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = dtgvAccount.CurrentCell.RowIndex;
                if (dtgvAccount.Rows[dong].Cells["username"].Value != null)
                    txbUsername.Text = dtgvAccount.Rows[dong].Cells["username"].Value.ToString();
                if (dtgvAccount.Rows[dong].Cells["displayname"].Value != null)
                    txbDisplayName.Text = dtgvAccount.Rows[dong].Cells["displayname"].Value.ToString();
                if (dtgvAccount.Rows[dong].Cells["pass"].Value != null)
                    txbPass.Text = dtgvAccount.Rows[dong].Cells["pass"].Value.ToString();
                if (dtgvAccount.Rows[dong].Cells["sdt"].Value != null)
                    txbSĐT.Text = dtgvAccount.Rows[dong].Cells["sdt"].Value.ToString();
                if (dtgvAccount.Rows[dong].Cells["email"].Value != null)
                    txbEmail.Text = dtgvAccount.Rows[dong].Cells["email"].Value.ToString();
                if (dtgvAccount.Rows[dong].Cells["diachi"].Value != null)
                    txbDiaChi.Text = dtgvAccount.Rows[dong].Cells["diachi"].Value.ToString();
                if (dtgvAccount.Rows[dong].Cells["type"].Value != null)
                    txbType.Text = dtgvAccount.Rows[dong].Cells["type"].Value.ToString();

            }
            catch
            { }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvAccount.DataSource = accBUS.listAccB(txbTimKiem.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "" || txbPass.Text == "" || txbDisplayName.Text == ""
                || txbSĐT.Text == "" || txbEmail.Text == "" || txbDiaChi.Text == "" || txbType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                account acc = new account();
                acc.username = txbUsername.Text;
                acc.pass = txbPass.Text;
                acc.displayname = txbDisplayName.Text;
                acc.email = txbEmail.Text;
                acc.sdt = txbSĐT.Text;
                acc.diaChi = txbDiaChi.Text;
                acc.type = int.Parse(txbType.Text);


                try
                {
                    accBUS.addAccB(acc);
                    dtgvAccount.DataSource = accBUS.listAccB();
                    MessageBox.Show("Thêm tài khoản thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm tài khoản không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập của tài khoản cần xóa.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    accBUS.removeAccB(accBUS.getAccB(txbUsername.Text));
                    dtgvAccount.DataSource = accBUS.listAccB();
                    MessageBox.Show("Xóa tài khoản thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Xóa tài khoản không thành công",
        "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "" || txbPass.Text == "" || txbDisplayName.Text == ""
    || txbSĐT.Text == "" || txbEmail.Text == "" || txbDiaChi.Text == "" || txbType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                account accN = new account();
                accN.username = txbUsername.Text;
                accN.pass = txbPass.Text;
                accN.displayname = txbDisplayName.Text;
                accN.email = txbEmail.Text;
                accN.sdt = txbSĐT.Text;
                accN.diaChi = txbDiaChi.Text;
                accN.type = int.Parse(txbType.Text);


                try
                {
                    accBUS.updateAccBUS(accN);
                    dtgvAccount.DataSource = accBUS.listAccB();
                    MessageBox.Show("Cập nhật thành công!",
        "Thông báo!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Cập nhật không thành công",
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
                exportToExcel.xuatEXCEL(dtgvAccount, filePath,7);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }
    }
}
