namespace Project01_GaraLongSpeed.GUI
{
    partial class fChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangePass));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPassAgain = new System.Windows.Forms.TextBox();
            this.lbPassAgain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.btnConfirmPass = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lbOldPass = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPassAgain);
            this.panel2.Controls.Add(this.lbPassAgain);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 36);
            this.panel2.TabIndex = 2;
            // 
            // txbPassAgain
            // 
            this.txbPassAgain.Location = new System.Drawing.Point(139, 8);
            this.txbPassAgain.Name = "txbPassAgain";
            this.txbPassAgain.Size = new System.Drawing.Size(235, 20);
            this.txbPassAgain.TabIndex = 0;
            this.txbPassAgain.UseSystemPasswordChar = true;
            // 
            // lbPassAgain
            // 
            this.lbPassAgain.AutoSize = true;
            this.lbPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassAgain.Location = new System.Drawing.Point(3, 9);
            this.lbPassAgain.Name = "lbPassAgain";
            this.lbPassAgain.Size = new System.Drawing.Size(136, 15);
            this.lbPassAgain.TabIndex = 0;
            this.lbPassAgain.Text = "Nhập lại mật khẩu : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbNewPass);
            this.panel1.Controls.Add(this.lbNewPass);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 36);
            this.panel1.TabIndex = 1;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(139, 8);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(235, 20);
            this.txbNewPass.TabIndex = 0;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.Location = new System.Drawing.Point(3, 9);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(106, 15);
            this.lbNewPass.TabIndex = 0;
            this.lbNewPass.Text = "Mật khẩu mới : ";
            // 
            // btnConfirmPass
            // 
            this.btnConfirmPass.Location = new System.Drawing.Point(183, 138);
            this.btnConfirmPass.Name = "btnConfirmPass";
            this.btnConfirmPass.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmPass.TabIndex = 3;
            this.btnConfirmPass.Text = "Xác nhận";
            this.btnConfirmPass.UseVisualStyleBackColor = true;
            this.btnConfirmPass.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbPass);
            this.panel4.Controls.Add(this.lbOldPass);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 36);
            this.panel4.TabIndex = 0;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(139, 8);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(235, 20);
            this.txbPass.TabIndex = 0;
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // lbOldPass
            // 
            this.lbOldPass.AutoSize = true;
            this.lbOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPass.Location = new System.Drawing.Point(3, 9);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(130, 15);
            this.lbOldPass.TabIndex = 0;
            this.lbOldPass.Text = "Mật khẩu hiện tại : ";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(289, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(411, 173);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfirmPass);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fChangePass";
            this.Text = "Đổi mật khẩu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPassAgain;
        private System.Windows.Forms.Label lbPassAgain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Button btnConfirmPass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label lbOldPass;
    }
}