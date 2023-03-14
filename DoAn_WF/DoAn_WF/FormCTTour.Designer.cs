
namespace DoAn_WF
{
    partial class FormCTTour
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaCTTour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiaDiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoaiPT = new System.Windows.Forms.ComboBox();
            this.dgvCTTour = new System.Windows.Forms.DataGridView();
            this.colMaCTTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyCTTour = new System.Windows.Forms.Button();
            this.btnXoaCTTour = new System.Windows.Forms.Button();
            this.btnSuaCTTour = new System.Windows.Forms.Button();
            this.btnThemCTTour = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbTour = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ CHI TIẾT TOUR";
            // 
            // txtGiaTour
            // 
            this.txtGiaTour.Location = new System.Drawing.Point(223, 172);
            this.txtGiaTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTour.Name = "txtGiaTour";
            this.txtGiaTour.Size = new System.Drawing.Size(262, 22);
            this.txtGiaTour.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giá Tour";
            // 
            // txtMaCTTour
            // 
            this.txtMaCTTour.Location = new System.Drawing.Point(223, 79);
            this.txtMaCTTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCTTour.Name = "txtMaCTTour";
            this.txtMaCTTour.Size = new System.Drawing.Size(134, 22);
            this.txtMaCTTour.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Chi Tiết Tour";
            // 
            // cmbDiaDiem
            // 
            this.cmbDiaDiem.FormattingEnabled = true;
            this.cmbDiaDiem.Location = new System.Drawing.Point(703, 168);
            this.cmbDiaDiem.Name = "cmbDiaDiem";
            this.cmbDiaDiem.Size = new System.Drawing.Size(342, 24);
            this.cmbDiaDiem.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Địa điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Phương Tiện";
            // 
            // cmbLoaiPT
            // 
            this.cmbLoaiPT.FormattingEnabled = true;
            this.cmbLoaiPT.Location = new System.Drawing.Point(703, 130);
            this.cmbLoaiPT.Name = "cmbLoaiPT";
            this.cmbLoaiPT.Size = new System.Drawing.Size(342, 24);
            this.cmbLoaiPT.TabIndex = 33;
            // 
            // dgvCTTour
            // 
            this.dgvCTTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCTTour,
            this.colMaTour,
            this.colTenTour,
            this.colGiaTour,
            this.colMaKH,
            this.colTenKH,
            this.colTenPT,
            this.colTenDD});
            this.dgvCTTour.Location = new System.Drawing.Point(2, 255);
            this.dgvCTTour.Name = "dgvCTTour";
            this.dgvCTTour.RowHeadersWidth = 51;
            this.dgvCTTour.RowTemplate.Height = 24;
            this.dgvCTTour.Size = new System.Drawing.Size(1086, 183);
            this.dgvCTTour.TabIndex = 35;
            this.dgvCTTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTTour_CellClick);
            // 
            // colMaCTTour
            // 
            this.colMaCTTour.HeaderText = "Mã Chi Tiết Tour";
            this.colMaCTTour.MinimumWidth = 6;
            this.colMaCTTour.Name = "colMaCTTour";
            this.colMaCTTour.Width = 125;
            // 
            // colMaTour
            // 
            this.colMaTour.HeaderText = "Mã Tour";
            this.colMaTour.MinimumWidth = 6;
            this.colMaTour.Name = "colMaTour";
            this.colMaTour.Width = 125;
            // 
            // colTenTour
            // 
            this.colTenTour.HeaderText = "Tên Tour";
            this.colTenTour.MinimumWidth = 6;
            this.colTenTour.Name = "colTenTour";
            this.colTenTour.Width = 125;
            // 
            // colGiaTour
            // 
            this.colGiaTour.HeaderText = "Giá Tour";
            this.colGiaTour.MinimumWidth = 6;
            this.colGiaTour.Name = "colGiaTour";
            this.colGiaTour.Width = 125;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Width = 125;
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Tên Khách Hàng";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Width = 125;
            // 
            // colTenPT
            // 
            this.colTenPT.HeaderText = "Tên phương tiện";
            this.colTenPT.MinimumWidth = 6;
            this.colTenPT.Name = "colTenPT";
            this.colTenPT.Width = 125;
            // 
            // colTenDD
            // 
            this.colTenDD.HeaderText = "Tên địa điểm";
            this.colTenDD.MinimumWidth = 6;
            this.colTenDD.Name = "colTenDD";
            this.colTenDD.Width = 125;
            // 
            // btnHuyCTTour
            // 
            this.btnHuyCTTour.Location = new System.Drawing.Point(607, 201);
            this.btnHuyCTTour.Name = "btnHuyCTTour";
            this.btnHuyCTTour.Size = new System.Drawing.Size(95, 36);
            this.btnHuyCTTour.TabIndex = 39;
            this.btnHuyCTTour.Text = "Hủy";
            this.btnHuyCTTour.UseVisualStyleBackColor = true;
            this.btnHuyCTTour.Click += new System.EventHandler(this.btnHuyTour_Click);
            // 
            // btnXoaCTTour
            // 
            this.btnXoaCTTour.Location = new System.Drawing.Point(443, 201);
            this.btnXoaCTTour.Name = "btnXoaCTTour";
            this.btnXoaCTTour.Size = new System.Drawing.Size(95, 36);
            this.btnXoaCTTour.TabIndex = 38;
            this.btnXoaCTTour.Text = "Xóa";
            this.btnXoaCTTour.UseVisualStyleBackColor = true;
            this.btnXoaCTTour.Click += new System.EventHandler(this.btnXoaTour_Click);
            // 
            // btnSuaCTTour
            // 
            this.btnSuaCTTour.Location = new System.Drawing.Point(276, 201);
            this.btnSuaCTTour.Name = "btnSuaCTTour";
            this.btnSuaCTTour.Size = new System.Drawing.Size(95, 36);
            this.btnSuaCTTour.TabIndex = 37;
            this.btnSuaCTTour.Text = "Sửa";
            this.btnSuaCTTour.UseVisualStyleBackColor = true;
            this.btnSuaCTTour.Click += new System.EventHandler(this.btnSuaTour_Click);
            // 
            // btnThemCTTour
            // 
            this.btnThemCTTour.Location = new System.Drawing.Point(109, 201);
            this.btnThemCTTour.Name = "btnThemCTTour";
            this.btnThemCTTour.Size = new System.Drawing.Size(95, 36);
            this.btnThemCTTour.TabIndex = 36;
            this.btnThemCTTour.Text = "Thêm";
            this.btnThemCTTour.UseVisualStyleBackColor = true;
            this.btnThemCTTour.Click += new System.EventHandler(this.btnThemCTTour_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 26);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mã Khách Hàng";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(704, 84);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(341, 24);
            this.cmbKhachHang.TabIndex = 40;
            // 
            // cmbTour
            // 
            this.cmbTour.FormattingEnabled = true;
            this.cmbTour.Location = new System.Drawing.Point(221, 130);
            this.cmbTour.Name = "cmbTour";
            this.cmbTour.Size = new System.Drawing.Size(264, 24);
            this.cmbTour.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(796, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(910, 445);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(165, 22);
            this.txtTongTien.TabIndex = 44;
            // 
            // FormCTTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_WF.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.btnHuyCTTour);
            this.Controls.Add(this.btnXoaCTTour);
            this.Controls.Add(this.btnSuaCTTour);
            this.Controls.Add(this.btnThemCTTour);
            this.Controls.Add(this.dgvCTTour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLoaiPT);
            this.Controls.Add(this.cmbDiaDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaTour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaCTTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCTTour";
            this.Text = "FormCTTour";
            this.Load += new System.EventHandler(this.FormCTTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaCTTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDiaDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoaiPT;
        private System.Windows.Forms.DataGridView dgvCTTour;
        private System.Windows.Forms.Button btnHuyCTTour;
        private System.Windows.Forms.Button btnXoaCTTour;
        private System.Windows.Forms.Button btnSuaCTTour;
        private System.Windows.Forms.Button btnThemCTTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCTTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}