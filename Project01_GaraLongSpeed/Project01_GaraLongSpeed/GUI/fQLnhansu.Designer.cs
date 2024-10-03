namespace Project01_GaraLongSpeed.GUI
{
    partial class fQLnhansu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLnhansu));
            this.btAdd = new System.Windows.Forms.Button();
            this.grHienthi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btRefesh = new System.Windows.Forms.Button();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.dtgvShow = new System.Windows.Forms.DataGridView();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.grHienthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.AutoSize = true;
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconAdd;
            this.btAdd.Location = new System.Drawing.Point(208, 147);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(97, 44);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Thêm";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grHienthi
            // 
            this.grHienthi.Controls.Add(this.label1);
            this.grHienthi.Controls.Add(this.txbTimKiem);
            this.grHienthi.Controls.Add(this.btnTimKiem);
            this.grHienthi.Controls.Add(this.btSua);
            this.grHienthi.Controls.Add(this.btAdd);
            this.grHienthi.Controls.Add(this.btOut);
            this.grHienthi.Controls.Add(this.txbMaNV);
            this.grHienthi.Controls.Add(this.lbMaNV);
            this.grHienthi.Controls.Add(this.btXoa);
            this.grHienthi.Controls.Add(this.btRefesh);
            this.grHienthi.Controls.Add(this.txbSDT);
            this.grHienthi.Controls.Add(this.txbDiaChi);
            this.grHienthi.Controls.Add(this.txbTenNV);
            this.grHienthi.Controls.Add(this.lbSDT);
            this.grHienthi.Controls.Add(this.lbDiaChi);
            this.grHienthi.Controls.Add(this.lbTenNV);
            this.grHienthi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHienthi.Location = new System.Drawing.Point(11, 155);
            this.grHienthi.Margin = new System.Windows.Forms.Padding(2);
            this.grHienthi.Name = "grHienthi";
            this.grHienthi.Padding = new System.Windows.Forms.Padding(2);
            this.grHienthi.Size = new System.Drawing.Size(672, 204);
            this.grHienthi.TabIndex = 0;
            this.grHienthi.TabStop = false;
            this.grHienthi.Text = "Thông tin chi tiết :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 41;
            this.label1.Text = "Long Speed Gara";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(394, 22);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(185, 29);
            this.txbTimKiem.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconSearch;
            this.btnTimKiem.Location = new System.Drawing.Point(584, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(73, 38);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconUpdate;
            this.btSua.Location = new System.Drawing.Point(309, 147);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(97, 44);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Cập nhật";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btOut
            // 
            this.btOut.AutoSize = true;
            this.btOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.ForeColor = System.Drawing.Color.Black;
            this.btOut.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconBack;
            this.btOut.Location = new System.Drawing.Point(511, 147);
            this.btOut.Margin = new System.Windows.Forms.Padding(2);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(97, 44);
            this.btOut.TabIndex = 10;
            this.btOut.Text = "Thoát";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // txbMaNV
            // 
            this.txbMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNV.Location = new System.Drawing.Point(125, 63);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(150, 26);
            this.txbMaNV.TabIndex = 0;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.Color.Black;
            this.lbMaNV.Location = new System.Drawing.Point(11, 65);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(110, 19);
            this.lbMaNV.TabIndex = 25;
            this.lbMaNV.Text = "Mã nhân viên :";
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconDelete;
            this.btXoa.Location = new System.Drawing.Point(410, 147);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(97, 44);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btRefesh
            // 
            this.btRefesh.AutoSize = true;
            this.btRefesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefesh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRefesh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefesh.ForeColor = System.Drawing.Color.Black;
            this.btRefesh.Image = global::Project01_GaraLongSpeed.Properties.Resources.iconResetTxb;
            this.btRefesh.Location = new System.Drawing.Point(107, 147);
            this.btRefesh.Margin = new System.Windows.Forms.Padding(2);
            this.btRefesh.Name = "btRefesh";
            this.btRefesh.Size = new System.Drawing.Size(97, 44);
            this.btRefesh.TabIndex = 4;
            this.btRefesh.Text = "Mới";
            this.btRefesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRefesh.UseVisualStyleBackColor = false;
            this.btRefesh.Click += new System.EventHandler(this.btRefesh_Click);
            // 
            // txbSDT
            // 
            this.txbSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(429, 96);
            this.txbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(150, 26);
            this.txbSDT.TabIndex = 3;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(429, 63);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(150, 26);
            this.txbDiaChi.TabIndex = 2;
            // 
            // txbTenNV
            // 
            this.txbTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNV.Location = new System.Drawing.Point(125, 96);
            this.txbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(150, 26);
            this.txbTenNV.TabIndex = 1;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Black;
            this.lbSDT.Location = new System.Drawing.Point(322, 98);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(104, 19);
            this.lbSDT.TabIndex = 15;
            this.lbSDT.Text = "Số điện thoại :";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(322, 65);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(65, 19);
            this.lbDiaChi.TabIndex = 13;
            this.lbDiaChi.Text = "Địa chỉ :";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.Black;
            this.lbTenNV.Location = new System.Drawing.Point(11, 98);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(112, 19);
            this.lbTenNV.TabIndex = 7;
            this.lbTenNV.Text = "Tên nhân viên :";
            // 
            // dtgvShow
            // 
            this.dtgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNV,
            this.maNV,
            this.sdt,
            this.diaChi});
            this.dtgvShow.Location = new System.Drawing.Point(11, 13);
            this.dtgvShow.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.RowHeadersWidth = 51;
            this.dtgvShow.RowTemplate.Height = 24;
            this.dtgvShow.Size = new System.Drawing.Size(672, 129);
            this.dtgvShow.TabIndex = 1;
            this.dtgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellClick);
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên nhân viên";
            this.tenNV.Name = "tenNV";
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // btnExport
            // 
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(650, 119);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(33, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // fQLnhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 383);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grHienthi);
            this.Controls.Add(this.dtgvShow);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQLnhansu";
            this.Text = "Quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fQLnhansu_Load);
            this.grHienthi.ResumeLayout(false);
            this.grHienthi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grHienthi;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btRefesh;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.DataGridView dtgvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.Button btnExport;
    }
}