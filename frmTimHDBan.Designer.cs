
namespace QuanLyBanHang
{
    partial class frmTimHDBan
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
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTKHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtMaKhach);
            this.panel1.Controls.Add(this.txtMaHDBan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 117);
            this.panel1.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(275, 45);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(90, 22);
            this.txtNam.TabIndex = 3;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(131, 45);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(95, 22);
            this.txtThang.TabIndex = 2;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(131, 80);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(234, 22);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(526, 45);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(234, 22);
            this.txtTongTien.TabIndex = 6;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(526, 8);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(234, 22);
            this.txtMaKhach.TabIndex = 5;
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(131, 10);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(234, 22);
            this.txtMaHDBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnTimLai);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(563, 53);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(125, 35);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(337, 53);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(125, 35);
            this.btnTimLai.TabIndex = 2;
            this.btnTimLai.Text = "Tìm Lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(111, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 35);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(26, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nháy đúp vào hóa đơn để hiện thông tin chi tiết";
            // 
            // dgvTKHoaDon
            // 
            this.dgvTKHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKHoaDon.Location = new System.Drawing.Point(0, 117);
            this.dgvTKHoaDon.Name = "dgvTKHoaDon";
            this.dgvTKHoaDon.RowHeadersWidth = 51;
            this.dgvTKHoaDon.RowTemplate.Height = 24;
            this.dgvTKHoaDon.Size = new System.Drawing.Size(800, 233);
            this.dgvTKHoaDon.TabIndex = 2;
            this.dgvTKHoaDon.DoubleClick += new System.EventHandler(this.dgvTKHoaDon_DoubleClick);
            // 
            // frmTimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTKHoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimHDBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm hóa đơn";
            this.Load += new System.EventHandler(this.frmTimHDBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTKHoaDon;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimKiem;
    }
}