using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Customers_Management
{
    public partial class ViewCustomersForm : Form
    {
        public ViewCustomersForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void DgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearchCust_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = db.sp_search_customer(txtSearchCust.Text);
        }

        private void ViewCustomersForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = db.sp_view_customer();
        }
    }
}
