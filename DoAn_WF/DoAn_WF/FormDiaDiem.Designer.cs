
namespace DoAn_WF
{
    partial class FormDiaDiem
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
            this.dgvDiaDiem = new System.Windows.Forms.DataGridView();
            this.colMaDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyBoDD = new System.Windows.Forms.Button();
            this.btnSuaDD = new System.Windows.Forms.Button();
            this.btnXoaDD = new System.Windows.Forms.Button();
            this.btnThemDD = new System.Windows.Forms.Button();
            this.txtTenDiaDiem = new System.Windows.Forms.TextBox();
            this.txtMaDiaDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiaDiem
            // 
            this.dgvDiaDiem.AllowUserToAddRows = false;
            this.dgvDiaDiem.AllowUserToDeleteRows = false;
            this.dgvDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDD,
            this.colTenDiaDiem});
            this.dgvDiaDiem.Location = new System.Drawing.Point(229, 288);
            this.dgvDiaDiem.Name = "dgvDiaDiem";
            this.dgvDiaDiem.ReadOnly = true;
            this.dgvDiaDiem.RowHeadersWidth = 51;
            this.dgvDiaDiem.RowTemplate.Height = 24;
            this.dgvDiaDiem.Size = new System.Drawing.Size(342, 84);
            this.dgvDiaDiem.TabIndex = 12;
            this.dgvDiaDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiaDiem_CellClick);
            // 
            // colMaDD
            // 
            this.colMaDD.HeaderText = "Mã Địa Điểm";
            this.colMaDD.MinimumWidth = 6;
            this.colMaDD.Name = "colMaDD";
            this.colMaDD.ReadOnly = true;
            this.colMaDD.Width = 125;
            // 
            // colTenDiaDiem
            // 
            this.colTenDiaDiem.HeaderText = "Tên Địa Điểm";
            this.colTenDiaDiem.MinimumWidth = 6;
            this.colTenDiaDiem.Name = "colTenDiaDiem";
            this.colTenDiaDiem.ReadOnly = true;
            this.colTenDiaDiem.Width = 125;
            // 
            // btnHuyBoDD
            // 
            this.btnHuyBoDD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBoDD.Location = new System.Drawing.Point(577, 215);
            this.btnHuyBoDD.Name = "btnHuyBoDD";
            this.btnHuyBoDD.Size = new System.Drawing.Size(123, 51);
            this.btnHuyBoDD.TabIndex = 8;
            this.btnHuyBoDD.Text = "Hủy Bỏ";
            this.btnHuyBoDD.UseVisualStyleBackColor = true;
            this.btnHuyBoDD.Click += new System.EventHandler(this.btnHuyBoDD_Click);
            // 
            // btnSuaDD
            // 
            this.btnSuaDD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDD.Location = new System.Drawing.Point(265, 215);
            this.btnSuaDD.Name = "btnSuaDD";
            this.btnSuaDD.Size = new System.Drawing.Size(123, 51);
            this.btnSuaDD.TabIndex = 9;
            this.btnSuaDD.Text = "Sữa";
            this.btnSuaDD.UseVisualStyleBackColor = true;
            this.btnSuaDD.Click += new System.EventHandler(this.btnSuaDD_Click);
            // 
            // btnXoaDD
            // 
            this.btnXoaDD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDD.Location = new System.Drawing.Point(424, 215);
            this.btnXoaDD.Name = "btnXoaDD";
            this.btnXoaDD.Size = new System.Drawing.Size(123, 51);
            this.btnXoaDD.TabIndex = 10;
            this.btnXoaDD.Text = "Xóa";
            this.btnXoaDD.UseVisualStyleBackColor = true;
            this.btnXoaDD.Click += new System.EventHandler(this.btnXoaDD_Click);
            // 
            // btnThemDD
            // 
            this.btnThemDD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDD.Location = new System.Drawing.Point(106, 215);
            this.btnThemDD.Name = "btnThemDD";
            this.btnThemDD.Size = new System.Drawing.Size(123, 51);
            this.btnThemDD.TabIndex = 11;
            this.btnThemDD.Text = "Thêm";
            this.btnThemDD.UseVisualStyleBackColor = true;
            this.btnThemDD.Click += new System.EventHandler(this.btnThemDD_Click);
            // 
            // txtTenDiaDiem
            // 
            this.txtTenDiaDiem.Location = new System.Drawing.Point(388, 150);
            this.txtTenDiaDiem.Multiline = true;
            this.txtTenDiaDiem.Name = "txtTenDiaDiem";
            this.txtTenDiaDiem.Size = new System.Drawing.Size(178, 25);
            this.txtTenDiaDiem.TabIndex = 6;
            // 
            // txtMaDiaDiem
            // 
            this.txtMaDiaDiem.Location = new System.Drawing.Point(384, 98);
            this.txtMaDiaDiem.Multiline = true;
            this.txtMaDiaDiem.Name = "txtMaDiaDiem";
            this.txtMaDiaDiem.Size = new System.Drawing.Size(178, 27);
            this.txtMaDiaDiem.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên địa điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã địa điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "QUẢN LÝ ĐỊA ĐIỂM";
            // 
            // FormDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DoAn_WF.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDiaDiem);
            this.Controls.Add(this.btnHuyBoDD);
            this.Controls.Add(this.btnSuaDD);
            this.Controls.Add(this.btnXoaDD);
            this.Controls.Add(this.btnThemDD);
            this.Controls.Add(this.txtTenDiaDiem);
            this.Controls.Add(this.txtMaDiaDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDiaDiem";
            this.Text = "FormDiaDiem";
            this.Load += new System.EventHandler(this.FormDiaDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiaDiem;
        private System.Windows.Forms.Button btnHuyBoDD;
        private System.Windows.Forms.Button btnSuaDD;
        private System.Windows.Forms.Button btnXoaDD;
        private System.Windows.Forms.Button btnThemDD;
        private System.Windows.Forms.TextBox txtTenDiaDiem;
        private System.Windows.Forms.TextBox txtMaDiaDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDiaDiem;
        private System.Windows.Forms.Label label3;
    }
}