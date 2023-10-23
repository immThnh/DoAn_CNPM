using BLL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.MonAns
{
    public partial class FrmMonAn : Form
    {
        private readonly MonAnService monAnService = new MonAnService();
        private readonly MenuService menuService = new MenuService();

        public FrmMonAn()
        {
            InitializeComponent();

        }

      
        private const string folderAnh = "AnhMonAn";
       
        private void QuanLiMonAn_Load(object sender, EventArgs e)
        {
            var listMonAn = monAnService.getAll();
            var listMenu = menuService.GetALL();
            XuatDanhSach(listMonAn);
            Dulieu(listMenu);
         
        }

        private string ChuyenDoiSangTien(double money)
        {
            return string.Format("{0:N0} VNĐ", money);
        }

        private double ChuyenDoiSangSo(string tien)
        {
            string chiSo = Regex.Replace(tien, @"[^0-9.,]+", "");

            chiSo = chiSo.Replace(",", "");

            double soTien;
            if (double.TryParse(chiSo, out soTien))
            {
                return soTien;
            }
          
                return 0; 
        }


        public void Dulieu(List<DAL.Model.Menu> listmenu)
        {
            this.cbThucDon.DataSource = listmenu;
            this.cbThucDon.DisplayMember = "LoaiMenu";
            this.cbThucDon.ValueMember = "ID";

        }

        public void XuatDanhSach(List<MonAn> listMonAn)
        {
            dgvDS.Rows.Clear();

            foreach (var item in listMonAn)
            {
                int index = dgvDS.Rows.Add(item);
                dgvDS.Rows[index].Cells[0].Value = item.ID;
                dgvDS.Rows[index].Cells[1].Value = item.Ten;
                dgvDS.Rows[index].Cells[2].Value = item.Menu.LoaiMenu;
                dgvDS.Rows[index].Cells[3].Value = ChuyenDoiSangTien(item.GiaGoc);
                dgvDS.Rows[index].Cells[4].Value = ChuyenDoiSangTien(item.GiaSauGiam);
                if (item.Anh != null)
                {
                    if (File.Exists(getDuongDan(item.Anh)))
                    {
                        Image image = Image.FromFile(getDuongDan(item.Anh));
                        dgvDS.Rows[index].Cells[5].Value = image;
                    }
                    else
                    {
                        dgvDS.Rows[index].Cells[5].Value = null; 
                    }
                }

            }
        }

        private string getDuongDan(string relativePath)
        {
            string duongDanToiProj = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            return Path.Combine(duongDanToiProj, relativePath);
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDS.Rows[e.RowIndex];

                string thuDon = selectedRow.Cells[2].Value.ToString();
                int monAnId = Convert.ToInt32(selectedRow.Cells[0].Value);
                string tenMonAn = selectedRow.Cells[1].Value.ToString();
                double donGia = ChuyenDoiSangSo(selectedRow.Cells[3].Value.ToString());


                if (selectedRow.Cells[5].Value != null)
                {
                    if (selectedRow.Cells[5].Value is Image image)
                    {
                        pictureBox1.Image = image;
                    }
                    else if (selectedRow.Cells[5].Value is string imagePath)
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                }
                else
                    pictureBox1.Image = null;


                cbThucDon.Text = thuDon;
                txtMaMonAn.Text = monAnId.ToString();
                txtTenMonAn.Text = tenMonAn;
                txtDonGia.Text = donGia.ToString();
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg)|*.gif;*.jpg; *.jpeg)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonAn.Text) ||
            string.IsNullOrWhiteSpace(txtMaMonAn.Text) ||
            string.IsNullOrWhiteSpace(txtDonGia.Text) ||
            cbThucDon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }


            int maMonAn = int.Parse(txtMaMonAn.Text);
            int maMenu = int.Parse(cbThucDon.SelectedValue.ToString());
            string tenMonAn = txtTenMonAn.Text;
            bool trangThai = false;
           
            int donGia = int.Parse(txtDonGia.Text);

            string imagePath = pictureBox1.ImageLocation;
            if (imagePath != null)
            {
                string tenFileAnh = Path.GetFileName(imagePath);
                string folder = folderAnh;

                string duongDanTuongDoi = Path.Combine(folder, tenFileAnh);
                monAnService.CapNhatHoacThem(maMonAn, maMenu, tenMonAn, trangThai, donGia, duongDanTuongDoi);

            }
            else
            {
                monAnService.CapNhatHoacThem(maMonAn, maMenu, tenMonAn, trangThai, donGia);
            }

            MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK);
            var listMonAn = monAnService.getAll();
            XuatDanhSach(listMonAn);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbThucDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui long chọn dòng cần xóa!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa Món Ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            List<int> ids = new List<int>();
            foreach (DataGridViewRow i in dgvDS.SelectedRows)
            {
                int id = int.Parse(i.Cells[0].Value.ToString());
                ids.Add(id);
            }

            monAnService.removeList(ids);
            MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK);

            var listMonAn = monAnService.getALL();
            XuatDanhSach(listMonAn);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
