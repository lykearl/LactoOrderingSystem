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
    public partial class ProductAddForm : Form
    {

        public static int catSoap;
        public static int catDogFood;
        public static int catHerbal;
        public ProductAddForm()
        {
            InitializeComponent();4
            catSoap = (from soap in db.products where soap.product_category == "Soap" select soap).Count();
            catDogFood = (from dogFood in db.products where dogFood.product_category == "Dog Food" select dogFood).Count();
            catHerbal = (from herbal in db.products where herbal.product_category == "Herbal Medicine" select herbal).Count();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProCategory.Text == "" || txtpro_code.Text == "" || txtpro_name.Text == "" || txtpro_price.Text == "" || txtpro_desc.Text == "")
                {

                    MessageBox.Show("Please enter product information", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (cmbProCategory.Text == "Soap")
                    {
                        catSoap++;
                        db.sp_add_products(int.Parse(lblUserID.Text), txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, int.Parse(txtpro_price.Text), txtpro_desc.Text, DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.sp_view_products();
                        this.Hide();
                    }
                    else if (cmbProCategory.Text == "Dog Food")
                    {
                        catDogFood++;
                        db.sp_add_products(int.Parse(lblUserID.Text), txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, int.Parse(txtpro_price.Text), txtpro_desc.Text, DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.sp_view_products();
                        this.Hide();
                    }
                    else if (cmbProCategory.Text == "Herbal Medicine")
                    {
                        catHerbal++;
                        db.sp_add_products(int.Parse(lblUserID.Text), txtpro_code.Text, txtpro_name.Text, cmbProCategory.Text, int.Parse(txtpro_price.Text), txtpro_desc.Text, DateTime.Now);
                        txtpro_code.Text = "";
                        txtpro_name.Text = "";
                        cmbProCategory.Text = "";
                        txtpro_price.Text = "";
                        txtpro_desc.Text = "";
                        MessageBox.Show("Product successfully Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.dgvProducts.DataSource = db.sp_view_products();
                        this.Hide();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PicboxPAclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {

        }

        private void CmbProCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public int GenerateSoapCode()
        {
            return Convert.ToChar(db.spGenerateSoapProCode());
        }
        public int GenerateHerbalCode()
        {
            return Convert.ToChar(db.spGenerateHerbalProCode());
        }
        public int GenerateDogFoodCode()
        {
            return Convert.ToChar(db.spGenerateDogFoodProCode());
        }
        private void CmbProCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProCategory.Text == "Soap")
            {
                txtpro_code.Text = "SP-" + catSoap.ToString();

                //if (GenerateSoapCode() == 1)
                //{
                //    txtpro_code.Text = "SP-" + (GenerateSoapCode().ToString().PadLeft(8, '0'));
                //}
                //else
                //{
                //    txtpro_code.Text = "SP-" + (GenerateSoapCode() + 1).ToString().PadLeft(8, '0');
                //}
            }
            if (cmbProCategory.Text == "Dog Food")
            {
                txtpro_code.Text = "DF-" + catDogFood.ToString();

                //if (GenerateDogFoodCode() == 1)
                //{
                //    txtpro_code.Text = "DF-" + (GenerateDogFoodCode().ToString().PadLeft(8, '0'));
                //}
                //else
                //{
                //    txtpro_code.Text = "DF-" + (GenerateDogFoodCode() + 1).ToString().PadLeft(8, '0');
                //}
            }

            if (cmbProCategory.Text == "Herbal Medicine")
            {
                txtpro_code.Text = "HM-" + catHerbal.ToString();
                //if (GenerateHerbalCode() == 1)
                //{
                //    txtpro_code.Text = "HM-" + (GenerateHerbalCode().ToString().PadLeft(8, '0'));
                //}
                //else
                //{
                //    txtpro_code.Text = "HM-" + (GenerateHerbalCode  () + 1).ToString().PadLeft(8, '0');
                //}
            }

        }
    }
}
