
namespace DoAn_WF
{
    partial class FormTour
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
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyBoTour = new System.Windows.Forms.Button();
            this.btnSuaTour = new System.Windows.Forms.Button();
            this.btnXoaTour = new System.Windows.Forms.Button();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTour,
            this.colTenTour});
            this.dgvTour.Location = new System.Drawing.Point(231, 285);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.RowTemplate.Height = 24;
            this.dgvTour.Size = new System.Drawing.Size(390, 145);
            this.dgvTour.TabIndex = 21;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // colMaTour
            // 
            this.colMaTour.HeaderText = "Mã Tour";
            this.colMaTour.MinimumWidth = 6;
            this.colMaTour.Name = "colMaTour";
            this.colMaTour.ReadOnly = true;
            this.colMaTour.Width = 125;
            // 
            // colTenTour
            // 
            this.colTenTour.HeaderText = "Tên Tour";
            this.colTenTour.MinimumWidth = 6;
            this.colTenTour.Name = "colTenTour";
            this.colTenTour.ReadOnly = true;
            this.colTenTour.Width = 125;
            // 
            // btnHuyBoTour
            // 
            this.btnHuyBoTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBoTour.Location = new System.Drawing.Point(578, 221);
            this.btnHuyBoTour.Name = "btnHuyBoTour";
            this.btnHuyBoTour.Size = new System.Drawing.Size(123, 58);
            this.btnHuyBoTour.TabIndex = 17;
            this.btnHuyBoTour.Text = "Hủy Bỏ";
            this.btnHuyBoTour.UseVisualStyleBackColor = true;
            this.btnHuyBoTour.Click += new System.EventHandler(this.btnHuyBoTour_Click);
            // 
            // btnSuaTour
            // 
            this.btnSuaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTour.Location = new System.Drawing.Point(273, 221);
            this.btnSuaTour.Name = "btnSuaTour";
            this.btnSuaTour.Size = new System.Drawing.Size(123, 58);
            this.btnSuaTour.TabIndex = 18;
            this.btnSuaTour.Text = "Sữa";
            this.btnSuaTour.UseVisualStyleBackColor = true;
            this.btnSuaTour.Click += new System.EventHandler(this.btnSuaTour_Click);
            // 
            // btnXoaTour
            // 
            this.btnXoaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTour.Location = new System.Drawing.Point(420, 221);
            this.btnXoaTour.Name = "btnXoaTour";
            this.btnXoaTour.Size = new System.Drawing.Size(123, 58);
            this.btnXoaTour.TabIndex = 19;
            this.btnXoaTour.Text = "Xóa";
            this.btnXoaTour.UseVisualStyleBackColor = true;
            this.btnXoaTour.Click += new System.EventHandler(this.btnXoaTour_Click);
            // 
            // btnThemTour
            // 
            this.btnThemTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTour.Location = new System.Drawing.Point(106, 221);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(123, 58);
            this.btnThemTour.TabIndex = 20;
            this.btnThemTour.Text = "Thêm";
            this.btnThemTour.UseVisualStyleBackColor = true;
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(328, 162);
            this.txtTenTour.Multiline = true;
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(240, 34);
            this.txtTenTour.TabIndex = 15;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(328, 120);
            this.txtMaTour.Multiline = true;
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(240, 36);
            this.txtMaTour.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "QUẢN LÝ TOUR";
            // 
            // FormTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_WF.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.btnHuyBoTour);
            this.Controls.Add(this.btnSuaTour);
            this.Controls.Add(this.btnXoaTour);
            this.Controls.Add(this.btnThemTour);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.txtMaTour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTour";
            this.Text = "FormTour";
            this.Load += new System.EventHandler(this.FormTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Button btnHuyBoTour;
        private System.Windows.Forms.Button btnSuaTour;
        private System.Windows.Forms.Button btnXoaTour;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTour;
        private System.Windows.Forms.Label label3;
    }
}