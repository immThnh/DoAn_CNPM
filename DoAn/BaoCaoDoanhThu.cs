using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn.BaoCao
{
    public partial class BaoCaoDoanhThu : Form
    {
        private readonly MonAnReport report = new MonAnReport();
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private async Task render()
        {
            List<MonAnReport> list = new List<MonAnReport>();
            MonAnReport report = new MonAnReport();
            list = await report.getListByTime(DateTime.Now);
            reportViewer1.LocalReport.ReportPath = "D:\\Code\\C#\\Do_An\\DoAn\\DoAn\\ThongKe.rdlc";
            var source = new ReportDataSource("MonAnDataSet", list);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

        }
        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

            _ = Task.Run(async () => await render());
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
