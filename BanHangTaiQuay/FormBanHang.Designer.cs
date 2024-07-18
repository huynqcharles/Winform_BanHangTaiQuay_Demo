namespace BanHangTaiQuay
{
    partial class FormBanHang
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
            panel1 = new Panel();
            lblQuyenNhanVien = new Label();
            lblTenNhanVien = new Label();
            groupBox1 = new GroupBox();
            btnTaoHoaDon = new Button();
            txtTenKH = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblTienThua = new Label();
            btnHuy = new Button();
            btnThanhToan = new Button();
            label10 = new Label();
            txtTienKhachDua = new TextBox();
            label9 = new Label();
            lblTongTien = new Label();
            label7 = new Label();
            dgvHoaDonChiTiet = new DataGridView();
            cbbHoaDonCho = new ComboBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dgvSanPhamChiTiet = new DataGridView();
            txtTimKiem = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonChiTiet).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamChiTiet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblQuyenNhanVien);
            panel1.Controls.Add(lblTenNhanVien);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1494, 87);
            panel1.TabIndex = 0;
            // 
            // lblQuyenNhanVien
            // 
            lblQuyenNhanVien.AutoSize = true;
            lblQuyenNhanVien.Location = new Point(14, 47);
            lblQuyenNhanVien.Margin = new Padding(5, 0, 5, 0);
            lblQuyenNhanVien.Name = "lblQuyenNhanVien";
            lblQuyenNhanVien.Size = new Size(67, 25);
            lblQuyenNhanVien.TabIndex = 1;
            lblQuyenNhanVien.Text = "Quyền";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new Point(14, 9);
            lblTenNhanVien.Margin = new Padding(5, 0, 5, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(129, 25);
            lblTenNhanVien.TabIndex = 0;
            lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTaoHoaDon);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 637);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(14, 201);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(252, 34);
            btnTaoHoaDon.TabIndex = 6;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(14, 143);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(252, 32);
            txtTenKH.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 115);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 4;
            label4.Text = "Tên khách hàng";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(14, 69);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(252, 32);
            txtSDT.TabIndex = 3;
            txtSDT.KeyDown += txtSDT_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 41);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTienThua);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTienKhachDua);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblTongTien);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dgvHoaDonChiTiet);
            groupBox2.Controls.Add(cbbHoaDonCho);
            groupBox2.Controls.Add(label5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(283, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1211, 637);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTienThua.Location = new Point(170, 576);
            lblTienThua.Margin = new Padding(5, 0, 5, 0);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(128, 37);
            lblTienThua.TabIndex = 17;
            lblTienThua.Text = "Tiền thừa";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(445, 581);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(135, 32);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(445, 533);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(135, 32);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 584);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(95, 25);
            label10.TabIndex = 14;
            label10.Text = "Tiền thừa:";
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.Location = new Point(170, 533);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(252, 32);
            txtTienKhachDua.TabIndex = 7;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 536);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 25);
            label9.TabIndex = 12;
            label9.Text = "Tiền khách đưa:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTien.Location = new Point(170, 479);
            lblTongTien.Margin = new Padding(5, 0, 5, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(130, 37);
            lblTongTien.TabIndex = 11;
            lblTongTien.Text = "Tổng tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 489);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 10;
            label7.Text = "Tổng hóa đơn:";
            // 
            // dgvHoaDonChiTiet
            // 
            dgvHoaDonChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonChiTiet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHoaDonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonChiTiet.Location = new Point(18, 97);
            dgvHoaDonChiTiet.Name = "dgvHoaDonChiTiet";
            dgvHoaDonChiTiet.RowTemplate.Height = 25;
            dgvHoaDonChiTiet.Size = new Size(562, 359);
            dgvHoaDonChiTiet.TabIndex = 9;
            // 
            // cbbHoaDonCho
            // 
            cbbHoaDonCho.FormattingEnabled = true;
            cbbHoaDonCho.Location = new Point(158, 38);
            cbbHoaDonCho.Name = "cbbHoaDonCho";
            cbbHoaDonCho.Size = new Size(252, 33);
            cbbHoaDonCho.TabIndex = 8;
            cbbHoaDonCho.SelectedIndexChanged += cbbHoaDonCho_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 41);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 7;
            label5.Text = "Chọn hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSanPhamChiTiet);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label6);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(885, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(609, 637);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPhamChiTiet
            // 
            dgvSanPhamChiTiet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPhamChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPhamChiTiet.Location = new Point(20, 97);
            dgvSanPhamChiTiet.Name = "dgvSanPhamChiTiet";
            dgvSanPhamChiTiet.RowTemplate.Height = 25;
            dgvSanPhamChiTiet.Size = new Size(563, 515);
            dgvSanPhamChiTiet.TabIndex = 10;
            dgvSanPhamChiTiet.CellDoubleClick += dgvSanPhamChiTiet_CellDoubleClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(116, 38);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(252, 32);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 41);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 10;
            label6.Text = "Tìm kiếm";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 724);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonChiTiet).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuyenNhanVien;
        private Label lblTenNhanVien;
        private GroupBox groupBox1;
        private TextBox txtSDT;
        private Label label3;
        private Button btnTaoHoaDon;
        private TextBox txtTenKH;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private DataGridView dgvHoaDonChiTiet;
        private ComboBox cbbHoaDonCho;
        private Label label6;
        private Label label10;
        private TextBox txtTienKhachDua;
        private Label label9;
        private Label lblTongTien;
        private Label label7;
        private DataGridView dgvSanPhamChiTiet;
        private TextBox txtTimKiem;
        private Button btnHuy;
        private Button btnThanhToan;
        private Label lblTienThua;
    }
}