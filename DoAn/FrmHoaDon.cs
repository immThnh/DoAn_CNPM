using BLL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FrmHoaDon : Form
    {
        private readonly HoaDonService hoaDonService = new HoaDonService();
        private List<HoaDon> hoaDons= new List<HoaDon>();
        public FrmHoaDon()
        {
            InitializeComponent();
            hoaDons = hoaDonService.getALL();
            XuatDanhSach(hoaDons);
        }

      
        public void XuatDanhSach(List<HoaDon> list)
        {
            dgvHD.Rows.Clear();

            foreach (var item in list)
            {
                int index = dgvHD.Rows.Add(item);
                dgvHD.Rows[index].Cells[0].Value = item.ID;
                dgvHD.Rows[index].Cells[1].Value = item.NgayThanhToan.ToString("hh:mm:ss tt dd/MM/yyyy"); ;

                DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                cell.DataSource = item.ChiTietHoaDons.ToList();
                cell.DisplayMember = "CustomDisplay";
                cell.ValueMember = "ID";
                cell.Style.BackColor = Color.LightGray;
                dgvHD.Rows[index].Cells[2] = cell;

                if (item.ChiTietHoaDons.Count > 0)
                {
                    cell.Value = item.ChiTietHoaDons.ToList()[0].ID;
                }

                dgvHD.Rows[index].Cells[3].Value = ChuyenDoiSangTien(item.TongTien);
            }
        }
        private string ChuyenDoiSangTien(double money)
        {
            return string.Format("{0:N0} VNĐ", money);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cbbSapXep.SelectedIndex == 0)
           {
                hoaDons = hoaDons.OrderBy(i => i.NgayThanhToan).ToList();
           }
            else if(cbbSapXep.SelectedIndex == 1)
            {
                hoaDons = hoaDons.OrderByDescending(i => i.NgayThanhToan).ToList();
            }
           else if(cbbSapXep.SelectedIndex == 2)
            {
                hoaDons = hoaDons.OrderBy(i => i.TongTien).ToList();

            }
            else
            {
                hoaDons = hoaDons.OrderByDescending(i => i.TongTien).ToList();

            }
            XuatDanhSach(hoaDons);

        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void TimKiemTheoNgay(DateTime ngayCanTim)
        {
            List<HoaDon> result = hoaDons.Where(hd => hd.NgayThanhToan.Date == ngayCanTim.Date).ToList();
            XuatDanhSach(result);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayTimKiem = dateTimePicker1.Value;
            TimKiemTheoNgay(ngayTimKiem);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvHD.Rows.Count; i++)
            {
                dgvHD.Rows[i].Visible = true;
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHD.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }
            List<int> indexs = new List<int>();
            foreach (DataGridViewRow row in dgvHD.SelectedRows) 
            {
                indexs.Add(int.Parse(row.Cells[0].Value.ToString()));
            }
            hoaDonService.xoaListHoaDon(indexs);
            MessageBox.Show("XÓA THÀNH CÔNG!");
            hoaDons = hoaDonService.getALL();
            XuatDanhSach(hoaDons);
        }
    }
}
