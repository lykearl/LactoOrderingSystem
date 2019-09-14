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
        public ViewSalesReportsForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewSalesReportsForm_Load(object sender, EventArgs e)
        {
            dgvSalesInventory.DataSource = db.sp_view_SalesReports();
        }

        private void BtnPrintSalesReports_Click(object sender, EventArgs e)
        {
            new Reports.ViewSalesReport().ShowDialog();
        }
    }
}
