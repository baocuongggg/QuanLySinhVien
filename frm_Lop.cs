using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLySinhVien
{
    public partial class frm_Lop : Form
    {
        public frm_Lop()
        {
            InitializeComponent();
            loadKhoa();
            loadNienKhoa();
            loadDatagirdView();
        }

        public void loadKhoa()
        {
            cmb_ListKhoa.Text = "--- Chọn ---";
            cmb_ListKhoa.DataSource = BUS_Khoa.loadDanhSachKhoa();
            cmb_ListKhoa.DisplayMember = "TenKhoa";
            cmb_ListKhoa.ValueMember = "MaKhoa";
        }

        public void loadNienKhoa()
        {
            cmb_ListNienKhoa.Text = "--- Chọn ---";
            cmb_ListNienKhoa.DataSource = BUS_NienKhoa.loadDanhSachNienKhoa();
            cmb_ListNienKhoa.DisplayMember = "TenNienKhoa";
            cmb_ListNienKhoa.ValueMember = "MaNienKhoa";
        }

        public void loadDatagirdView()
        {
            List<DTO_Lop> listLop = BUS_Lop.loadDanhSachLop();
            if (listLop != null)
            {
                dtg_Lop.DataSource = BUS_Lop.loadDanhSachLop();
                dtg_Lop.Columns[0].HeaderText = "Mã lớp";
                dtg_Lop.Columns[1].HeaderText = "Tên lớp";
                dtg_Lop.Columns[2].HeaderText = "Khoa";
                dtg_Lop.Columns[3].HeaderText = "Niên khóa";
            }
            else dtg_Lop.DataSource = null;

        }

        private void btn_AddLop_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaLop.Text) 
                && !string.IsNullOrEmpty(txt_TenLop.Text))
            {
                DTO_Lop lop = new DTO_Lop();
                lop.MaLop = txt_MaLop.Text;
                lop.TenLop = txt_TenLop.Text;
                lop.MaKhoa = cmb_ListKhoa.SelectedValue.ToString();
                lop.MaNienKhoa = cmb_ListNienKhoa.SelectedValue.ToString();

                if(BUS_Lop.InsertLop(lop))
                {
                    MessageBox.Show("Thêm thành công");
                    txt_MaLop.Text = "";
                    txt_TenLop.Text = "";
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

        private void dtg_Lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtg_Lop.Rows.Count < 1)
            {
                return;
            }
            else
            {
                int indexRows = dtg_Lop.CurrentRow.Index;
                txt_MaLop.Text = dtg_Lop.Rows[indexRows].Cells[0].Value.ToString();
                txt_MaLop.Enabled = false;
                txt_TenLop.Text = dtg_Lop.Rows[indexRows].Cells[1].Value.ToString();
                cmb_ListKhoa.Text = dtg_Lop.Rows[indexRows].Cells[2].Value.ToString();
                cmb_ListNienKhoa.Text = dtg_Lop.Rows[indexRows].Cells[3].Value.ToString();
            }
        }

        private void btn_UpdateLop_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaLop.Text))
            {
                if(!string.IsNullOrEmpty(txt_TenLop.Text))
                {
                    DTO_Lop lopUpdate = new DTO_Lop();
                    lopUpdate.MaLop = txt_MaLop.Text;
                    lopUpdate.TenLop = txt_TenLop.Text;
                    lopUpdate.MaKhoa = cmb_ListKhoa.SelectedValue.ToString();
                    lopUpdate.MaNienKhoa = cmb_ListNienKhoa.SelectedValue.ToString();

                    if(BUS_Lop.UpdateLop(lopUpdate))
                    {
                        MessageBox.Show("Sửa thành công");
                        txt_TenLop.Text = "";
                        txt_MaLop.Enabled = true;
                        txt_MaLop.Text = "";
                        loadDatagirdView();
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

        private void btn_DeleteLop_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaLop.Text))
            {
                DTO_Lop deleteLop = new DTO_Lop();
                deleteLop.MaLop = txt_MaLop.Text;

                if(BUS_Lop.DeleteLop(deleteLop))
                {
                    MessageBox.Show("Xóa thành công");
                    txt_MaLop.Text = "";
                    txt_TenLop.Text = "";
                    txt_MaLop.Enabled = true;
                    loadDatagirdView();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
                return;
            }
        }
    }
}
