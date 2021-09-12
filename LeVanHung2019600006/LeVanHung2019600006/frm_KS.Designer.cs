
namespace LeVanHung2019600006
{
    partial class frm_KS
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
            this.txtMaKhachHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoCMT = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.Label();
            this.dTPNgayCheck = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.txtSoP = new System.Windows.Forms.TextBox();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkNu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.AutoSize = true;
            this.txtMaKhachHang.Location = new System.Drawing.Point(64, 65);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(105, 17);
            this.txtMaKhachHang.TabIndex = 0;
            this.txtMaKhachHang.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // txtSoCMT
            // 
            this.txtSoCMT.AutoSize = true;
            this.txtSoCMT.Location = new System.Drawing.Point(64, 146);
            this.txtSoCMT.Name = "txtSoCMT";
            this.txtSoCMT.Size = new System.Drawing.Size(69, 17);
            this.txtSoCMT.TabIndex = 2;
            this.txtSoCMT.Text = "Số CMND";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.AutoSize = true;
            this.txtSoPhong.Location = new System.Drawing.Point(64, 180);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(69, 17);
            this.txtSoPhong.TabIndex = 3;
            this.txtSoPhong.Text = "Số phòng";
            // 
            // dTPNgayCheck
            // 
            this.dTPNgayCheck.AutoSize = true;
            this.dTPNgayCheck.Location = new System.Drawing.Point(64, 217);
            this.dTPNgayCheck.Name = "dTPNgayCheck";
            this.dTPNgayCheck.Size = new System.Drawing.Size(97, 17);
            this.dTPNgayCheck.TabIndex = 4;
            this.dTPNgayCheck.Text = "Ngày check in";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(186, 62);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(312, 22);
            this.txtMaKH.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(186, 106);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(312, 22);
            this.txtTen.TabIndex = 6;
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(186, 143);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(192, 22);
            this.txtCMT.TabIndex = 7;
            // 
            // txtSoP
            // 
            this.txtSoP.Location = new System.Drawing.Point(186, 177);
            this.txtSoP.Name = "txtSoP";
            this.txtSoP.Size = new System.Drawing.Size(192, 22);
            this.txtSoP.TabIndex = 8;
            // 
            // dTP1
            // 
            this.dTP1.Location = new System.Drawing.Point(186, 215);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(222, 22);
            this.dTP1.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(660, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 36);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(660, 150);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 36);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(660, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 36);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(660, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 36);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 171);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(449, 143);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(48, 21);
            this.chkNu.TabIndex = 23;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // frm_KS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.chkNu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dTP1);
            this.Controls.Add(this.txtSoP);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.dTPNgayCheck);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.txtSoCMT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKhachHang);
            this.Name = "frm_KS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_KS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSoCMT;
        private System.Windows.Forms.Label txtSoPhong;
        private System.Windows.Forms.Label dTPNgayCheck;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.TextBox txtSoP;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkNu;
    }
}

