namespace QuanLySinhVien
{
    partial class frm_NienKhoa
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
            this.dtg_NienKhoa = new System.Windows.Forms.DataGridView();
            this.btn_UpdateNienKhoa = new System.Windows.Forms.Button();
            this.btn_DeleteNienKhoa = new System.Windows.Forms.Button();
            this.btn_AddNienKhoa = new System.Windows.Forms.Button();
            this.txt_TenNienKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNienKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_QuanLyNienKhoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NienKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(714, 108);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 23;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(280, 108);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 22;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(384, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // dtg_NienKhoa
            // 
            this.dtg_NienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NienKhoa.Location = new System.Drawing.Point(20, 148);
            this.dtg_NienKhoa.Name = "dtg_NienKhoa";
            this.dtg_NienKhoa.RowHeadersWidth = 51;
            this.dtg_NienKhoa.RowTemplate.Height = 24;
            this.dtg_NienKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_NienKhoa.Size = new System.Drawing.Size(768, 292);
            this.dtg_NienKhoa.TabIndex = 20;
            this.dtg_NienKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_NienKhoa_CellContentClick);
            // 
            // btn_UpdateNienKhoa
            // 
            this.btn_UpdateNienKhoa.Location = new System.Drawing.Point(180, 109);
            this.btn_UpdateNienKhoa.Name = "btn_UpdateNienKhoa";
            this.btn_UpdateNienKhoa.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateNienKhoa.TabIndex = 19;
            this.btn_UpdateNienKhoa.Text = "Sửa";
            this.btn_UpdateNienKhoa.UseVisualStyleBackColor = true;
            this.btn_UpdateNienKhoa.Click += new System.EventHandler(this.btn_UpdateNienKhoa_Click);
            // 
            // btn_DeleteNienKhoa
            // 
            this.btn_DeleteNienKhoa.Location = new System.Drawing.Point(99, 109);
            this.btn_DeleteNienKhoa.Name = "btn_DeleteNienKhoa";
            this.btn_DeleteNienKhoa.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteNienKhoa.TabIndex = 18;
            this.btn_DeleteNienKhoa.Text = "Xóa";
            this.btn_DeleteNienKhoa.UseVisualStyleBackColor = true;
            this.btn_DeleteNienKhoa.Click += new System.EventHandler(this.btn_DeleteNienKhoa_Click);
            // 
            // btn_AddNienKhoa
            // 
            this.btn_AddNienKhoa.Location = new System.Drawing.Point(18, 109);
            this.btn_AddNienKhoa.Name = "btn_AddNienKhoa";
            this.btn_AddNienKhoa.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNienKhoa.TabIndex = 17;
            this.btn_AddNienKhoa.Text = "Thêm";
            this.btn_AddNienKhoa.UseVisualStyleBackColor = true;
            this.btn_AddNienKhoa.Click += new System.EventHandler(this.btn_AddNienKhoa_Click);
            // 
            // txt_TenNienKhoa
            // 
            this.txt_TenNienKhoa.Location = new System.Drawing.Point(475, 65);
            this.txt_TenNienKhoa.Multiline = true;
            this.txt_TenNienKhoa.Name = "txt_TenNienKhoa";
            this.txt_TenNienKhoa.Size = new System.Drawing.Size(167, 23);
            this.txt_TenNienKhoa.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(331, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Niên Khóa";
            // 
            // txt_MaNienKhoa
            // 
            this.txt_MaNienKhoa.Location = new System.Drawing.Point(143, 65);
            this.txt_MaNienKhoa.Multiline = true;
            this.txt_MaNienKhoa.Name = "txt_MaNienKhoa";
            this.txt_MaNienKhoa.Size = new System.Drawing.Size(167, 23);
            this.txt_MaNienKhoa.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Niên Khóa";
            // 
            // lbl_QuanLyNienKhoa
            // 
            this.lbl_QuanLyNienKhoa.AutoSize = true;
            this.lbl_QuanLyNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_QuanLyNienKhoa.Location = new System.Drawing.Point(203, 9);
            this.lbl_QuanLyNienKhoa.Name = "lbl_QuanLyNienKhoa";
            this.lbl_QuanLyNienKhoa.Size = new System.Drawing.Size(369, 38);
            this.lbl_QuanLyNienKhoa.TabIndex = 12;
            this.lbl_QuanLyNienKhoa.Text = "QUẢN LÝ NIÊN KHÓA";
            // 
            // frm_NienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtg_NienKhoa);
            this.Controls.Add(this.btn_UpdateNienKhoa);
            this.Controls.Add(this.btn_DeleteNienKhoa);
            this.Controls.Add(this.btn_AddNienKhoa);
            this.Controls.Add(this.txt_TenNienKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaNienKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_QuanLyNienKhoa);
            this.Name = "frm_NienKhoa";
            this.Text = "frm_NienKhoa";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NienKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtg_NienKhoa;
        private System.Windows.Forms.Button btn_UpdateNienKhoa;
        private System.Windows.Forms.Button btn_DeleteNienKhoa;
        private System.Windows.Forms.Button btn_AddNienKhoa;
        private System.Windows.Forms.TextBox txt_TenNienKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaNienKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_QuanLyNienKhoa;
    }
}