using DAL.DTO;
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

namespace DoAn
{
    public partial class FrmInHoaDon : Form
    {
        private List<MonAnInHoaDon> list;
        public FrmInHoaDon()
        {
            InitializeComponent();
        }
        public FrmInHoaDon(List<MonAnInHoaDon> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "InHoaDon.rdlc"; //nhớ copy report ra debug
            var reportDataSource = new ReportDataSource("HoaDonDataSet", list); //đúng tên dataset trong thiết kế
            this.reportViewer1.LocalReport.DataSources.Clear(); 
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

    }
}
