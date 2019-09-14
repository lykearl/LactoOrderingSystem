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
    public partial class ViewInventoryReportsForm : Form
    {
        public ViewInventoryReportsForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void ViewInventoryForm_Load(object sender, EventArgs e)
        {
            dgvInventory.DataSource = db.sp_select_stocks_inventory();
        }

        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrintInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
