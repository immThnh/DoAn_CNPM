using BLL;
using DAL.DTO;
using DAL.Model;
using DoAn.BaoCao;
using DoAn.MonAns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoAn
{
    public partial class FormMain : Form
    {
        private MonAnService monAnService = new MonAnService();
        private List<MonAnInHoaDon> monAnsInHoaDons = new List<MonAnInHoaDon>();
        private HoaDonService hoaDonService = new HoaDonService();
        private Form currentForm;
        private bool isAddingOrRemoving = false;
        private List<int> soLuongs = new List<int>();
        private List<MonAn> monAns = new List<MonAn>();

        public FormMain()
        {
            InitializeComponent();
        }

        #region
        private void quanLyKhuyênMaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhuyeMai formKhuyeMai = new FormKhuyeMai();
            formKhuyeMai.Show();
        }

        public void openChilrenForm(Form childForm)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pMid.Controls.Add(childForm);
            pMid.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }



        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu baoCao = new BaoCaoDoanhThu();
            openChilrenForm(baoCao);
        }
        private void btnKM_Click(object sender, EventArgs e)
        {
            FormKhuyeMai khuyeMai = new FormKhuyeMai();
            openChilrenForm(khuyeMai);
        }

        private void btnKM_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.FromArgb(214, 156, 82);
            button.Cursor = Cursors.Hand;
        }

        private void btnKM_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Default;

        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu baocao = new BaoCaoDoanhThu();
            openChilrenForm(baocao);
        }
        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            pMid.AutoScroll = true;
            pMid.AutoSize = true;
            pMid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            pMid.BackgroundImage = global::DoAn.Properties.Resources.backgournd;
            pMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pMid.Controls.Add(this.label4);
            pMid.Controls.Add(this.label3);
            pMid.Controls.Add(this.btnXoaHoaDon);
            pMid.Dock = System.Windows.Forms.DockStyle.Fill;
            pMid.Location = new System.Drawing.Point(0, 67);
            pMid.Name = "pMid";
            pMid.Size = new System.Drawing.Size(1589, 736);
            pMid.TabIndex = 3;
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            FrmGoiMons form = new FrmGoiMons();
            openChilrenForm(form);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            FrmHoaDon form = new FrmHoaDon();
            openChilrenForm(form);
        }

        private void btnQLMA_Click(object sender, EventArgs e)
        {
            FrmMonAn form = new FrmMonAn();
            openChilrenForm(form);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            FrmGoiMons form = new FrmGoiMons();
            openChilrenForm(form);
        }
    }
}
