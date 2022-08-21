
namespace QuanLyBanHang
{
    partial class frmHoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaHDBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaHDBan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 683);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(545, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaHDBan
            // 
            this.cboMaHDBan.FormattingEnabled = true;
            this.cboMaHDBan.Location = new System.Drawing.Point(103, 13);
            this.cboMaHDBan.Name = "cboMaHDBan";
            this.cboMaHDBan.Size = new System.Drawing.Size(433, 24);
            this.cboMaHDBan.TabIndex = 1;
            this.cboMaHDBan.DropDown += new System.EventHandler(this.cboMaHDBan_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHDBanHang);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(943, 683);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaKhach);
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHDBan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(616, 27);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(291, 24);
            this.cboMaKhach.TabIndex = 5;
            this.cboMaKhach.TextChanged += new System.EventHandler(this.cboMaKhach_TextChanged);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(153, 89);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(291, 24);
            this.cboMaNhanVien.TabIndex = 3;
            this.cboMaNhanVien.TextChanged += new System.EventHandler(this.cboMaNhanVien_TextChanged);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(616, 120);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(291, 22);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(153, 120);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(291, 22);
            this.txtTenNhanVien.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(616, 89);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(291, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(616, 58);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(291, 22);
            this.txtTenKhach.TabIndex = 6;
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(153, 27);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(291, 22);
            this.txtMaHDBan.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBanHang.Location = new System.Drawing.Point(0, 102);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 24;
            this.dgvHDBanHang.Size = new System.Drawing.Size(943, 249);
            this.dgvHDBanHang.TabIndex = 2;
            this.dgvHDBanHang.DoubleClick += new System.EventHandler(this.dgvHDBanHang_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.lblBangChu);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 76);
            this.panel4.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(726, 13);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(183, 22);
            this.txtTongTien.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(634, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "Tổng tiền";
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Location = new System.Drawing.Point(113, 47);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(144, 17);
            this.lblBangChu.TabIndex = 2;
            this.lblBangChu.Text = "Năm trăm nghìn đồng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Bằng chữ: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(33, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nháy đúp một dòng để xóa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 102);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cboMaHang);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 92);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(723, 61);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(183, 22);
            this.txtThanhTien.TabIndex = 6;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(413, 61);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(183, 22);
            this.txtGiamGia.TabIndex = 4;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(723, 27);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(183, 22);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(413, 27);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(183, 22);
            this.txtTenHang.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(113, 61);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(181, 22);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(113, 27);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(181, 24);
            this.cboMaHang.TabIndex = 1;
            this.cboMaHang.TextChanged += new System.EventHandler(this.cboMaHang_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(631, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(322, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Giảm giá %";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(631, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Đơn giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnInHoaDon);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 53);
            this.panel2.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(757, 11);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 30);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(576, 11);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(150, 30);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(395, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Hóa Đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(214, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 30);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(153, 58);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(291, 22);
            this.txtNgayBan.TabIndex = 2;
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 734);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonBan_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaHDBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNgayBan;
    }
}