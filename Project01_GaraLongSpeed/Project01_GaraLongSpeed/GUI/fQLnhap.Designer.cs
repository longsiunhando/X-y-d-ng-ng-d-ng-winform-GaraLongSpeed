namespace Project01_GaraLongSpeed.GUI
{
    partial class fQLnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbMaSP = new System.Windows.Forms.TextBox();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateNhap = new System.Windows.Forms.DateTimePicker();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbThanhTien = new System.Windows.Forms.TextBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaNCC = new System.Windows.Forms.TextBox();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMaHDN = new System.Windows.Forms.TextBox();
            this.lbMaHDN = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txbTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 271);
            this.panel1.TabIndex = 0;
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoi.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconResetTxb;
            this.btnMoi.Location = new System.Drawing.Point(112, 217);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(92, 38);
            this.btnMoi.TabIndex = 8;
            this.btnMoi.Text = "Mới";
            this.btnMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconDelete;
            this.btnXoa.Location = new System.Drawing.Point(308, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 38);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconBack;
            this.btnExit.Location = new System.Drawing.Point(697, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.Location = new System.Drawing.Point(406, 217);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(187, 40);
            this.txbTimKiem.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi tiết hóa đơn nhập";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconSearch;
            this.btnTimKiem.Location = new System.Drawing.Point(599, 217);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 38);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbGia);
            this.panel10.Controls.Add(this.lbGia);
            this.panel10.Location = new System.Drawing.Point(450, 129);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(339, 31);
            this.panel10.TabIndex = 6;
            // 
            // txbGia
            // 
            this.txbGia.Location = new System.Drawing.Point(126, 4);
            this.txbGia.Name = "txbGia";
            this.txbGia.ReadOnly = true;
            this.txbGia.Size = new System.Drawing.Size(200, 22);
            this.txbGia.TabIndex = 0;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(3, 9);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(111, 13);
            this.lbGia.TabIndex = 0;
            this.lbGia.Text = "Giá trên 1 đơn vị :";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbSoLuong);
            this.panel9.Controls.Add(this.lbSoLuong);
            this.panel9.Location = new System.Drawing.Point(450, 92);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(339, 31);
            this.panel9.TabIndex = 5;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(126, 4);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(200, 22);
            this.txbSoLuong.TabIndex = 0;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(3, 9);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(65, 13);
            this.lbSoLuong.TabIndex = 0;
            this.lbSoLuong.Text = "Số lượng :";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbMaSP);
            this.panel8.Controls.Add(this.lbMaSP);
            this.panel8.Location = new System.Drawing.Point(450, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(339, 31);
            this.panel8.TabIndex = 4;
            // 
            // txbMaSP
            // 
            this.txbMaSP.Location = new System.Drawing.Point(126, 4);
            this.txbMaSP.Name = "txbMaSP";
            this.txbMaSP.Size = new System.Drawing.Size(200, 22);
            this.txbMaSP.TabIndex = 0;
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(3, 9);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(90, 13);
            this.lbMaSP.TabIndex = 0;
            this.lbMaSP.Text = "Mã sản phẩm :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateNhap);
            this.panel7.Controls.Add(this.lbNgayNhap);
            this.panel7.Location = new System.Drawing.Point(51, 166);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(339, 31);
            this.panel7.TabIndex = 3;
            // 
            // dateNhap
            // 
            this.dateNhap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNhap.Location = new System.Drawing.Point(126, 3);
            this.dateNhap.Name = "dateNhap";
            this.dateNhap.Size = new System.Drawing.Size(200, 24);
            this.dateNhap.TabIndex = 0;
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhap.Location = new System.Drawing.Point(3, 9);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(76, 13);
            this.lbNgayNhap.TabIndex = 0;
            this.lbNgayNhap.Text = "Ngày nhập :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconAdd;
            this.btnAdd.Location = new System.Drawing.Point(210, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbThanhTien);
            this.panel5.Controls.Add(this.lbThanhTien);
            this.panel5.Location = new System.Drawing.Point(450, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 31);
            this.panel5.TabIndex = 7;
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.Location = new System.Drawing.Point(126, 6);
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.ReadOnly = true;
            this.txbThanhTien.Size = new System.Drawing.Size(200, 22);
            this.txbThanhTien.TabIndex = 0;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(3, 9);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(114, 13);
            this.lbThanhTien.TabIndex = 0;
            this.lbThanhTien.Text = "Thành tiền (VNĐ) :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMaNCC);
            this.panel3.Controls.Add(this.lbMaNCC);
            this.panel3.Location = new System.Drawing.Point(51, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 31);
            this.panel3.TabIndex = 1;
            // 
            // txbMaNCC
            // 
            this.txbMaNCC.Location = new System.Drawing.Point(126, 6);
            this.txbMaNCC.Name = "txbMaNCC";
            this.txbMaNCC.Size = new System.Drawing.Size(200, 22);
            this.txbMaNCC.TabIndex = 0;
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNCC.Location = new System.Drawing.Point(3, 9);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(114, 13);
            this.lbMaNCC.TabIndex = 0;
            this.lbMaNCC.Text = "Mã nhà cung cấp :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMaNV);
            this.panel4.Controls.Add(this.lbMaNV);
            this.panel4.Location = new System.Drawing.Point(51, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 31);
            this.panel4.TabIndex = 2;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(126, 4);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(200, 22);
            this.txbMaNV.TabIndex = 0;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(3, 9);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(124, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên nhận :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMaHDN);
            this.panel2.Controls.Add(this.lbMaHDN);
            this.panel2.Location = new System.Drawing.Point(51, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 31);
            this.panel2.TabIndex = 0;
            // 
            // txbMaHDN
            // 
            this.txbMaHDN.Location = new System.Drawing.Point(126, 4);
            this.txbMaHDN.Name = "txbMaHDN";
            this.txbMaHDN.Size = new System.Drawing.Size(200, 22);
            this.txbMaHDN.TabIndex = 0;
            // 
            // lbMaHDN
            // 
            this.lbMaHDN.AutoSize = true;
            this.lbMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHDN.Location = new System.Drawing.Point(3, 9);
            this.lbMaHDN.Name = "lbMaHDN";
            this.lbMaHDN.Size = new System.Drawing.Size(115, 13);
            this.lbMaHDN.TabIndex = 0;
            this.lbMaHDN.Text = "Mã hóa đơn nhập :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDN,
            this.maNCC,
            this.maNV,
            this.maSP,
            this.soLuong,
            this.giaNhap,
            this.thanhTien,
            this.thoiGianN});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 213);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maHDN
            // 
            this.maHDN.DataPropertyName = "maHDN";
            this.maHDN.HeaderText = "Mã hóa đơn nhập";
            this.maHDN.Name = "maHDN";
            // 
            // maNCC
            // 
            this.maNCC.DataPropertyName = "maNCC";
            this.maNCC.HeaderText = "Mã nhà cung cấp";
            this.maNCC.Name = "maNCC";
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            // 
            // maSP
            // 
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã sản phẩm";
            this.maSP.Name = "maSP";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // giaNhap
            // 
            this.giaNhap.DataPropertyName = "giaNhap";
            this.giaNhap.HeaderText = "Giá nhập";
            this.giaNhap.Name = "giaNhap";
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            // 
            // thoiGianN
            // 
            this.thoiGianN.DataPropertyName = "thoiGianN";
            this.thoiGianN.HeaderText = "Thời gian nhập";
            this.thoiGianN.Name = "thoiGianN";
            // 
            // btnExport
            // 
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(824, 247);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(33, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // fQLnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 570);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQLnhap";
            this.Text = "Quản lý hóa đơn nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fQLnhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbThanhTien;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMaNCC;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMaHDN;
        private System.Windows.Forms.Label lbMaHDN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateNhap;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbMaSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianN;
        private System.Windows.Forms.Button btnExport;
    }
}