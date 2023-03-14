
namespace DoAn_WF
{
    partial class FormPhuongTien
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
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.colMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyBoPT = new System.Windows.Forms.Button();
            this.btnSuaPT = new System.Windows.Forms.Button();
            this.btnXoaPT = new System.Windows.Forms.Button();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhuongTien = new System.Windows.Forms.TextBox();
            this.txtMaPhuongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.AllowUserToAddRows = false;
            this.dgvPhuongTien.AllowUserToDeleteRows = false;
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPT,
            this.colTenPT});
            this.dgvPhuongTien.Location = new System.Drawing.Point(149, 245);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.ReadOnly = true;
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.RowTemplate.Height = 24;
            this.dgvPhuongTien.Size = new System.Drawing.Size(436, 173);
            this.dgvPhuongTien.TabIndex = 21;
            this.dgvPhuongTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellClick);
            // 
            // colMaPT
            // 
            this.colMaPT.HeaderText = "Mã Phương Tiện";
            this.colMaPT.MinimumWidth = 6;
            this.colMaPT.Name = "colMaPT";
            this.colMaPT.ReadOnly = true;
            this.colMaPT.Width = 125;
            // 
            // colTenPT
            // 
            this.colTenPT.HeaderText = "Tên Phương Tiện";
            this.colTenPT.MinimumWidth = 6;
            this.colTenPT.Name = "colTenPT";
            this.colTenPT.ReadOnly = true;
            this.colTenPT.Width = 125;
            // 
            // btnHuyBoPT
            // 
            this.btnHuyBoPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBoPT.Location = new System.Drawing.Point(540, 171);
            this.btnHuyBoPT.Name = "btnHuyBoPT";
            this.btnHuyBoPT.Size = new System.Drawing.Size(104, 50);
            this.btnHuyBoPT.TabIndex = 17;
            this.btnHuyBoPT.Text = "Hủy Bỏ";
            this.btnHuyBoPT.UseVisualStyleBackColor = true;
            this.btnHuyBoPT.Click += new System.EventHandler(this.btnHuyBoPT_Click);
            // 
            // btnSuaPT
            // 
            this.btnSuaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPT.Location = new System.Drawing.Point(226, 171);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(104, 50);
            this.btnSuaPT.TabIndex = 18;
            this.btnSuaPT.Text = "Sữa";
            this.btnSuaPT.UseVisualStyleBackColor = true;
            this.btnSuaPT.Click += new System.EventHandler(this.btnSuaPT_Click);
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPT.Location = new System.Drawing.Point(389, 171);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(104, 50);
            this.btnXoaPT.TabIndex = 19;
            this.btnXoaPT.Text = "Xóa";
            this.btnXoaPT.UseVisualStyleBackColor = true;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // btnThemPT
            // 
            this.btnThemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPT.Location = new System.Drawing.Point(61, 171);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(104, 50);
            this.btnThemPT.TabIndex = 20;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên phương tiện";
            this.label2.TabIndexChanged += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phương tiện";
            // 
            // txtTenPhuongTien
            // 
            this.txtTenPhuongTien.Location = new System.Drawing.Point(233, 131);
            this.txtTenPhuongTien.Multiline = true;
            this.txtTenPhuongTien.Name = "txtTenPhuongTien";
            this.txtTenPhuongTien.Size = new System.Drawing.Size(402, 34);
            this.txtTenPhuongTien.TabIndex = 22;
            // 
            // txtMaPhuongTien
            // 
            this.txtMaPhuongTien.Location = new System.Drawing.Point(233, 78);
            this.txtMaPhuongTien.Multiline = true;
            this.txtMaPhuongTien.Name = "txtMaPhuongTien";
            this.txtMaPhuongTien.Size = new System.Drawing.Size(178, 34);
            this.txtMaPhuongTien.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "QUẢN LÝ PHƯƠNG TIỆN";
            // 
            // FormPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_WF.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenPhuongTien);
            this.Controls.Add(this.txtMaPhuongTien);
            this.Controls.Add(this.dgvPhuongTien);
            this.Controls.Add(this.btnHuyBoPT);
            this.Controls.Add(this.btnSuaPT);
            this.Controls.Add(this.btnXoaPT);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhuongTien";
            this.Text = "FormPhuongTien";
            this.Load += new System.EventHandler(this.FormPhuongTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.Button btnHuyBoPT;
        private System.Windows.Forms.Button btnSuaPT;
        private System.Windows.Forms.Button btnXoaPT;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhuongTien;
        private System.Windows.Forms.TextBox txtMaPhuongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPT;
        private System.Windows.Forms.Label label3;
    }
}