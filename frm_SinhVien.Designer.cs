namespace QuanLySinhVien
{
    partial class frm_SinhVien
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
            this.lbl_MaNienKhoa = new System.Windows.Forms.Label();
            this.lbl_MaKhoa = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtg_SinhVien = new System.Windows.Forms.DataGridView();
            this.btn_UpdateSV = new System.Windows.Forms.Button();
            this.btn_DeleteSV = new System.Windows.Forms.Button();
            this.btn_AddSV = new System.Windows.Forms.Button();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.lbl_QuanLyLop = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.pib_ImageSV = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_ImageSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaNienKhoa
            // 
            this.lbl_MaNienKhoa.AutoSize = true;
            this.lbl_MaNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaNienKhoa.Location = new System.Drawing.Point(331, 119);
            this.lbl_MaNienKhoa.Name = "lbl_MaNienKhoa";
            this.lbl_MaNienKhoa.Size = new System.Drawing.Size(106, 20);
            this.lbl_MaNienKhoa.TabIndex = 53;
            this.lbl_MaNienKhoa.Text = "Số điện thoại";
            // 
            // lbl_MaKhoa
            // 
            this.lbl_MaKhoa.AutoSize = true;
            this.lbl_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaKhoa.Location = new System.Drawing.Point(12, 116);
            this.lbl_MaKhoa.Name = "lbl_MaKhoa";
            this.lbl_MaKhoa.Size = new System.Drawing.Size(81, 20);
            this.lbl_MaKhoa.TabIndex = 52;
            this.lbl_MaKhoa.Text = "Quê quán";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(884, 156);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 51;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(450, 156);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 50;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(554, 156);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 22);
            this.txtSearch.TabIndex = 49;
            // 
            // dtg_SinhVien
            // 
            this.dtg_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SinhVien.Location = new System.Drawing.Point(20, 193);
            this.dtg_SinhVien.Name = "dtg_SinhVien";
            this.dtg_SinhVien.RowHeadersWidth = 51;
            this.dtg_SinhVien.RowTemplate.Height = 24;
            this.dtg_SinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_SinhVien.Size = new System.Drawing.Size(768, 248);
            this.dtg_SinhVien.TabIndex = 48;
            this.dtg_SinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SinhVien_CellContentClick);
            // 
            // btn_UpdateSV
            // 
            this.btn_UpdateSV.Location = new System.Drawing.Point(803, 222);
            this.btn_UpdateSV.Name = "btn_UpdateSV";
            this.btn_UpdateSV.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateSV.TabIndex = 47;
            this.btn_UpdateSV.Text = "Sửa";
            this.btn_UpdateSV.UseVisualStyleBackColor = true;
            this.btn_UpdateSV.Click += new System.EventHandler(this.btn_UpdateSV_Click);
            // 
            // btn_DeleteSV
            // 
            this.btn_DeleteSV.Location = new System.Drawing.Point(895, 193);
            this.btn_DeleteSV.Name = "btn_DeleteSV";
            this.btn_DeleteSV.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteSV.TabIndex = 46;
            this.btn_DeleteSV.Text = "Xóa";
            this.btn_DeleteSV.UseVisualStyleBackColor = true;
            this.btn_DeleteSV.Click += new System.EventHandler(this.btn_DeleteSV_Click);
            // 
            // btn_AddSV
            // 
            this.btn_AddSV.Location = new System.Drawing.Point(803, 193);
            this.btn_AddSV.Name = "btn_AddSV";
            this.btn_AddSV.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSV.TabIndex = 45;
            this.btn_AddSV.Text = "Thêm";
            this.btn_AddSV.UseVisualStyleBackColor = true;
            this.btn_AddSV.Click += new System.EventHandler(this.btn_AddSV_Click);
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(475, 66);
            this.txt_TenSV.Multiline = true;
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(167, 23);
            this.txt_TenSV.TabIndex = 44;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenLop.Location = new System.Drawing.Point(331, 72);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(64, 20);
            this.lbl_TenLop.TabIndex = 43;
            this.lbl_TenLop.Text = "Tên SV";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(143, 66);
            this.txt_MaSV.Multiline = true;
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(167, 23);
            this.txt_MaSV.TabIndex = 42;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaLop.Location = new System.Drawing.Point(12, 69);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(59, 20);
            this.lbl_MaLop.TabIndex = 41;
            this.lbl_MaLop.Text = "Mã SV";
            // 
            // lbl_QuanLyLop
            // 
            this.lbl_QuanLyLop.AutoSize = true;
            this.lbl_QuanLyLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_QuanLyLop.Location = new System.Drawing.Point(223, 9);
            this.lbl_QuanLyLop.Name = "lbl_QuanLyLop";
            this.lbl_QuanLyLop.Size = new System.Drawing.Size(351, 38);
            this.lbl_QuanLyLop.TabIndex = 40;
            this.lbl_QuanLyLop.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh.Location = new System.Drawing.Point(759, 70);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dt_NgaySinh.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(664, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Năm sinh";
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.Location = new System.Drawing.Point(143, 113);
            this.txt_QueQuan.Multiline = true;
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(167, 23);
            this.txt_QueQuan.TabIndex = 58;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(475, 113);
            this.txt_SoDienThoai.Multiline = true;
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(167, 23);
            this.txt_SoDienThoai.TabIndex = 59;
            this.txt_SoDienThoai.TextChanged += new System.EventHandler(this.txt_SoDienThoai_TextChanged);
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(759, 117);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 20);
            this.rad_Nam.TabIndex = 60;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(833, 117);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(45, 20);
            this.rad_Nu.TabIndex = 61;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(664, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Lớp";
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(143, 154);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(167, 24);
            this.cmb_Lop.TabIndex = 64;
            // 
            // pib_ImageSV
            // 
            this.pib_ImageSV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pib_ImageSV.Location = new System.Drawing.Point(803, 251);
            this.pib_ImageSV.Name = "pib_ImageSV";
            this.pib_ImageSV.Size = new System.Drawing.Size(156, 187);
            this.pib_ImageSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pib_ImageSV.TabIndex = 65;
            this.pib_ImageSV.TabStop = false;
            this.pib_ImageSV.Click += new System.EventHandler(this.pib_ImageSV_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(895, 222);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 66;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 480);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pib_ImageSV);
            this.Controls.Add(this.cmb_Lop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.txt_QueQuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.lbl_MaNienKhoa);
            this.Controls.Add(this.lbl_MaKhoa);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtg_SinhVien);
            this.Controls.Add(this.btn_UpdateSV);
            this.Controls.Add(this.btn_DeleteSV);
            this.Controls.Add(this.btn_AddSV);
            this.Controls.Add(this.txt_TenSV);
            this.Controls.Add(this.lbl_TenLop);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.lbl_MaLop);
            this.Controls.Add(this.lbl_QuanLyLop);
            this.Name = "frm_SinhVien";
            this.Text = "frm_SinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_ImageSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_MaNienKhoa;
        private System.Windows.Forms.Label lbl_MaKhoa;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtg_SinhVien;
        private System.Windows.Forms.Button btn_UpdateSV;
        private System.Windows.Forms.Button btn_DeleteSV;
        private System.Windows.Forms.Button btn_AddSV;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Label lbl_QuanLyLop;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.PictureBox pib_ImageSV;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btn_Clear;
    }
}