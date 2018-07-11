namespace QuanLyBanHangSieuThiMini.Forms
{
    partial class frmHangHoa
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
            this.pnlLoaiHang = new System.Windows.Forms.Panel();
            this.grpLoaiHang = new System.Windows.Forms.GroupBox();
            this.btnSuaLoaiHang = new System.Windows.Forms.Button();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.grpHangHoa = new System.Windows.Forms.GroupBox();
            this.btnSuaHangHoa = new System.Windows.Forms.Button();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLoaiHang.SuspendLayout();
            this.grpLoaiHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.pnlHangHoa.SuspendLayout();
            this.grpHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoaiHang
            // 
            this.pnlLoaiHang.Controls.Add(this.grpLoaiHang);
            this.pnlLoaiHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoaiHang.Location = new System.Drawing.Point(0, 0);
            this.pnlLoaiHang.Name = "pnlLoaiHang";
            this.pnlLoaiHang.Size = new System.Drawing.Size(326, 541);
            this.pnlLoaiHang.TabIndex = 0;
            // 
            // grpLoaiHang
            // 
            this.grpLoaiHang.Controls.Add(this.btnSuaLoaiHang);
            this.grpLoaiHang.Controls.Add(this.btnThemLoaiHang);
            this.grpLoaiHang.Controls.Add(this.dgvLoaiHang);
            this.grpLoaiHang.Location = new System.Drawing.Point(13, 13);
            this.grpLoaiHang.Name = "grpLoaiHang";
            this.grpLoaiHang.Size = new System.Drawing.Size(307, 516);
            this.grpLoaiHang.TabIndex = 0;
            this.grpLoaiHang.TabStop = false;
            this.grpLoaiHang.Text = "Loại hàng";
            // 
            // btnSuaLoaiHang
            // 
            this.btnSuaLoaiHang.Location = new System.Drawing.Point(88, 40);
            this.btnSuaLoaiHang.Name = "btnSuaLoaiHang";
            this.btnSuaLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLoaiHang.TabIndex = 2;
            this.btnSuaLoaiHang.Text = "Sửa";
            this.btnSuaLoaiHang.UseVisualStyleBackColor = true;
            this.btnSuaLoaiHang.Click += new System.EventHandler(this.btnSuaLoaiHang_Click);
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.Location = new System.Drawing.Point(7, 40);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btnThemLoaiHang.TabIndex = 1;
            this.btnThemLoaiHang.Text = "Thêm";
            this.btnThemLoaiHang.UseVisualStyleBackColor = true;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.AllowUserToAddRows = false;
            this.dgvLoaiHang.AllowUserToDeleteRows = false;
            this.dgvLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvLoaiHang.Location = new System.Drawing.Point(7, 69);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.Size = new System.Drawing.Size(295, 441);
            this.dgvLoaiHang.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iMaloaihangID";
            this.Column1.HeaderText = "Mã loại hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenloaihang";
            this.Column2.HeaderText = "Tên loại hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pnlHangHoa
            // 
            this.pnlHangHoa.Controls.Add(this.grpHangHoa);
            this.pnlHangHoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHangHoa.Location = new System.Drawing.Point(332, 0);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(997, 541);
            this.pnlHangHoa.TabIndex = 1;
            // 
            // grpHangHoa
            // 
            this.grpHangHoa.Controls.Add(this.btnSuaHangHoa);
            this.grpHangHoa.Controls.Add(this.btnThemHangHoa);
            this.grpHangHoa.Controls.Add(this.dgvHangHoa);
            this.grpHangHoa.Location = new System.Drawing.Point(3, 13);
            this.grpHangHoa.Name = "grpHangHoa";
            this.grpHangHoa.Size = new System.Drawing.Size(946, 516);
            this.grpHangHoa.TabIndex = 0;
            this.grpHangHoa.TabStop = false;
            this.grpHangHoa.Text = "Hàng hóa";
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.Location = new System.Drawing.Point(87, 40);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(75, 23);
            this.btnSuaHangHoa.TabIndex = 3;
            this.btnSuaHangHoa.Text = "Sửa";
            this.btnSuaHangHoa.UseVisualStyleBackColor = true;
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.Location = new System.Drawing.Point(6, 40);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(75, 23);
            this.btnThemHangHoa.TabIndex = 2;
            this.btnThemHangHoa.Text = "Thêm";
            this.btnThemHangHoa.UseVisualStyleBackColor = true;
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column11,
            this.Column7});
            this.dgvHangHoa.Location = new System.Drawing.Point(6, 69);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.Size = new System.Drawing.Size(934, 441);
            this.dgvHangHoa.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã hàng hóa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên hàng hóa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá nhập (VND)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giá bán (VND)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số lượng";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Đơn vị tính";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã vạch";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHangHoa);
            this.Controls.Add(this.pnlLoaiHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.pnlLoaiHang.ResumeLayout(false);
            this.grpLoaiHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.pnlHangHoa.ResumeLayout(false);
            this.grpHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoaiHang;
        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Windows.Forms.GroupBox grpLoaiHang;
        private System.Windows.Forms.GroupBox grpHangHoa;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnSuaLoaiHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.Button btnSuaHangHoa;
        private System.Windows.Forms.Button btnThemHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}