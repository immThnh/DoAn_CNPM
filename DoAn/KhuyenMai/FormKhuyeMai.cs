using BLL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = DAL.Model.Menu;

namespace DoAn
{
    public partial class FormKhuyeMai : Form
    {
        private DoAnModels model = new DoAnModels();
        private KhuyenMaiService khuyenMaiService;
        private List<Menu> menuList;
        public FormKhuyeMai()
        {
            InitializeComponent();
            khuyenMaiService = new KhuyenMaiService(model);
            menuList = khuyenMaiService.getMenus();
        }

        private async void FormKhuyeMai_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.RowTemplate.Height = 36;

            //_ = Task.Run(async () => await render());
            await render();
            for (int i = 1; i <= 20; i++)
            {
                cGiamGia.Items.Add(i * 5);
            }

            cGiamGia.SelectedIndex = 0;
        }
        private async Task render()
        {
            renderCBBs();
            dgvKhuyenMai.Rows.Clear();
            DoAnModels model1 = new DoAnModels();
            var khuyenMais = model1.KhuyenMais.ToList();

            foreach (var item in khuyenMais)
            {
                foreach (var monAn in item.MonAns)
                {
                    if (monAn.IDKhuyenMai != null)
                        dgvKhuyenMai.Rows.Add(item.ID, item
                        , monAn.Menu.LoaiMenu, monAn.Ten, item.GiamGia, item.NoiDung);
                }
            }
        }

        private void renderUI()
        {
            tMaKhuyenMai.Text = "";
            tTenKhuyenMai.Text = "";
            cGiamGia.Text = "";
            tNoiDung.Text = "";
            cGiamGia.SelectedIndex = 0;
        }

        private void renderCBBs()
        {


            cDanhMuc.Items.Clear();
            cDanhMuc.Items.Add("Tất cả");
            foreach (var menu in menuList)
            {
                cDanhMuc.Items.Add(menu);

            }
            cDanhMuc.SelectedIndex = 0;

            List<MonAn> monAns = khuyenMaiService.getMonAnsNotKhuyenMai();
            clbMonAn.Items.Clear();
            clbMonAn.Items.AddRange(monAns.ToArray());
            clbMonAn.SelectedItem = 0;
        }

        

        private void btnCapNhatThem_Click(object sender, EventArgs e)
        {
            if (tMaKhuyenMai.Text.Trim() == "" || tTenKhuyenMai.Text.Trim() == "" || cGiamGia.Text.Trim() == ""
                || cDanhMuc.SelectedItem == null || clbMonAn.CheckedItems.Count <= 0 || tNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!validateTenMon(tTenKhuyenMai.Text))
            {
                MessageBox.Show("Tên khuyến mãi không hợp lệ!");
                tTenKhuyenMai.Text = "";
                return;
            }
            List<MonAn> monAns = new List<MonAn>();
            foreach (var i in clbMonAn.CheckedItems)
            {
                MonAn monAn = i as MonAn;
                monAns.Add(monAn);
            }

            khuyenMaiService.addOrUpdate(int.Parse(tMaKhuyenMai.Text.Trim()), tTenKhuyenMai.Text.Trim(),
                int.Parse(cGiamGia.Text.Trim()), tNoiDung.Text.Trim(), monAns);
            render();
            renderUI();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void cDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            Menu menu = comboBox.SelectedItem as Menu;
            if (menu != null)
            {
                var monAns = khuyenMaiService.getMonAnsNotKhuyenMaiByMenuId(menu.ID);
                clbMonAn.Items.Clear();
                clbMonAn.Items.AddRange(monAns.ToArray());
            }
            else
            {
                List<MonAn> monAns = khuyenMaiService.getMonAnsNotKhuyenMai();
                clbMonAn.Items.AddRange(monAns.ToArray());
            }
        }

        private void tGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có muốn xóa không", "Xóa Khuyễn Mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<KhuyenMai> list = new List<KhuyenMai>();
                foreach (DataGridViewRow item in dgvKhuyenMai.SelectedRows)
                {
                    KhuyenMai k = item.Cells[1].Value as KhuyenMai;
                    list.Add(k);
                }
                khuyenMaiService.remove(list);
                render();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];
            KhuyenMai khuyenMai = row.Cells[1].Value as KhuyenMai;
            tMaKhuyenMai.Text = khuyenMai.ID.ToString();
            tTenKhuyenMai.Text = khuyenMai.Ten;
            cGiamGia.Text = khuyenMai.GiamGia.ToString();
            tNoiDung.Text = khuyenMai.NoiDung;
            clbMonAn.Items.Clear();
            int count = 0;
            foreach (var i in khuyenMai.MonAns)
            {
                clbMonAn.Items.Add(i);
                clbMonAn.SetItemChecked(count, true);
                count++;
            }
        }

        private void tMaKhuyenMai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn muốn thoát chức năng ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool validateTenMon(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true; // Tên hợp lệ nếu có ít nhất một ký tự không phải chữ cái
                }
            }
            return false;
        }

        private void tTenKhuyenMai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
