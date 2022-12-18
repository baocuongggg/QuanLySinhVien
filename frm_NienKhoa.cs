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
    public partial class frm_NienKhoa : Form
    {
        public frm_NienKhoa()
        {
            InitializeComponent();
            loadDatagirdView();
        }

        public void loadDatagirdView()
        {
            List<DTO_NienKhoa> listNienKhoa = BUS_NienKhoa.loadDanhSachNienKhoa();
            if (listNienKhoa != null)
            {
                dtg_NienKhoa.DataSource = listNienKhoa;

                dtg_NienKhoa.Columns[0].HeaderText = "Mã niên khoá";
                dtg_NienKhoa.Columns[1].HeaderText = "Tên niên khóa";
            }
            else dtg_NienKhoa.DataSource = null;
        }

        private void btn_AddNienKhoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaNienKhoa.Text) &&
                !string.IsNullOrEmpty(txt_TenNienKhoa.Text))
            {
                DTO_NienKhoa nienKhoa = new DTO_NienKhoa();
                nienKhoa.MaNienKhoa = txt_MaNienKhoa.Text;
                nienKhoa.TenNienKhoa = txt_TenNienKhoa.Text;

                if (BUS_NienKhoa.InsertNienKhoa(nienKhoa) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    // load lại data mới
                    loadDatagirdView();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
        }

        private void dtg_NienKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_NienKhoa.RowCount < 1) return;
            else
            {
                // lấy vị trí hiện tại đang chọn
                int indexRow = dtg_NienKhoa.CurrentRow.Index;
                txt_MaNienKhoa.Text = dtg_NienKhoa.Rows[indexRow].Cells[0].Value.ToString();
                txt_MaNienKhoa.Enabled = false;
                txt_TenNienKhoa.Text = dtg_NienKhoa.Rows[indexRow].Cells[1].Value.ToString();
            }
        }

        private void btn_UpdateNienKhoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaNienKhoa.Text))
            {
                if(!string.IsNullOrEmpty(txt_TenNienKhoa.Text))
                {
                    DTO_NienKhoa nienKhoa = new DTO_NienKhoa();
                    nienKhoa.MaNienKhoa = txt_MaNienKhoa.Text;
                    nienKhoa.TenNienKhoa = txt_TenNienKhoa.Text;

                    if(BUS_NienKhoa.UpdateNienKhoa(nienKhoa) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        // set text = rổng
                        txt_MaNienKhoa.Text = "";
                        txt_TenNienKhoa.Text = "";
                        loadDatagirdView();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn niên khóa cần sửa");
                return;
            }
        }

        private void btn_DeleteNienKhoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaNienKhoa.Text))
            {
                DTO_NienKhoa nienKhoa = new DTO_NienKhoa();
                nienKhoa.MaNienKhoa = txt_MaNienKhoa.Text;

                if(BUS_NienKhoa.DeleteNienKhoa(nienKhoa))
                {
                    MessageBox.Show("Xóa thành công");
                    txt_MaNienKhoa.Text = "";
                    txt_TenNienKhoa.Text = "";
                    loadDatagirdView();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn niên khóa cần xóa");
                return;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                List<DTO_NienKhoa> resultSearch = BUS_NienKhoa.SearchNienKhoa(txtSearch
                    .Text);
                if (resultSearch != null)
                {
                    dtg_NienKhoa.DataSource = resultSearch;
                    txtSearch.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Không tìm ra được kết quả theo từ khóa " + txtSearch.Text);
                    txtSearch.Text = "";
                    return;
                }
            }else{
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm");
                return;
            }
        }
    }
}
