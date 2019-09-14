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
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void PicboxPUclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProductID.Text == "" || txtpro_code.Text == "" || txtpro_name.Text == "" || cmbProCategory.Text == "" || txtpro_price.Text == "")
            {
                MessageBox.Show("Please enter product information", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                    db.sp_update_products(int.Parse(lblProductID.Text), txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, int.Parse(txtpro_price.Text), txtpro_desc.Text, DateTime.Now);
                    lblProductID.Text = "";
                    txtpro_code.Text = "";
                    txtpro_name.Text = "";
                    cmbProCategory.Text = "";
                    txtpro_price.Text = "";
                    txtpro_desc.Text = "";
                    MessageBox.Show("Product successfully Updated!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainForm amf = new AdminMainForm();
                    amf.dgvProducts.DataSource = db.sp_view_products();
                    this.Hide();
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
