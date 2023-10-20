using BLL;
using DAL.DTO;
using DAL.Model;
using DoAn.BaoCao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FrmGoiMons : Form
    {
        public FrmGoiMons()
        {
            InitializeComponent();
        }

        private MonAnService monAnService = new MonAnService();
        private List<MonAnInHoaDon> monAnsInHoaDons = new List<MonAnInHoaDon>();
        private HoaDonService hoaDonService = new HoaDonService();
        private Form currentForm;
        private bool isAddingOrRemoving = false;
        private List<int> soLuongs = new List<int>();

        private List<MonAn> monAns = new List<MonAn>();
        double tongTienThanhToan = 0;

        #region
        private void quanLyKhuyênMaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhuyeMai formKhuyeMai = new FormKhuyeMai();
            formKhuyeMai.Show();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;
            for (int i = 1; i < 11; i++)
            {
                soLuongs.Add(i);
            }

            lTime.Text = DateTime.Now.ToString("dddd, MM - yyyy");
            render();
        }

        private string getDuongDan(string relativePath)
        {
            string duongDanToiProj = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            return Path.Combine(duongDanToiProj, relativePath);
        }

        private void render()
        {
            monAns = monAnService.getAll();
            dataGridView2.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 50;
            foreach (var item in monAns)
            {
                int index = dataGridView1.Rows.Add(item);
                dataGridView1.Rows[index].Cells[0].Value = false;

                if (item.Anh != null)
                {
                    Image image = Image.FromFile(getDuongDan(item.Anh));
                    dataGridView1.Rows[index].Cells[1].Value = image;
                }
                dataGridView1.Rows[index].Cells[2].Value = item;
                dataGridView1.Rows[index].Cells[3].Value = ChuyenDoiSangTien(item.GiaGoc);
                dataGridView1.Rows[index].Cells[4].Value = ChuyenDoiSangTien(item.GiaSauGiam);
            }
        }

        private void bindGridMonAn(List<MonAn> monAns)
        {
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Rows.Clear();
            foreach (var item in monAns)
            {
                int index = dataGridView1.Rows.Add(item);
                dataGridView1.Rows[index].Cells[0].Value = false;

                if (item.Anh != null)
                {
                    Image image = Image.FromFile(getDuongDan(item.Anh));
                    dataGridView1.Rows[index].Cells[1].Value = image;
                }
                dataGridView1.Rows[index].Cells[2].Value = item;
                dataGridView1.Rows[index].Cells[3].Value = ChuyenDoiSangTien(item.GiaGoc);
                dataGridView1.Rows[index].Cells[4].Value = ChuyenDoiSangTien(item.GiaSauGiam);
            }
        }

        private string ChuyenDoiSangTien(double money)
        {
            return string.Format("{0:N0} VNĐ", money);
        }



        private void bindGridHoaDon(List<MonAnInHoaDon> list)
        {
            dataGridView2.Rows.Clear();
            
            foreach (var i in list)
            {
                int index = dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells[0].Value = i;

                dataGridView2.Rows[index].Cells[1].Value = i.SoLuong.ToString();

                tongTienThanhToan += i.TongTien;
                dataGridView2.Rows[index].Cells[2].Value = i.TongTien;
            }
            txtTongTien.Text = ChuyenDoiSangTien(tongTienThanhToan);
        }

        private MonAnInHoaDon convert(MonAn m)
        {
            MonAnInHoaDon m1 = new MonAnInHoaDon();
            m1.MonAn = m;
            m1.SoLuong = 1;
            m1.TongTien = m1.SoLuong * m1.MonAn.GiaSauGiam;
            return m1;
        }

        private bool isContain(MonAnInHoaDon m)
        {
            foreach (var i in monAnsInHoaDons)
            {
                if (i.MonAn.ID == m.MonAn.ID)
                {
                    return true;
                }
            }
            return false;
        }

        private void removeFormList(MonAnInHoaDon m)
        {
            for (int i = 0; i < monAnsInHoaDons.Count; i++)
            {
                if (monAnsInHoaDons[i].MonAn.ID == m.MonAn.ID)
                {
                    monAnsInHoaDons.Remove(monAnsInHoaDons[i]);
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                int rowIndex = e.RowIndex;
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                bool checkedValue = (bool)cell.Value;
                MonAn m = dataGridView1.Rows[rowIndex].Cells[2].Value as MonAn;
                MonAnInHoaDon m1 = convert(m);

                if (checkedValue)
                {
                    monAnsInHoaDons.Add(m1);
                    bindGridHoaDon(monAnsInHoaDons);
                    MessageBox.Show("Chọn món ăn thành công!");
                }
                else
                {
                    if (isContain(m1))
                    {
                        removeFormList(m1);
                        bindGridHoaDon(monAnsInHoaDons);
                        MessageBox.Show("Bỏ chọn món ăn thành công!");
                    }

                }

            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private double capNhatSoLuong(string name, int SoLuong)
        {
            for (int i = 0; i < monAnsInHoaDons.Count; i++)
            {
                if (monAnsInHoaDons[i].MonAn.Ten == name)
                {
                    monAnsInHoaDons[i].SoLuong = SoLuong;
                    monAnsInHoaDons[i].TongTien = SoLuong * monAnsInHoaDons[i].MonAn.GiaSauGiam;
                    tongTienThanhToan = 0;
                    foreach (var item in monAnsInHoaDons)
                    {
                        tongTienThanhToan += item.TongTien;
                    }
                    txtTongTien.Text = ChuyenDoiSangTien(tongTienThanhToan);
                    return monAnsInHoaDons[i].TongTien;
                }
            }
            return 0;
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= new EventHandler(cbb_SelectedIndexChanged);
                    comboBox.SelectedIndexChanged += new EventHandler(cbb_SelectedIndexChanged);
                }
            }
        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            ComboBox comboBox = (ComboBox)sender;
            int soLuong = int.Parse(comboBox.SelectedItem.ToString());
            dataGridView2.Rows[rowIndex].Cells[2].Value = capNhatSoLuong(dataGridView2.Rows[rowIndex].Cells[0].Value.ToString(), soLuong);
        }
        #endregion

        private void unCheckedAllDGV()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (monAnsInHoaDons.Count == 0)
            {
                MessageBox.Show("Danh sách gọi món trống!");
                return;
            }
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Đặt Món", "Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (hoaDonService.LuuHoaDon(DateTime.Now, monAnsInHoaDons))
                {
                    MessageBox.Show("Lưu thông tin hóa đơn thành công!");
                    monAnsInHoaDons = new List<MonAnInHoaDon>();
                    dataGridView2.Rows.Clear();
                    tongTienThanhToan = 0;
                    txtTongTien.Text = "";
                    unCheckedAllDGV();
                }
                else
                {
                    MessageBox.Show("Lưu thông tin thất bại!");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()))
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSapXep.SelectedIndex == 0)
            {
                monAns = monAns.OrderBy(i => i.Ten).ToList();
            }
            else if (cbbSapXep.SelectedIndex == 1)
            {
                monAns = monAns.OrderBy(i => i.GiaSauGiam).ToList();
            }
            else
            {
                monAns = monAns.OrderByDescending(i => i.GiaSauGiam).ToList();
            }
            bindGridMonAn(monAns);

        }



        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if(monAnsInHoaDons.Count == 0)
            {
                MessageBox.Show("Danh sách gọi món trống!");
                return;
            }
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Xóa danh sách gọi món", "XÓA TẤT CẢ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Xóa thành công!");
                monAnsInHoaDons = new List<MonAnInHoaDon>();
                dataGridView2.Rows.Clear();
                tongTienThanhToan = 0;
                txtTongTien.Text = "";
                unCheckedAllDGV();
            }
        }
       
    }
}
