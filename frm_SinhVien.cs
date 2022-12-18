using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace QuanLySinhVien
{
    public partial class frm_SinhVien : Form
    {

        // khai báo biến dùng toàn cục
        public static string imagePath = "";

        public frm_SinhVien()
        {
            InitializeComponent();
            loadLop();
            loadSinhVien();
        }

        public void loadLop()
        {
            cmb_Lop.DataSource = BUS_Lop.loadDanhSachLop();
            cmb_Lop.DisplayMember = "TenLop";
            cmb_Lop.ValueMember = "MaLop";
        }

        public void loadSinhVien()
        {
            if (BUS_SinhVien.loadDanhSachSinhVien() != null)
            {
                dtg_SinhVien.DataSource = BUS_SinhVien.loadDanhSachSinhVien();
                // load lại nam nữ
                // dùng foearch thì item là 1 thằng DTO_SinhVien là 1 thằng SinhVien
                dtg_SinhVien.Columns[0].HeaderText = "Mã SV";
                dtg_SinhVien.Columns[1].HeaderText = "Tên SV";
                dtg_SinhVien.Columns[2].HeaderText = "Năm sinh";
                dtg_SinhVien.Columns[3].HeaderText = "Quê quán";
                dtg_SinhVien.Columns[4].HeaderText = "Số điện thoại";
                dtg_SinhVien.Columns[5].HeaderText = "Giới tính";
                dtg_SinhVien.Columns[6].HeaderText = "Hình ảnh";
                dtg_SinhVien.Columns[7].HeaderText = "Lớp";

                // hidden column image
                dtg_SinhVien.Columns[6].Visible = false;
            }
            else
                dtg_SinhVien.DataSource = null;

        }

        private void btn_AddSV_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaSV.Text) && 
                !string.IsNullOrEmpty(txt_TenSV.Text) && 
                !string.IsNullOrEmpty(txt_QueQuan.Text) && 
                !string.IsNullOrEmpty(txt_SoDienThoai.Text) && 
                rad_Nam.Checked || rad_Nu.Checked 
                && !string.IsNullOrEmpty(imagePath))
            {
                DTO_SinhVien sinhVien = new DTO_SinhVien();
                sinhVien.MaSV = txt_MaSV.Text;
                sinhVien.TenSV = txt_TenSV.Text;
                sinhVien.NamSinh = dt_NgaySinh.Text;
                sinhVien.QueQuan = txt_QueQuan.Text;
                sinhVien.SoDienThoai = txt_SoDienThoai.Text;
                if (rad_Nam.Checked) sinhVien.GioiTinh = rad_Nam.Text;
                else sinhVien.GioiTinh = rad_Nu.Text;

                sinhVien.HinhAnh = imagePath; 
                sinhVien.MaLop = cmb_Lop.SelectedValue.ToString();

                if(BUS_SinhVien.InsertSinhVien(sinhVien))
                {
                    MessageBox.Show("Thêm sinh viên thành công");
                    txt_MaSV.Text = "";
                    txt_TenSV.Text = "";
                    txt_QueQuan.Text = "";
                    txt_SoDienThoai.Text = "";
                    pib_ImageSV.Image = null;

                    loadSinhVien();
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
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
        }

        // hàm xóa dấu tiếng việt
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        public string UploadFile(OpenFileDialog openFile,string idStudent, string nameClass)
        {
            string pathSave = "";
            string thuMucLuu = Application.StartupPath.Replace("bin\\Debug", "Images\\Students");
            openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // uploadFile vào project
                pib_ImageSV.Image = new Bitmap(openFile.FileName);

                // tên file khi lưu
                string fileName = DateTime.Now.ToShortDateString().Replace("/","_") + "_" + RemoveUnicode(txt_TenSV.Text) + "_"+ cmb_Lop.Text + Path.GetExtension(openFile.FileName);
                // đường dẫn file 
                pathSave = Path.Combine(thuMucLuu, fileName);
                // Lưu file
                if(File.Exists(pathSave))
                {
                    File.Delete(pathSave);
                    File.Copy(openFile.FileName, pathSave); // copy file nào 
                }
                else File.Copy(openFile.FileName, pathSave); // copy file nào 
            }
            return pathSave;
        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            
        }

        // check phone 
        public bool CheckPhone(string input)
        {
            string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            if (input != null)
            {
                return Regex.IsMatch(input, motif);
            }
            else return false;
        }

        private void dtg_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_SinhVien.Rows.Count < 1) return;
            else
            {
                int indexRow = dtg_SinhVien.CurrentRow.Index;

                txt_MaSV.Text = dtg_SinhVien.Rows[indexRow].Cells[0].Value.ToString();
                txt_MaSV.Enabled = false;

                txt_TenSV.Text = dtg_SinhVien.Rows[indexRow].Cells[1].Value.ToString();
                dt_NgaySinh.Text = dtg_SinhVien.Rows[indexRow].Cells[2].Value.ToString();
                txt_QueQuan.Text = dtg_SinhVien.Rows[indexRow].Cells[3].Value.ToString();
                txt_SoDienThoai.Text = dtg_SinhVien.Rows[indexRow].Cells[4].Value.ToString();
                if (dtg_SinhVien.Rows[indexRow].Cells[5].Value.ToString() == "Nam")
                    rad_Nam.Checked = true;
                else rad_Nu.Checked = true;

                // lấy đường dẫn ảnh sao khi click vào một cell
                if(imagePath != "")
                {
                    imagePath = dtg_SinhVien.Rows[indexRow].Cells[6].Value.ToString();
                    pib_ImageSV.ImageLocation = dtg_SinhVien.Rows[indexRow].Cells[6].Value.ToString();
                }
                

                cmb_Lop.Text = dtg_SinhVien.Rows[indexRow].Cells[7].Value.ToString();
            }
        }

        // function delete image
        public void DeleteImage(string imagePath)
        {
            if(File.Exists(imagePath))
                File.Delete(imagePath);
        }

        // delete function event 
        private void btn_DeleteSV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaSV.Text))
            {
                DTO_SinhVien sinhVienDelete = new DTO_SinhVien();
                sinhVienDelete.MaSV = txt_MaSV.Text;

                if (BUS_SinhVien.DeleteSinhVien(sinhVienDelete))
                {
                    // thêm code xóa ảnh 
                    DeleteImage(imagePath);
                    MessageBox.Show("Xóa thành công");
                    txt_MaSV.Enabled = true;
                    txt_MaSV.Text = "";
                    txt_TenSV.Text = "";
                    txt_QueQuan.Text = "";
                    txt_SoDienThoai.Text = "";
                    pib_ImageSV.Image = null;
                    loadSinhVien();
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

        private void pib_ImageSV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaSV.Text) 
                && !string.IsNullOrEmpty(cmb_Lop.Text))
            {
                string idStudent = txt_MaSV.Text;
                string nameClass = cmb_Lop.Text;
                imagePath = UploadFile(openFile, idStudent,nameClass);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên và chọn Lớp");
                return;
            }

            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaSV.Enabled = true;
            txt_MaSV.Text = "";
            txt_TenSV.Text = "";
            txt_QueQuan.Text = "";
            dt_NgaySinh.Value = DateTime.Now;
            txt_SoDienThoai.Text = "";
            pib_ImageSV.Image = null; 
        }

        private void btn_UpdateSV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TenSV.Text) &&
                !string.IsNullOrEmpty(txt_QueQuan.Text) &&
                !string.IsNullOrEmpty(txt_SoDienThoai.Text) &&
                rad_Nam.Checked || rad_Nu.Checked)
            {
                // đường dẫn hình ảnh cũ
                string imageOld = BUS_SinhVien.SelectSinhVien(txt_MaSV.Text);
                DTO_SinhVien sinhVien = new DTO_SinhVien();
                sinhVien.MaSV = txt_MaSV.Text;
                sinhVien.TenSV = txt_TenSV.Text;
                sinhVien.NamSinh = dt_NgaySinh.Text;
                sinhVien.QueQuan = txt_QueQuan.Text;
                sinhVien.SoDienThoai = txt_SoDienThoai.Text;
                if (rad_Nam.Checked) sinhVien.GioiTinh = rad_Nam.Text;
                else sinhVien.GioiTinh = rad_Nu.Text;

                /* nếu hình ảnh củ giống với mới thì lấy ảnh củ
                 ngược lại thì lấy ảnh mới
                 */
                if (imageOld != imagePath) sinhVien.HinhAnh = imageOld;
                else sinhVien.HinhAnh = imagePath;

                sinhVien.MaLop = cmb_Lop.SelectedValue.ToString();


                if (BUS_SinhVien.UpdateSinhVien(sinhVien))
                {
                    MessageBox.Show("Sửa sinh viên thành công");
                    txt_MaSV.Text = "";
                    txt_TenSV.Text = "";
                    txt_QueQuan.Text = "";
                    txt_SoDienThoai.Text = "";
                    pib_ImageSV.Image = null;

                    loadSinhVien();
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
                MessageBox.Show("Vui lòng sửa đủ thông tin");
                return;
            }
        }
    }
}
