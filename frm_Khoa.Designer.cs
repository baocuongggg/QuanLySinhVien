namespace QuanLySinhVien
{
    partial class frm_Khoa
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
            this.lbl_QuanLyKhoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.txt_TenKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddKhoa = new System.Windows.Forms.Button();
            this.btn_DeleteKhoa = new System.Windows.Forms.Button();
            this.btn_UpdateKhoa = new System.Windows.Forms.Button();
            this.dtg_Khoa = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QuanLyKhoa
            // 
            this.lbl_QuanLyKhoa.AutoSize = true;
            this.lbl_QuanLyKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_QuanLyKhoa.Location = new System.Drawing.Point(262, 9);
            this.lbl_QuanLyKhoa.Name = "lbl_QuanLyKhoa";
            this.lbl_QuanLyKhoa.Size = new System.Drawing.Size(277, 38);
            this.lbl_QuanLyKhoa.TabIndex = 0;
            this.lbl_QuanLyKhoa.Text = "QUẢN LÝ KHOA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khoa";
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(93, 63);
            this.txt_MaKhoa.Multiline = true;
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(167, 23);
            this.txt_MaKhoa.TabIndex = 2;
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.Location = new System.Drawing.Point(355, 63);
            this.txt_TenKhoa.Multiline = true;
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Size = new System.Drawing.Size(167, 23);
            this.txt_TenKhoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(264, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khoa";
            // 
            // btn_AddKhoa
            // 
            this.btn_AddKhoa.Location = new System.Drawing.Point(552, 63);
            this.btn_AddKhoa.Name = "btn_AddKhoa";
            this.btn_AddKhoa.Size = new System.Drawing.Size(75, 23);
            this.btn_AddKhoa.TabIndex = 5;
            this.btn_AddKhoa.Text = "Thêm";
            this.btn_AddKhoa.UseVisualStyleBackColor = true;
            this.btn_AddKhoa.Click += new System.EventHandler(this.btn_AddKhoa_Click);
            // 
            // btn_DeleteKhoa
            // 
            this.btn_DeleteKhoa.Location = new System.Drawing.Point(633, 63);
            this.btn_DeleteKhoa.Name = "btn_DeleteKhoa";
            this.btn_DeleteKhoa.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteKhoa.TabIndex = 6;
            this.btn_DeleteKhoa.Text = "Xóa";
            this.btn_DeleteKhoa.UseVisualStyleBackColor = true;
            this.btn_DeleteKhoa.Click += new System.EventHandler(this.btn_DeleteKhoa_Click);
            // 
            // btn_UpdateKhoa
            // 
            this.btn_UpdateKhoa.Location = new System.Drawing.Point(714, 63);
            this.btn_UpdateKhoa.Name = "btn_UpdateKhoa";
            this.btn_UpdateKhoa.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateKhoa.TabIndex = 7;
            this.btn_UpdateKhoa.Text = "Sửa";
            this.btn_UpdateKhoa.UseVisualStyleBackColor = true;
            this.btn_UpdateKhoa.Click += new System.EventHandler(this.btn_UpdateKhoa_Click);
            // 
            // dtg_Khoa
            // 
            this.dtg_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Khoa.Location = new System.Drawing.Point(20, 146);
            this.dtg_Khoa.Name = "dtg_Khoa";
            this.dtg_Khoa.RowHeadersWidth = 51;
            this.dtg_Khoa.RowTemplate.Height = 24;
            this.dtg_Khoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Khoa.Size = new System.Drawing.Size(768, 292);
            this.dtg_Khoa.TabIndex = 8;
            this.dtg_Khoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Khoa_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(312, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(214, 110);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 10;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(661, 107);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtg_Khoa);
            this.Controls.Add(this.btn_UpdateKhoa);
            this.Controls.Add(this.btn_DeleteKhoa);
            this.Controls.Add(this.btn_AddKhoa);
            this.Controls.Add(this.txt_TenKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_QuanLyKhoa);
            this.Name = "frm_Khoa";
            this.Text = "Quản lý khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QuanLyKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.TextBox txt_TenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddKhoa;
        private System.Windows.Forms.Button btn_DeleteKhoa;
        private System.Windows.Forms.Button btn_UpdateKhoa;
        private System.Windows.Forms.DataGridView dtg_Khoa;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Button btn_Search;
    }
}

