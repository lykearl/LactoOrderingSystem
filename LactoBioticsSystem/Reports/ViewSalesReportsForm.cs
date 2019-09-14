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
            toggleDatePickerVisibility(false);
            cmbbox_filter.SelectedIndex = 0;
        }

        private void BtnPrintSalesReports_Click(object sender, EventArgs e)
        {
            new Reports.ViewSalesReport(filteredSalesReport).ShowDialog();
        }

        private void Datepicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            updateSalesReportTable();
        }
        private void Datepicker_enddate_ValueChanged(object sender, EventArgs e)
        {
            updateSalesReportTable();
        }
        private void updateSalesReportTable()
        {
            filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date >= datepicker_startDate.Value.Date && sales.date_.Value.Date <= datepicker_enddate.Value.Date.Date select sales);
            dgvSalesInventory.DataSource = filteredSalesReport;
            dgvSalesInventory.Refresh();
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            toggleDatePickerVisibility(false);
            switch (cmbbox_filter.Text)
            {
                case "Daily": filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date == DateTime.Now.Date select sales); break;
                case "Weekly": filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date >= DateTime.Now.AddDays(-7) && sales.date_.Value.Date <= DateTime.Now.Date select sales); break;
                case "Monthly": filteredSalesReport = (from sales in db.SalesReports where sales.date_.Value.Date >= DateTime.Now.AddMonths(-1).Date && sales.date_.Value.Date <= DateTime.Now.Date select sales); break;
                case "Custom": toggleDatePickerVisibility(true);break;
            }
            dgvSalesInventory.DataSource = filteredSalesReport;
            dgvSalesInventory.Refresh();
        }
        private void toggleDatePickerVisibility(bool boolean)
        {
            datepicker_startDate.Visible = boolean;
            datepicker_enddate.Visible = boolean;
        }
    }
}
