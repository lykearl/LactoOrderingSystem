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
    public partial class AddNewStocksForm : Form
    {
        public AddNewStocksForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void TxtSearchPro_TextChanged(object sender, EventArgs e)
        {
            dgvStocksPro.DataSource = db.sp_search_products(txtSearchPro.Text);
        }

        private void AddNewStocksForm_Load(object sender, EventArgs e)
        {
            dgvStocksPro.DataSource = db.sp_view_products();
        }

        private void DgvStocksPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblstockproID.Text = dgvStocksPro.CurrentRow.Cells[0].Value.ToString();
            txtProCode.Text = dgvStocksPro.CurrentRow.Cells[2].Value.ToString();
            txtProName.Text = dgvStocksPro.CurrentRow.Cells[3].Value.ToString();
            txtProPrice.Text = dgvStocksPro.CurrentRow.Cells[5].Value.ToString();
            txtStockQuantity.Focus();
        }

        private void PicboxAdminClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddStocks_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblstockproID.Text == "" || txtProCode.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtStockQuantity.Text == "")
                {
                    MessageBox.Show("Please select a product to add stocks", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    db.sp_add_stocks(int.Parse(lblstockproID.Text), int.Parse(txtStockQuantity.Text), int.Parse(lblUser_id.Text), DateTime.Now);
                    db.sp_add_inventory(int.Parse(lblstockproID.Text), int.Parse(txtStockQuantity.Text), int.Parse(lblUser_id.Text), DateTime.Now);
                    AdminMainForm amf = new AdminMainForm();
                    lblstockproID.Text = "";
                    txtProCode.Text = "";
                    txtProName.Text = "";
                    txtProPrice.Text = "";
                    lblUser_id.Text = "";
                    txtStockQuantity.Text = "";
                    amf.dgvStocks.DataSource = db.sp_view_stocks();
                    this.Hide();
                    MessageBox.Show("Product Stocks successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
