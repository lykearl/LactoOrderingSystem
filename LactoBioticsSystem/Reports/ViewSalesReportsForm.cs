using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem
{
    public partial class ViewSalesReportsForm : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        IQueryable<SalesReport> filteredSalesReport;
        public ViewSalesReportsForm()
        {
            InitializeComponent();
        }
        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewSalesReportsForm_Load(object sender, EventArgs e)
        {
            cmbbox_salesReportFilter.SelectedIndex = 0;
        }

        private void BtnPrintSalesReports_Click(object sender, EventArgs e)
        {
            new Reports.ViewSalesReport(filteredSalesReport).ShowDialog();
        }

        private void Cmbbox_salesReportFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbbox_salesReportFilter.Text)
            {
                case "Daily": filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date == DateTime.Now.Date select sales); break;
                case "Weekly": filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date >= DateTime.Now.AddDays(-7).Date && sales.date_.Value.Date <= DateTime.Now.Date select sales); break;
                case "Month": filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date >= DateTime.Now.AddMonths(-1).Date && sales.date_.Value.Date <= DateTime.Now.Date select sales); break;
            }
            dgvSalesInventory.DataSource = filteredSalesReport;
            dgvSalesInventory.Refresh();
        }
    }
}
