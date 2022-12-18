namespace QuanLySinhVien
{
    partial class frm_Lop
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtg_Lop = new System.Windows.Forms.DataGridView();
            this.btn_UpdateLop = new System.Windows.Forms.Button();
            this.btn_DeleteLop = new System.Windows.Forms.Button();
            this.btn_AddLop = new System.Windows.Forms.Button();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.lbl_QuanLyLop = new System.Windows.Forms.Label();
            this.lbl_MaNienKhoa = new System.Windows.Forms.Label();
            this.lbl_MaKhoa = new System.Windows.Forms.Label();
            this.cmb_ListKhoa = new System.Windows.Forms.ComboBox();
            this.cmb_ListNienKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(714, 153);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 35;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(280, 153);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 34;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(384, 153);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 22);
            this.txtSearch.TabIndex = 33;
            // 
            // dtg_Lop
            // 
            this.dtg_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Lop.Location = new System.Drawing.Point(20, 193);
            this.dtg_Lop.Name = "dtg_Lop";
            this.dtg_Lop.RowHeadersWidth = 51;
            this.dtg_Lop.RowTemplate.Height = 24;
            this.dtg_Lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Lop.Size = new System.Drawing.Size(768, 248);
            this.dtg_Lop.TabIndex = 32;
            this.dtg_Lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Lop_CellContentClick);
            // 
            // btn_UpdateLop
            // 
            this.btn_UpdateLop.Location = new System.Drawing.Point(180, 154);
            this.btn_UpdateLop.Name = "btn_UpdateLop";
            this.btn_UpdateLop.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateLop.TabIndex = 31;
            this.btn_UpdateLop.Text = "Sửa";
            this.btn_UpdateLop.UseVisualStyleBackColor = true;
            this.btn_UpdateLop.Click += new System.EventHandler(this.btn_UpdateLop_Click);
            // 
            // btn_DeleteLop
            // 
            this.btn_DeleteLop.Location = new System.Drawing.Point(99, 154);
            this.btn_DeleteLop.Name = "btn_DeleteLop";
            this.btn_DeleteLop.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteLop.TabIndex = 30;
            this.btn_DeleteLop.Text = "Xóa";
            this.btn_DeleteLop.UseVisualStyleBackColor = true;
            this.btn_DeleteLop.Click += new System.EventHandler(this.btn_DeleteLop_Click);
            // 
            // btn_AddLop
            // 
            this.btn_AddLop.Location = new System.Drawing.Point(18, 154);
            this.btn_AddLop.Name = "btn_AddLop";
            this.btn_AddLop.Size = new System.Drawing.Size(75, 23);
            this.btn_AddLop.TabIndex = 29;
            this.btn_AddLop.Text = "Thêm";
            this.btn_AddLop.UseVisualStyleBackColor = true;
            this.btn_AddLop.Click += new System.EventHandler(this.btn_AddLop_Click);
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(475, 66);
            this.txt_TenLop.Multiline = true;
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(167, 23);
            this.txt_TenLop.TabIndex = 28;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenLop.Location = new System.Drawing.Point(331, 72);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(70, 20);
            this.lbl_TenLop.TabIndex = 27;
            this.lbl_TenLop.Text = "Tên Lớp";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(143, 66);
            this.txt_MaLop.Multiline = true;
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(167, 23);
            this.txt_MaLop.TabIndex = 26;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaLop.Location = new System.Drawing.Point(12, 69);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(65, 20);
            this.lbl_MaLop.TabIndex = 25;
            this.lbl_MaLop.Text = "Mã Lớp";
            // 
            // lbl_QuanLyLop
            // 
            this.lbl_QuanLyLop.AutoSize = true;
            this.lbl_QuanLyLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_QuanLyLop.Location = new System.Drawing.Point(255, 9);
            this.lbl_QuanLyLop.Name = "lbl_QuanLyLop";
            this.lbl_QuanLyLop.Size = new System.Drawing.Size(248, 38);
            this.lbl_QuanLyLop.TabIndex = 24;
            this.lbl_QuanLyLop.Text = "QUẢN LÝ LỚP";
            // 
            // lbl_MaNienKhoa
            // 
            this.lbl_MaNienKhoa.AutoSize = true;
            this.lbl_MaNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaNienKhoa.Location = new System.Drawing.Point(331, 119);
            this.lbl_MaNienKhoa.Name = "lbl_MaNienKhoa";
            this.lbl_MaNienKhoa.Size = new System.Drawing.Size(114, 20);
            this.lbl_MaNienKhoa.TabIndex = 37;
            this.lbl_MaNienKhoa.Text = "Mã Niên Khóa";
            // 
            // lbl_MaKhoa
            // 
            this.lbl_MaKhoa.AutoSize = true;
            this.lbl_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaKhoa.Location = new System.Drawing.Point(12, 116);
            this.lbl_MaKhoa.Name = "lbl_MaKhoa";
            this.lbl_MaKhoa.Size = new System.Drawing.Size(75, 20);
            this.lbl_MaKhoa.TabIndex = 36;
            this.lbl_MaKhoa.Text = "Mã Khoa";
            // 
            // cmb_ListKhoa
            // 
            this.cmb_ListKhoa.FormattingEnabled = true;
            this.cmb_ListKhoa.Location = new System.Drawing.Point(143, 111);
            this.cmb_ListKhoa.Name = "cmb_ListKhoa";
            this.cmb_ListKhoa.Size = new System.Drawing.Size(167, 24);
            this.cmb_ListKhoa.TabIndex = 38;
            this.cmb_ListKhoa.Text = "--- Chọn ---";
            // 
            // cmb_ListNienKhoa
            // 
            this.cmb_ListNienKhoa.FormattingEnabled = true;
            this.cmb_ListNienKhoa.Location = new System.Drawing.Point(475, 112);
            this.cmb_ListNienKhoa.Name = "cmb_ListNienKhoa";
            this.cmb_ListNienKhoa.Size = new System.Drawing.Size(167, 24);
            this.cmb_ListNienKhoa.TabIndex = 39;
            this.cmb_ListNienKhoa.Text = "--- Chọn --- ";
            // 
            // frm_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_ListNienKhoa);
            this.Controls.Add(this.cmb_ListKhoa);
            this.Controls.Add(this.lbl_MaNienKhoa);
            this.Controls.Add(this.lbl_MaKhoa);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtg_Lop);
            this.Controls.Add(this.btn_UpdateLop);
            this.Controls.Add(this.btn_DeleteLop);
            this.Controls.Add(this.btn_AddLop);
            this.Controls.Add(this.txt_TenLop);
            this.Controls.Add(this.lbl_TenLop);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.lbl_MaLop);
            this.Controls.Add(this.lbl_QuanLyLop);
            this.Name = "frm_Lop";
            this.Text = "frm_Lop";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtg_Lop;
        private System.Windows.Forms.Button btn_UpdateLop;
        private System.Windows.Forms.Button btn_DeleteLop;
        private System.Windows.Forms.Button btn_AddLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Label lbl_QuanLyLop;
        private System.Windows.Forms.Label lbl_MaNienKhoa;
        private System.Windows.Forms.Label lbl_MaKhoa;
        private System.Windows.Forms.ComboBox cmb_ListKhoa;
        private System.Windows.Forms.ComboBox cmb_ListNienKhoa;
    }
}