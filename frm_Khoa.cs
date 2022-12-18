using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_Khoa : Form
    {
        public frm_Khoa()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        void LoadDanhSach()
        {
            List<DTO_Khoa> listKhoa = BUS_Khoa.loadDanhSachKhoa();
            if(listKhoa != null)
            {
                dtg_Khoa.DataSource = listKhoa;
                // set text column datagirdview
                dtg_Khoa.Columns[0].HeaderText = "Mã khoa";
                dtg_Khoa.Columns[1].HeaderText = "Tên khoa";
            }
            else dtg_Khoa.DataSource = null;

        }

        private void btn_AddKhoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaKhoa.Text) && !string.IsNullOrEmpty(txt_TenKhoa.Text))
            {
                DTO_Khoa khoa = new DTO_Khoa();
                khoa.MaKhoa = txt_MaKhoa.Text;
                khoa.TenKhoa = txt_TenKhoa.Text;
                if(BUS_Khoa.InsertKhoa(khoa) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDanhSach();
                    return;
                }
                else 
                    MessageBox.Show("Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void dtg_Khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Khoa.Rows.Count < 1) return;
            else
            {
                // lấy vị trí hiện tại trong datagirdview
                int indexY = dtg_Khoa.CurrentRow.Index;
                // lấy ở row đang chọn và cột 0 cột 1
                txt_MaKhoa.Text = dtg_Khoa.Rows[indexY].Cells[0].Value.ToString();
                // không cho sữa mã
                txt_MaKhoa.Enabled = false;
                txt_TenKhoa.Text = dtg_Khoa.Rows[indexY].Cells[1].Value.ToString();
            }
        }

        private void btn_UpdateKhoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaKhoa.Text))
            {
                if (!string.IsNullOrEmpty(txt_TenKhoa.Text))
                {
                    DTO_Khoa khoa = new DTO_Khoa();
                    khoa.MaKhoa = txt_MaKhoa.Text;
                    khoa.TenKhoa = txt_TenKhoa.Text;

                    if (BUS_Khoa.UpdateKhoa(khoa) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadDanhSach();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa");
                return;
            }
            
        }

        private void btn_DeleteKhoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_MaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khoa muốn xóa");
                return;
            }
            else
            {
                DTO_Khoa khoa = new DTO_Khoa();
                khoa.MaKhoa = txt_MaKhoa.Text;
                if (BUS_Khoa.DeleteKhoa(khoa) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    txt_MaKhoa.Enabled = true;
                    txt_MaKhoa.Text = "";
                    txt_TenKhoa.Text = "";
                    LoadDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                List<DTO_Khoa> dataSearch = BUS_Khoa.SearchKhoa(txtSearch.Text);
                if (dataSearch != null)
                {
                    dtg_Khoa.DataSource = dataSearch;
                    txtSearch.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Không tìm ra theo từ khóa " + txtSearch.Text);
                    txtSearch.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm");
                return;
            }
        }
    }
}
