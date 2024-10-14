namespace Tuan7
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvQuanly = new System.Windows.Forms.DataGridView();
            this.ColMASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtMaSP = new System.Windows.Forms.TextBox();
            this.TxtTenSP = new System.Windows.Forms.TextBox();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lvSanpham = new System.Windows.Forms.ListView();
            this.btTim = new System.Windows.Forms.Button();
            this.lblQLSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanly)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại SP :";
            // 
            // dgvQuanly
            // 
            this.dgvQuanly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMASP,
            this.ColTenSP,
            this.ColNgayNhap,
            this.ColLoaiSP});
            this.dgvQuanly.Location = new System.Drawing.Point(34, 123);
            this.dgvQuanly.Name = "dgvQuanly";
            this.dgvQuanly.Size = new System.Drawing.Size(457, 222);
            this.dgvQuanly.TabIndex = 4;
            // 
            // ColMASP
            // 
            this.ColMASP.HeaderText = "Mã SP";
            this.ColMASP.Name = "ColMASP";
            // 
            // ColTenSP
            // 
            this.ColTenSP.HeaderText = "Tên Sản Phẩm";
            this.ColTenSP.Name = "ColTenSP";
            // 
            // ColNgayNhap
            // 
            this.ColNgayNhap.HeaderText = "Ngày nhập";
            this.ColNgayNhap.Name = "ColNgayNhap";
            // 
            // ColLoaiSP
            // 
            this.ColLoaiSP.HeaderText = "Loai SP";
            this.ColLoaiSP.Name = "ColLoaiSP";
            // 
            // TxtMaSP
            // 
            this.TxtMaSP.Location = new System.Drawing.Point(587, 146);
            this.TxtMaSP.Name = "TxtMaSP";
            this.TxtMaSP.Size = new System.Drawing.Size(118, 20);
            this.TxtMaSP.TabIndex = 5;
            // 
            // TxtTenSP
            // 
            this.TxtTenSP.Location = new System.Drawing.Point(587, 190);
            this.TxtTenSP.Name = "TxtTenSP";
            this.TxtTenSP.Size = new System.Drawing.Size(118, 20);
            this.TxtTenSP.TabIndex = 6;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Location = new System.Drawing.Point(587, 224);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(200, 20);
            this.dtNgaynhap.TabIndex = 7;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(587, 275);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(118, 21);
            this.cboLoaiSP.TabIndex = 8;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(86, 371);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(202, 371);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(316, 371);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(433, 369);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 25);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btKLuu
            // 
            this.btKLuu.Location = new System.Drawing.Point(536, 369);
            this.btKLuu.Name = "btKLuu";
            this.btKLuu.Size = new System.Drawing.Size(75, 23);
            this.btKLuu.TabIndex = 13;
            this.btKLuu.Text = "K Lưu";
            this.btKLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(646, 369);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(72, 23);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // lvSanpham
            // 
            this.lvSanpham.HideSelection = false;
            this.lvSanpham.Location = new System.Drawing.Point(82, 60);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.Size = new System.Drawing.Size(108, 31);
            this.lvSanpham.TabIndex = 15;
            this.lvSanpham.UseCompatibleStateImageBehavior = false;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(212, 60);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(89, 31);
            this.btTim.TabIndex = 16;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // lblQLSV
            // 
            this.lblQLSV.AutoSize = true;
            this.lblQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQLSV.Location = new System.Drawing.Point(290, 9);
            this.lblQLSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(284, 31);
            this.lblQLSV.TabIndex = 17;
            this.lblQLSV.Text = "Doanh Mục Sản Phẩm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQLSV);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.lvSanpham);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKLuu);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.TxtTenSP);
            this.Controls.Add(this.TxtMaSP);
            this.Controls.Add(this.dgvQuanly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QUAN LY SAN PHAM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvQuanly;
        private System.Windows.Forms.TextBox TxtMaSP;
        private System.Windows.Forms.TextBox TxtTenSP;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSP;
        private System.Windows.Forms.ListView lvSanpham;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoaiSP;
        private System.Windows.Forms.Label lblQLSV;
    }
}

