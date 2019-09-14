using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Products_Management
{
    public partial class UpdateStocksForm : Form
    {
        public UpdateStocksForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStocksForm_Load(object sender, EventArgs e)
        {
            txtStockQuantity.Focus();
        }

        private void BtnUpdateStocks_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblStockID.Text == "" || lblstockproID.Text == "" || lblStockproCode.Text == "" || lblStockproName.Text == "" || lblStockCategory.Text == "" ||
                    lblStockproPrice.Text == "" || lblStockDesc.Text == "" || txtStockQuantity.Text == "")
                {
                    MessageBox.Show("Please input all fields", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    db.sp_update_stocks(int.Parse(lblStockID.Text), int.Parse(lblstockproID.Text), int.Parse(txtStockQuantity.Text), DateTime.Now);
                    lblStockID.Text = "";
                    lblstockproID.Text = "";
                    txtStockQuantity.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Label52_Click(object sender, EventArgs e)
        {

        }
    }
}
