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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        int IndexRow;
        public string TextWithcomma { get; set; }
        public string TextWithoutcomma { get; set; }
        public string SkipComma(string str)
        {

            string[] ss = null;
            string strnew = "";
            if (str == "")
            {
                strnew = "0";
            }
            else
            {
                ss = str.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    strnew += ss[i];
                }
            }
            return strnew;
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            dgvUsersAcc.DataSource = db.sp_view_acc();
            dgvCustomersAcc.DataSource = db.sp_view_customer();
            dgvProducts.DataSource = db.sp_view_products();
            dgvStocks.DataSource = db.sp_view_stocks();
            dgvCustDelivery.DataSource = db.sp_select_delivery();
            dgvCustReservation.DataSource = db.sp_select_reservation();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();



            //if (lblUsersType.Text == "Administrator")
            //{
            //    btnUserReg.Enabled = true;
            //    btnProReg.Enabled = true;
            //    btnReport.Enabled = true;
            //    btnReports.Enabled = true;
            //    btnUsersReg.Enabled = true;
            //    btnProdReg.Enabled = true;
            //}
            //else
            //{
            //    btnUserReg.Enabled = false;
            //    btnProReg.Enabled = false;
            //    btnReport.Enabled = false;
            //    btnReports.Enabled = false;
            //    btnUsersReg.Enabled = false;
            //    btnProdReg.Enabled = false;
            //}
            //else
            //{

            //}
            //if (lblUsertype.Text == "Staff")
            //{
            //    groupBox7.Visible = false;
            //    groupBox11.Visible = false;
            //}
        }

        private void BtnCostOrder_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
            cmbTranType.Focus();
        }

        private void BtnUserReg_Click(object sender, EventArgs e)
        {
            pnlUser_reg.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnCustReg_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlHeader.Show();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnProReg_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlPro_reg.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            pnlStocks.Show();
            pnlHeader.Show();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            pnlReports.Show();
            pnlHeader.Show();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            pnlAdminMenu.Show();
            pnlSystemTitle.Show();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlPro_reg.Hide();
            pnlHeader.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnCOrder_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnUsersReg_Click(object sender, EventArgs e)
        {
            pnlUser_reg.Show();
            pnlHeader.Show();
            pnlCust_reg.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnCustRegs_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlHeader.Show();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnProdReg_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlPro_reg.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlStocks.Show();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            pnlReports.Show();
            pnlHeader.Show();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Logout?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void PicboxAdClose_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Logout?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a User Account to Activate", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Activate this User Account?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txtuserstatus.Text = "Active";
                        db.sp_update_acc(int.Parse(labelUserID.Text), txtusername.Text, txtuserpass.Text, txtusertype.Text, txtlastname.Text,
                         txtfirstname.Text, txtemail.Text, txtuserstatus.Text, txtsecretQ.Text, txtsecretA.Text, DateTime.Now);
                        labelUserID.Text = "";
                        txtusername.Text = "";
                        txtuserpass.Text = "";
                        txtusertype.Text = "";
                        txtlastname.Text = "";
                        txtfirstname.Text = "";
                        txtemail.Text = "";
                        txtuserstatus.Text = "";
                        txtsecretQ.Text = "";
                        txtsecretA.Text = "";
                        dgvUsersAcc.DataSource = db.sp_view_acc();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
        }

        private void BtnDisactivate_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a User Account to Deactivate", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txtusertype.Text == "Administrator")
                {
                    MessageBox.Show("Administrator account cannot be Deactivate", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Deactivate this User Account?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtuserstatus.Text = "Deactivate";
                            db.sp_update_acc(int.Parse(labelUserID.Text), txtusername.Text, txtuserpass.Text, txtusertype.Text, txtlastname.Text,
                             txtfirstname.Text, txtemail.Text, txtuserstatus.Text, txtsecretQ.Text, txtsecretA.Text, DateTime.Now);
                            labelUserID.Text = "";
                            txtusername.Text = "";
                            txtuserpass.Text = "";
                            txtusertype.Text = "";
                            txtlastname.Text = "";
                            txtfirstname.Text = "";
                            txtemail.Text = "";
                            txtuserstatus.Text = "";
                            txtsecretQ.Text = "";
                            txtsecretA.Text = "";
                            dgvUsersAcc.DataSource = db.sp_view_acc();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void TxtsearchUser_TextChanged(object sender, EventArgs e)
        {
            dgvUsersAcc.DataSource = db.sp_search_user_acc(txtsearchUser.Text);
        }

        private void DgvUsersAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelUserID.Text = dgvUsersAcc.CurrentRow.Cells[0].Value.ToString();
            txtusername.Text = dgvUsersAcc.CurrentRow.Cells[1].Value.ToString();
            txtuserpass.Text = dgvUsersAcc.CurrentRow.Cells[2].Value.ToString();
            txtusertype.Text = dgvUsersAcc.CurrentRow.Cells[3].Value.ToString();
            txtfirstname.Text = dgvUsersAcc.CurrentRow.Cells[4].Value.ToString();
            txtlastname.Text = dgvUsersAcc.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = dgvUsersAcc.CurrentRow.Cells[6].Value.ToString();
            txtuserstatus.Text = dgvUsersAcc.CurrentRow.Cells[7].Value.ToString();
            txtsecretQ.Text = dgvUsersAcc.CurrentRow.Cells[8].Value.ToString();
            txtsecretA.Text = dgvUsersAcc.CurrentRow.Cells[9].Value.ToString();
            txtuserpass.Show();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Users_Management.UsersRegistrationForm urf = new Users_Management.UsersRegistrationForm();
            urf.Show();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a user account to update!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Users_Management.UsersUpdateForm uuf = new Users_Management.UsersUpdateForm();
                uuf.lblUser_ID.Text = dgvUsersAcc.CurrentRow.Cells[0].Value.ToString();
                uuf.txtuname.Text = dgvUsersAcc.CurrentRow.Cells[1].Value.ToString();
                uuf.txtpass.Text = dgvUsersAcc.CurrentRow.Cells[2].Value.ToString();
                uuf.txtuserType.Text = dgvUsersAcc.CurrentRow.Cells[3].Value.ToString();
                uuf.txtlname.Text = dgvUsersAcc.CurrentRow.Cells[4].Value.ToString();
                uuf.txtfname.Text = dgvUsersAcc.CurrentRow.Cells[5].Value.ToString();
                uuf.txtemail.Text = dgvUsersAcc.CurrentRow.Cells[6].Value.ToString();
                uuf.cmbstatus.Text = dgvUsersAcc.CurrentRow.Cells[7].Value.ToString();
                uuf.cmbQuest.Text = dgvUsersAcc.CurrentRow.Cells[8].Value.ToString();
                uuf.txtans.Text = dgvUsersAcc.CurrentRow.Cells[9].Value.ToString();
                uuf.Show();
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (labelUserID.Text == "" || txtusername.Text == "" || txtuserpass.Text == "" || txtusertype.Text == "" ||
                txtemail.Text == "" || txtemail.Text == "" || txtsecretQ.Text == "" || txtsecretA.Text == "")
            {
                MessageBox.Show("Please select a User Account to Delete", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txtusertype.Text == "Administrator")
                {
                    MessageBox.Show("Administrator account cannot be deleted", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.sp_delete_acc(int.Parse(labelUserID.Text));
                            labelUserID.Text = "";
                            labelUserID.Text = "";
                            txtusername.Text = "";
                            txtuserpass.Text = "";
                            txtusertype.Text = "";
                            txtlastname.Text = "";
                            txtfirstname.Text = "";
                            txtemail.Text = "";
                            txtuserstatus.Text = "";
                            txtsecretQ.Text = "";
                            txtsecretA.Text = "";
                            dgvUsersAcc.DataSource = db.sp_view_acc();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void BtnRefreshUser_Click(object sender, EventArgs e)
        {
            dgvUsersAcc.DataSource = db.sp_view_acc();
            labelUserID.Text = "";
            txtusername.Text = "";
            txtuserpass.Text = "";
            txtusertype.Text = "";
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txtemail.Text = "";
            txtuserstatus.Text = "";
            txtsecretQ.Text = "";
            txtsecretA.Text = "";
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Products_Management.ProductAddForm proadd = new Products_Management.ProductAddForm();
            proadd.lblUserID.Text = lblUserID.Text;
            proadd.Show();
        }

        private void BtnUpdatePro_Click(object sender, EventArgs e)
        {
            if (labelProductID.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtProCat.Text == "" || txtProDesc.Text == "" || txtProCode.Text == "")
            {
                MessageBox.Show("Please select a product to update!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Products_Management.ProductUpdateForm puf = new Products_Management.ProductUpdateForm();
                puf.lblProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                puf.txtpro_code.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                puf.txtpro_name.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                puf.cmbProCategory.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                puf.txtpro_price.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
                puf.txtpro_desc.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
                puf.cmbProCategory.Focus();
                puf.Show();

            }
        }

        private void BtnRefreshPro_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = db.sp_view_products();
            labelProductID.Text = "";
            txtProCode.Text = "";
            txtProName.Text = "";
            txtProCat.Text = "";
            txtProPrice.Text = "";
            txtProDesc.Text = "";
        }

        private void BtnDeletePro_Click(object sender, EventArgs e)
        {
            if (labelProductID.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtProCat.Text == "" || txtProDesc.Text == "" || txtProCode.Text == "")
            {
                MessageBox.Show("Please select product to delete", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.sp_remove_products(int.Parse(labelProductID.Text));
                        labelProductID.Text = "";
                        txtProCode.Text = "";
                        txtProName.Text = "";
                        txtProCat.Text = "";
                        txtProPrice.Text = "";
                        txtProDesc.Text = "";
                        dgvProducts.DataSource = db.sp_view_products();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = db.sp_search_products(txtSearchProducts.Text);
        }

        private void DgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtProCode.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtProName.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtProCat.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            txtProPrice.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            txtProDesc.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
        }

        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            Customer_Management.CustomerRegistrationForm crf = new Customer_Management.CustomerRegistrationForm();
            crf.lblUserID.Text = lblUserID.Text;
            crf.Show();
        }

        private void BtnUpdateCust_Click(object sender, EventArgs e)
        {
            if (labelCustomerID.Text == "" || txtCustName.Text == "" || txtCustAdd.Text == "" || txtCustCont.Text == "" || txtCustType.Text == "")
            {
                MessageBox.Show("Please select a customer to update!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Customer_Management.CustomerUpdateForm cuf = new Customer_Management.CustomerUpdateForm();
                cuf.lblCust_ID.Text = dgvCustomersAcc.CurrentRow.Cells[0].Value.ToString();
                cuf.txtName.Text = dgvCustomersAcc.CurrentRow.Cells[1].Value.ToString();
                cuf.txtTin.Text = dgvCustomersAcc.CurrentRow.Cells[2].Value.ToString();
                cuf.txtAddress.Text = dgvCustomersAcc.CurrentRow.Cells[3].Value.ToString();
                cuf.txtBstyle.Text = dgvCustomersAcc.CurrentRow.Cells[4].Value.ToString();
                cuf.txtContact.Text = dgvCustomersAcc.CurrentRow.Cells[5].Value.ToString();
                cuf.cmbuCType.Text = dgvCustomersAcc.CurrentRow.Cells[6].Value.ToString();
                cuf.Show();
            }
        }

        private void BtnRefereshCust_Click(object sender, EventArgs e)
        {
            dgvCustomersAcc.DataSource = db.sp_view_customer();
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            if (labelCustomerID.Text == "" || txtCustName.Text == "" || txtCustAdd.Text == "" || txtCustCont.Text == "" || txtCustType.Text == "")
            {
                MessageBox.Show("Please Select a Customer to delete", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.sp_remove_customer(int.Parse(labelCustomerID.Text));
                        labelCustomerID.Text = "";
                        txtCustName.Text = "";
                        txtCustAdd.Text = "";
                        txtCustCont.Text = "";
                        txtCustType.Text = "";
                        dgvCustomersAcc.DataSource = db.sp_view_customer();
                    }

                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void TxtsearchCustomer_TextChanged(object sender, EventArgs e)
        {
            dgvCustomersAcc.DataSource = db.sp_search_customer(txtsearchCustomer.Text);
        }

        private void DgvCustomersAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelCustomerID.Text = dgvCustomersAcc.CurrentRow.Cells[0].Value.ToString();
            txtCustName.Text = dgvCustomersAcc.CurrentRow.Cells[1].Value.ToString();
            txtCustTin.Text = dgvCustomersAcc.CurrentRow.Cells[2].Value.ToString();
            txtCustAdd.Text = dgvCustomersAcc.CurrentRow.Cells[3].Value.ToString();
            txtCustBstyle.Text = dgvCustomersAcc.CurrentRow.Cells[4].Value.ToString();
            txtCustCont.Text = dgvCustomersAcc.CurrentRow.Cells[5].Value.ToString();
            txtCustType.Text = dgvCustomersAcc.CurrentRow.Cells[6].Value.ToString();
        }

        private void Txtstocks_TextChanged(object sender, EventArgs e)
        {
            dgvStocks.DataSource = db.sp_search_stocks(txtstocks.Text);
        }

        private void DgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblStock_ID.Text = dgvStocks.CurrentRow.Cells[0].Value.ToString();
            lblPro_ID.Text = dgvStocks.CurrentRow.Cells[1].Value.ToString();
            txtProdCode.Text = dgvStocks.CurrentRow.Cells[2].Value.ToString();
            txtProdName.Text = dgvStocks.CurrentRow.Cells[3].Value.ToString();
            txtProdCat.Text = dgvStocks.CurrentRow.Cells[4].Value.ToString();
            txtProdPrice.Text = dgvStocks.CurrentRow.Cells[5].Value.ToString();
            txtProdStock.Text = dgvStocks.CurrentRow.Cells[6].Value.ToString();
            txtProdDesc.Text = dgvStocks.CurrentRow.Cells[7].Value.ToString();
        }

        private void BtnAddStocks_Click(object sender, EventArgs e)
        {
            Products_Management.AddNewStocksForm ans = new Products_Management.AddNewStocksForm();
            ans.lblUser_id.Text = lblUserID.Text;
            ans.Show();
        }

        private void BtnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblStock_ID.Text == "" || lblPro_ID.Text == "" || txtProdCode.Text == "" || txtProdName.Text == "" || txtProdCat.Text == "" ||
                    txtProdPrice.Text == "" || txtProdDesc.Text == "")
                {
                    MessageBox.Show("Please select stock to update", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Products_Management.UpdateStocksForm usf = new Products_Management.UpdateStocksForm();
                    usf.lblStockID.Text = dgvStocks.CurrentRow.Cells[0].Value.ToString();
                    usf.lblstockproID.Text = dgvStocks.CurrentRow.Cells[1].Value.ToString();
                    usf.lblStockproCode.Text = dgvStocks.CurrentRow.Cells[2].Value.ToString();
                    usf.lblStockproName.Text = dgvStocks.CurrentRow.Cells[3].Value.ToString();
                    usf.lblStockCategory.Text = dgvStocks.CurrentRow.Cells[4].Value.ToString();
                    usf.lblStockproPrice.Text = dgvStocks.CurrentRow.Cells[5].Value.ToString();
                    usf.lblStockDesc.Text = dgvStocks.CurrentRow.Cells[6].Value.ToString();
                    usf.txtStockQuantity.Focus();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnDeleteStock_Click(object sender, EventArgs e)
        {
            if (lblStock_ID.Text == "" || lblPro_ID.Text == "" || txtProCode.Text == "" || txtProdName.Text == "" || txtProdCat.Text == "" ||
                txtProdPrice.Text == "" || txtProdDesc.Text == "")
            {
                MessageBox.Show("Please select stock to delete", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                db.sp_delete_stocks(int.Parse(lblStock_ID.Text));
                lblStock_ID.Text = "";
                dgvStocks.DataSource = db.sp_view_stocks();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvStocks.DataSource = db.sp_view_stocks();
        }

        private void BtnInventoryReports_Click(object sender, EventArgs e)
        {
            ViewInventoryReportsForm virf = new ViewInventoryReportsForm();
            virf.Show();
        }

        private void BtnSalesReports_Click(object sender, EventArgs e)
        {
            ViewSalesReportsForm vsrf = new ViewSalesReportsForm();
            vsrf.Show();
        }

        private void BtnSelectPro_Click(object sender, EventArgs e)
        {
            Products_Management.ViewProductsForm pview = new Products_Management.ViewProductsForm();
            pview.ShowInTaskbar = false;
            pview.Location = new Point(275, 160);
            DialogResult aa = pview.ShowDialog();
            if (aa == DialogResult.OK)
            {
                lblStockID.Text = pview.dgvStocks.CurrentRow.Cells[1].Value.ToString();
                lblProID.Text = pview.dgvStocks.CurrentRow.Cells[2].Value.ToString();
                txtpro_name.Text = pview.dgvStocks.CurrentRow.Cells[4].Value.ToString();
                txtpro_price.Text = pview.dgvStocks.CurrentRow.Cells[6].Value.ToString();
                txtpro_stock.Text = pview.dgvStocks.CurrentRow.Cells[7].Value.ToString();
                txtpro_quantity.Focus();
            }
        }

        private void BtnSelectCust_Click(object sender, EventArgs e)
        {
            Customers_Management.ViewCustomersForm cview = new Customers_Management.ViewCustomersForm();
            cview.ShowInTaskbar = false;
            cview.Location = new Point(275, 160);
            DialogResult aa = cview.ShowDialog();
            if (aa == DialogResult.OK)
            {
                lblCustID.Text = cview.dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                txtcust_name.Text = cview.dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                lblTin.Text = cview.dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                txtcust_address.Text = cview.dgvCustomer.CurrentRow.Cells[5].Value.ToString();
                lblBstyle.Text = cview.dgvCustomer.CurrentRow.Cells[6].Value.ToString();
                lblCustType.Text = cview.dgvCustomer.CurrentRow.Cells[8].Value.ToString();
                txtpro_quantity.Focus();
            }
        }

        private void CmbTranType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTranType.Text == "Purchase Order")
            {
                gbWalkin.Show();
                dgvAddToCart.Show();
                btnAddDelivery.Enabled = false;
            }
            else
            {
                gbWalkin.Hide();
                dgvAddToCart.Hide();
                btnAddDelivery.Enabled = true;
                lblProID.Text = "";
                txtpro_name.Clear();
                txtpro_price.Clear();
                txtpro_stock.Clear();
                lblCustID.Text = "";
                txtCustName.Clear();
                txtcust_address.Clear();
                txtcash.Clear();
                txtAmount.Clear();
                txtchange.Clear();
            }
            if (cmbTranType.Text == "Reservation")
            {
                dtpClaimDate.Show();
                lblClaimDate.Show();
                dgvReservation.Show();
                gbReservation.Show();
            }
            else
            {
                dtpClaimDate.Hide();
                lblClaimDate.Hide();
                dgvReservation.Hide();
                gbReservation.Hide();
                lblProID.Text = "";
                txtpro_name.Clear();
                txtpro_price.Clear();
                txtpro_stock.Clear();
                lblCustID.Text = "";
                txtCustName.Clear();
                txtcust_address.Clear();
                txtcash.Clear();
                txtAmount.Clear();
                txtchange.Clear();
            }
            if (cmbTranType.Text == "Delivery")
            {
                dtpDateDel.Show();
                lblDateDel.Show();
                dgvDelivery.Show();
                gbDelivery.Show();
                txtcash.Visible = false;
                txtchange.Visible = false;
                lblCash.Visible = false;
                lblChange.Visible = false;
            }
            else
            {
                dtpDateDel.Hide();
                lblDateDel.Hide();
                dgvDelivery.Hide();
                gbDelivery.Hide();
                txtcash.Visible = true;
                txtchange.Visible = true;
                lblCash.Visible = true;
                lblChange.Visible = true;
                lblProID.Text = "";
                txtpro_name.Clear();
                txtpro_price.Clear();
                txtpro_stock.Clear();
                lblCustID.Text = "";
                txtCustName.Clear();
                txtcust_address.Clear();
                txtcash.Clear();
                txtAmount.Clear();
                txtchange.Clear();
            }
        }

        private void Txtcash_TextChanged(object sender, EventArgs e)
        {
            double changed = 0.0;

            try
            {
                double TotalAmount = double.Parse(txtAmount.Text);
                double Cash = double.Parse(txtcash.Text);
                changed = Cash - TotalAmount;
                txtchange.Text = changed.ToString();
            }
            catch
            { }

            if (txtcash.Text == "")
            {
                txtcash.Text = null;
                TextWithcomma = "0";
                TextWithoutcomma = "0";

            }
            else
            {

                if (txtcash.Text != "")
                {
                    double d = Convert.ToDouble(SkipComma(txtcash.Text));
                    txtcash.Text = d.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
                    TextWithcomma = txtcash.Text;
                    TextWithoutcomma = SkipComma(txtcash.Text);
                }

                txtcash.Select(txtcash.Text.Length, 0);
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtpro_stock.Text == "")
                {
                    MessageBox.Show("Please select a product!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtpro_quantity.Focus();
                }
                else
                {

                    if (txtpro_quantity.Text == "")
                    {
                        MessageBox.Show("Please Input order quantity!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtpro_quantity.Focus();
                    }
                    else
                    {
                        if (cmbTranType.Text == "")
                        {
                            MessageBox.Show("Please Select Transaction type!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtpro_quantity.Focus();
                        }
                        else
                        {
                            decimal Proprice = decimal.Parse(txtpro_price.Text);
                            int Pquantity = int.Parse(txtpro_quantity.Text);
                            int StockonHand = int.Parse(txtpro_stock.Text);
                            int StRemain = 0;
                            decimal TotalAmount = 0;
                            if
                           (Pquantity > StockonHand)
                            {

                                MessageBox.Show("Item being purchased must not exceed the stocks on hand!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txtpro_quantity.Focus();
                            }
                            else
                            {
                                if (txtcust_name.Text == "" || txtcust_address.Text == "")
                                {
                                    MessageBox.Show("Please select a customer information!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    txtcust_name.Focus();
                                }
                                else
                                {
                                    if (int.Parse(txtpro_quantity.Text) <= 0)
                                    {
                                        MessageBox.Show("Number must be positive", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        txtpro_quantity.Text = "";
                                    }
                                    else
                                    {

                                        TotalAmount = Proprice * Pquantity;

                                        StRemain = StockonHand - Pquantity;
                                        dgvAddToCart.Rows.Add(lblProID.Text, txtpro_name.Text, Proprice, Pquantity, TotalAmount, txtcust_name.Text, txtcust_address.Text, DateTime.Now, cmbTranType.Text, lblCustID.Text, lblUserID.Text);
                                        DataGridViewRow newDataRow = dgvStocks.Rows[IndexRow];
                                        newDataRow.Cells[7].Value = StRemain.ToString();

                                        decimal Total = 0;
                                        for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                                        {
                                            Total += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
                                        }
                                        StRemain = StockonHand - Pquantity;
                                        db.sp_update_stocks_pro(int.Parse(lblProID.Text), int.Parse(txtpro_quantity.Text));
                                        MessageBox.Show("Product successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtAmount.Text = Total.ToString();

                                        lblProID.Text = "";
                                        txtpro_name.Text = "";
                                        txtpro_price.Text = "";
                                        txtpro_stock.Text = "";
                                        txtpro_quantity.Text = "";
                                        txtcash.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvAddToCart.Rows.Remove(dgvAddToCart.CurrentRow);
                    foreach (DataGridViewRow row in dgvAddToCart.SelectedRows)
                    {
                        int cancelQuantity = int.Parse(row.Cells[3].Value.ToString());
                        string productID = row.Cells[0].Value.ToString();
                        db.sp_cancel_order(cancelQuantity, productID); ;
                        dgvAddToCart.DataSource = db.sp_view_stocks();
                        dgvAddToCart.Rows.Remove(row);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvAddToCart.Rows.Add(dgvAddToCart.CurrentRow);
                }
            }
            catch { }
        }

        private void BtnPrintOrder_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please select purchase order!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txtcash.Text == "" || txtchange.Text == "")
                {
                    MessageBox.Show("Please input amount of cash to pay!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    decimal cash = decimal.Parse(txtcash.Text);
                    int amount = int.Parse(txtAmount.Text);
                    if (cash < amount)
                    {
                        MessageBox.Show("Cash is not enough to purchase products!.", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                        {
                            var salesReport = new SalesReport
                            {
                                productID = int.Parse(dgvAddToCart.Rows[i].Cells[0].Value.ToString()),
                                order_quantity = int.Parse(dgvAddToCart.Rows[i].Cells[3].Value.ToString()),
                                TotalAmount = decimal.Parse(dgvAddToCart.Rows[i].Cells[4].Value.ToString()),
                                date_ = DateTime.Parse(dgvAddToCart.Rows[i].Cells[7].Value.ToString()),
                                transactiontype = dgvAddToCart.Rows[i].Cells[8].Value.ToString(),
                                customer_id = int.Parse(dgvAddToCart.Rows[i].Cells[9].Value.ToString()),
                                users_id = int.Parse(dgvAddToCart.Rows[i].Cells[10].Value.ToString())
                            };
                            db.SalesReports.InsertOnSubmit(salesReport);
                        }

                        db.SubmitChanges();
                        lblProID.Text = "";
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtpro_stock.Text = "";
                        txtpro_quantity.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = "";
                        txtcash.Text = "";
                        txtAmount.Text = "";
                        txtchange.Text = "";
                        dgvAddToCart.Rows.Clear();



                        //for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
                        //{
                        //    db.sp_add_SalesReports(Convert.ToInt32(dgvAddToCart.Rows[i].Cells[0].Value), Convert.ToInt32(dgvAddToCart.Rows[i].Cells[3].Value), Convert.ToInt32(dgvAddToCart.Rows[i].Cells[4].Value), Convert.ToString(dgvAddToCart.Rows[i].Cells[8].Value), int.Parse(lblCustID.Text), int.Parse(lblUserID.Text), DateTime.Now);
                        //}
                        //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
                        //objPPdialog.Document = printDocument1;
                        //objPPdialog.ShowDialog();

                        //PrintDialog printDialog = new PrintDialog();
                        //printDialog.Document = printDocument1;
                        //printDialog.UseEXDialog = true;


                        //if (DialogResult.OK == printDialog.ShowDialog())
                        //{
                        //    printDocument1.DocumentName = "Printing Receipt";
                        //    printDocument1.Print();

                        //}
                    }
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void DgvAddToCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProID.Text = dgvAddToCart.CurrentRow.Cells[0].Value.ToString();
            txtpro_name.Text = dgvAddToCart.CurrentRow.Cells[1].Value.ToString();
            txtpro_price.Text = dgvAddToCart.CurrentRow.Cells[2].Value.ToString();
            txtpro_quantity.Text = dgvAddToCart.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dgvAddToCart.CurrentRow.Cells[4].Value.ToString();
            txtcust_name.Text = dgvAddToCart.CurrentRow.Cells[5].Value.ToString();
            txtcust_address.Text = dgvAddToCart.CurrentRow.Cells[6].Value.ToString();
            cmbTranType.Text = dgvAddToCart.CurrentRow.Cells[8].Value.ToString();
            lblCustID.Text = dgvAddToCart.CurrentRow.Cells[9].Value.ToString();
        }

        private void PnlCustOrder_Paint(object sender, PaintEventArgs e)
        {
            decimal Total = 0;
            for (int i = 0; i < dgvAddToCart.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvAddToCart.Rows[i].Cells[4].Value);
            }
            txtAmount.Text = Total.ToString();
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvAddToCart.Rows.Remove(dgvAddToCart.CurrentRow);
                    foreach (DataGridViewRow row in dgvAddToCart.SelectedRows)
                    {
                        int cancelQuantity = int.Parse(row.Cells[3].Value.ToString());
                        string productID = row.Cells[0].Value.ToString();
                        db.sp_cancel_order(cancelQuantity, productID); ;
                        dgvAddToCart.DataSource = db.sp_view_stocks();
                        dgvAddToCart.Rows.Remove(row);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvAddToCart.Rows.Add(dgvAddToCart.CurrentRow);
                }
            }
            catch { }
        }

        private void BtnAddDelivery_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtpro_stock.Text == "")
                {
                    MessageBox.Show("Please select a product!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtpro_quantity.Focus();
                }
                else
                {

                    if (txtpro_quantity.Text == "")
                    {
                        MessageBox.Show("Please Input order quantity!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtpro_quantity.Focus();
                    }
                    else
                    {
                        if (lblCustType.Text == "Walk-in Client")
                        {
                            MessageBox.Show("Walk-in Clients cannot transact in products delivery!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            decimal Proprice = decimal.Parse(txtpro_price.Text);
                            int Pquantity = int.Parse(txtpro_quantity.Text);
                            int StockonHand = int.Parse(txtpro_stock.Text);
                            int StRemain = 0;
                            decimal TotalAmount = 0;
                            if
                           (Pquantity > StockonHand)
                            {

                                MessageBox.Show("Item being purchased must not exceed the stocks on hand!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txtpro_quantity.Focus();
                            }
                            else
                            {
                                if (txtcust_name.Text == "" || txtcust_address.Text == "")
                                {
                                    MessageBox.Show("Please select a customer information!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    txtcust_name.Focus();
                                }
                                else
                                {
                                    if (int.Parse(txtpro_quantity.Text) <= 0)
                                    {
                                        MessageBox.Show("Number must be positive", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        txtpro_quantity.Text = "";
                                    }
                                    else
                                    {
                                        lblDelStatus.Text = "Not Delivered";
                                        TotalAmount = Proprice * Pquantity;

                                        StRemain = StockonHand - Pquantity;
                                        dgvDelivery.Rows.Add(lblProID.Text, txtpro_name.Text, Proprice, Pquantity, TotalAmount, txtcust_name.Text, txtcust_address.Text, dtpDateDel.Value, cmbTranType.Text, DateTime.Now, lblCustID.Text, lblUserID.Text, lblDelStatus.Text);
                                        DataGridViewRow newDataRow = dgvStocks.Rows[IndexRow];
                                        newDataRow.Cells[7].Value = StRemain.ToString();

                                        decimal Total = 0;
                                        for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                                        {
                                            Total += Convert.ToDecimal(dgvDelivery.Rows[i].Cells[4].Value);
                                        }
                                        StRemain = StockonHand - Pquantity;
                                        db.sp_update_stocks_pro(int.Parse(lblProID.Text), int.Parse(txtpro_quantity.Text));
                                        MessageBox.Show("Product successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtAmount.Text = Total.ToString();

                                        lblProID.Text = "";
                                        txtpro_name.Text = "";
                                        txtpro_price.Text = "";
                                        txtpro_stock.Text = "";
                                        txtpro_quantity.Text = "";
                                        txtcash.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnResPro_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtpro_name.Text == "" || txtpro_price.Text == "" || txtpro_stock.Text == "")
                {
                    MessageBox.Show("Please select a product!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtpro_quantity.Focus();
                }
                else
                {


                    if (txtpro_quantity.Text == "")
                    {
                        MessageBox.Show("Please Input order quantity!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtpro_quantity.Focus();
                    }
                    else
                    {
                        if (lblCustType.Text == "Walk-in Client")
                        {
                            MessageBox.Show("Walk-in Clients cannot transact in products reservation!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            decimal Proprice = decimal.Parse(txtpro_price.Text);
                            int Pquantity = int.Parse(txtpro_quantity.Text);
                            int StockonHand = int.Parse(txtpro_stock.Text);
                            int StRemain = 0;
                            decimal TotalAmount = 0;
                            if
                           (Pquantity > StockonHand)
                            {

                                MessageBox.Show("Item being purchased must not exceed the stocks on hand!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txtpro_quantity.Focus();
                            }
                            else
                            {
                                if (txtcust_name.Text == "" || txtcust_address.Text == "")
                                {
                                    MessageBox.Show("Please select a customer information!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    txtcust_name.Focus();
                                }
                                else
                                {
                                    if (int.Parse(txtpro_quantity.Text) <= 0)
                                    {
                                        MessageBox.Show("Number must be positive", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        txtpro_quantity.Text = "";
                                    }
                                    else
                                    {
                                        lblResStatus.Text = "Unclaim";
                                        TotalAmount = Proprice * Pquantity;

                                        StRemain = StockonHand - Pquantity;
                                        dgvReservation.Rows.Add(lblProID.Text, txtpro_name.Text, Proprice, Pquantity, TotalAmount, txtcust_name.Text, txtcust_address.Text, dtpClaimDate.Value, cmbTranType.Text, DateTime.Now, lblCustID.Text, lblUserID.Text, lblResStatus.Text);
                                        DataGridViewRow newDataRow = dgvStocks.Rows[IndexRow];
                                        newDataRow.Cells[7].Value = StRemain.ToString();

                                        decimal Total = 0;
                                        for (int i = 0; i < dgvReservation.Rows.Count; i++)
                                        {
                                            Total += Convert.ToDecimal(dgvReservation.Rows[i].Cells[4].Value);
                                        }
                                        StRemain = StockonHand - Pquantity;
                                        db.sp_update_stocks_pro(int.Parse(lblProID.Text), int.Parse(txtpro_quantity.Text));
                                        MessageBox.Show("Product successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtAmount.Text = Total.ToString();

                                        lblProID.Text = "";
                                        txtpro_name.Text = "";
                                        txtpro_price.Text = "";
                                        txtpro_stock.Text = "";
                                        txtpro_quantity.Text = "";
                                        txtcash.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void DgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please select purchase order!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                {
                    var salesReport = new SalesReport
                    {
                        productID = int.Parse(dgvDelivery.Rows[i].Cells[0].Value.ToString()),
                        order_quantity = int.Parse(dgvDelivery.Rows[i].Cells[3].Value.ToString()),
                        TotalAmount = decimal.Parse(dgvDelivery.Rows[i].Cells[4].Value.ToString()),
                        transactiontype = dgvDelivery.Rows[i].Cells[8].Value.ToString(),
                        date_ = DateTime.Parse(dgvDelivery.Rows[i].Cells[9].Value.ToString()),
                        customer_id = int.Parse(dgvDelivery.Rows[i].Cells[10].Value.ToString()),
                        users_id = int.Parse(dgvDelivery.Rows[i].Cells[11].Value.ToString())
                    };
                    db.SalesReports.InsertOnSubmit(salesReport);
                }
                for (int i = 0; i < dgvDelivery.Rows.Count; i++)
                {
                    var delivery = new ProductsDelivery
                    {
                        productID = int.Parse(dgvDelivery.Rows[i].Cells[0].Value.ToString()),
                        order_quantity = int.Parse(dgvDelivery.Rows[i].Cells[3].Value.ToString()),
                        totalPrice = decimal.Parse(dgvDelivery.Rows[i].Cells[4].Value.ToString()),
                        Delivery_Date = DateTime.Parse(dgvDelivery.Rows[i].Cells[7].Value.ToString()),
                        transactiontype = dgvDelivery.Rows[i].Cells[8].Value.ToString(),
                        Date_ = DateTime.Parse(dgvDelivery.Rows[i].Cells[9].Value.ToString()),
                        customer_id = int.Parse(dgvDelivery.Rows[i].Cells[10].Value.ToString()),
                        users_id = int.Parse(dgvDelivery.Rows[i].Cells[11].Value.ToString()),
                        deliveryStatus = dgvDelivery.Rows[i].Cells[12].Value.ToString()

                    };
                    db.ProductsDeliveries.InsertOnSubmit(delivery);
                    dgvCustDelivery.DataSource = db.sp_select_delivery();
                }
                db.SubmitChanges();
                lblProID.Text = "";
                txtpro_name.Text = "";
                txtpro_price.Text = "";
                txtpro_stock.Text = "";
                txtpro_quantity.Text = "";
                lblCustID.Text = "";
                txtcust_name.Text = "";
                txtcust_address.Text = "";
                txtcash.Text = "";
                txtAmount.Text = "";
                txtchange.Text = "";
                dgvDelivery.Rows.Clear();
            }
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please select purchase order!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txtcash.Text == "" || txtchange.Text == "")
                {
                    MessageBox.Show("Please input amount of cash to pay!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    decimal cash = decimal.Parse(txtcash.Text);
                    int amount = int.Parse(txtAmount.Text);
                    if (cash < amount)
                    {
                        MessageBox.Show("Cash is not enough to purchase products!.", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        for (int i = 0; i < dgvReservation.Rows.Count; i++)
                        {
                            var salesReport = new SalesReport
                            {
                                productID = int.Parse(dgvReservation.Rows[i].Cells[0].Value.ToString()),
                                order_quantity = int.Parse(dgvReservation.Rows[i].Cells[3].Value.ToString()),
                                TotalAmount = decimal.Parse(dgvReservation.Rows[i].Cells[4].Value.ToString()),
                                transactiontype = dgvReservation.Rows[i].Cells[8].Value.ToString(),
                                date_ = DateTime.Parse(dgvReservation.Rows[i].Cells[9].Value.ToString()),
                                customer_id = int.Parse(dgvReservation.Rows[i].Cells[10].Value.ToString()),
                                users_id = int.Parse(dgvReservation.Rows[i].Cells[11].Value.ToString())
                            };
                            db.SalesReports.InsertOnSubmit(salesReport);
                        }
                        for (int i = 0; i < dgvReservation.Rows.Count; i++)
                        {
                            var reservation = new ProductsReservation
                            {
                                productID = int.Parse(dgvReservation.Rows[i].Cells[0].Value.ToString()),
                                order_quantity = int.Parse(dgvReservation.Rows[i].Cells[3].Value.ToString()),
                                totalPrice = decimal.Parse(dgvReservation.Rows[i].Cells[4].Value.ToString()),
                                ClaimDate = DateTime.Parse(dgvReservation.Rows[i].Cells[7].Value.ToString()),
                                transactiontype = dgvReservation.Rows[i].Cells[8].Value.ToString(),
                                Reservation_Date = DateTime.Parse(dgvReservation.Rows[i].Cells[9].Value.ToString()),
                                customer_id = int.Parse(dgvReservation.Rows[i].Cells[10].Value.ToString()),
                                users_id = int.Parse(dgvReservation.Rows[i].Cells[11].Value.ToString()),
                                reservationStatus = dgvReservation.Rows[i].Cells[12].Value.ToString()
                            };
                            db.ProductsReservations.InsertOnSubmit(reservation);
                            dgvCustReservation.DataSource = db.sp_select_reservation();
                        }
                        db.SubmitChanges();
                        lblProID.Text = "";
                        txtpro_name.Text = "";
                        txtpro_price.Text = "";
                        txtpro_stock.Text = "";
                        txtpro_quantity.Text = "";
                        lblCustID.Text = "";
                        txtcust_name.Text = "";
                        txtcust_address.Text = "";
                        txtcash.Text = "";
                        txtAmount.Text = "";
                        txtchange.Text = "";
                        dgvReservation.Rows.Clear();
                    }
                }
            }
        }

        private void BtnDelStatus_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlDelivery.Show();
            pnlStocks.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void btnResStatus_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlStocks.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void DgvCustDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDeliveryID.Text = dgvCustDelivery.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvCustDelivery.CurrentRow.Cells[3].Value.ToString();
            txtQuantity.Text = dgvCustDelivery.CurrentRow.Cells[4].Value.ToString();
            txtDeliveryDate.Text = dgvCustDelivery.CurrentRow.Cells[7].Value.ToString();
            txtCustomerName.Text = dgvCustDelivery.CurrentRow.Cells[9].Value.ToString();
            txtCustomerAddress.Text = dgvCustDelivery.CurrentRow.Cells[10].Value.ToString();
            cmbDelStatus.Text = dgvCustDelivery.CurrentRow.Cells[8].Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void DgvCustReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblResID.Text = dgvCustReservation.CurrentRow.Cells[0].Value.ToString();
            txtPName.Text = dgvCustReservation.CurrentRow.Cells[3].Value.ToString();
            txtResQuantity.Text = dgvCustReservation.CurrentRow.Cells[4].Value.ToString();
            txtClaimDate.Text = dgvCustReservation.CurrentRow.Cells[7].Value.ToString();
            txtCName.Text = dgvCustReservation.CurrentRow.Cells[9].Value.ToString();
            txtCAddress.Text = dgvCustReservation.CurrentRow.Cells[10].Value.ToString();
            cmbReservationStatus.Text = dgvCustReservation.CurrentRow.Cells[8].Value.ToString();
        }

        private void BtnUpdateResPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPName.Text == "" || txtResQuantity.Text == "" || txtClaimDate.Text == "" || txtCName.Text == "" || txtCAddress.Text == "")
                {
                    MessageBox.Show("Please select product ordered to update Delivery!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    db.sp_update_reservation(int.Parse(lblResID.Text), cmbReservationStatus.Text);
                    lblResID.Text = "";
                    MessageBox.Show("Delivery Successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReservation.DataSource = db.sp_select_reservation();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtQuantity.Text == "" || txtDeliveryDate.Text == "" || txtCustomerName.Text == "" || txtCustomerAddress.Text == "")
                {
                    MessageBox.Show("Please select product ordered to update Delivery!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    db.sp_update_delivery(int.Parse(lblDeliveryID.Text), cmbDelStatus.Text);
                    lblDeliveryID.Text = "";
                    MessageBox.Show("Delivery Successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCustDelivery.DataSource = db.sp_select_delivery();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CancelRes_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvReservation.Rows.Remove(dgvReservation.CurrentRow);
                    foreach (DataGridViewRow row in dgvReservation.SelectedRows)
                    {
                        int cancelQuantity = int.Parse(row.Cells[3].Value.ToString());
                        string productID = row.Cells[0].Value.ToString();
                        db.sp_cancel_order(cancelQuantity, productID); ;
                        dgvReservation.DataSource = db.sp_view_stocks();
                        dgvReservation.Rows.Remove(row);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvReservation.Rows.Add(dgvReservation.CurrentRow);
                }
            }
            catch { }
        }

        private void BtnCancelDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvDelivery.Rows.Remove(dgvDelivery.CurrentRow);
                    foreach (DataGridViewRow row in dgvDelivery.SelectedRows)
                    {
                        int cancelQuantity = int.Parse(row.Cells[3].Value.ToString());
                        string productID = row.Cells[0].Value.ToString();
                        db.sp_cancel_order(cancelQuantity, productID); ;
                        dgvDelivery.DataSource = db.sp_view_stocks();
                        dgvDelivery.Rows.Remove(row);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvDelivery.Rows.Add(dgvDelivery.CurrentRow);
                }
            }
            catch { }
        }

        private void BtnRemoveRes_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvReservation.Rows.Remove(dgvReservation.CurrentRow);
                    foreach (DataGridViewRow row in dgvReservation.SelectedRows)
                    {
                        int cancelQuantity = int.Parse(row.Cells[3].Value.ToString());
                        string productID = row.Cells[0].Value.ToString();
                        db.sp_cancel_order(cancelQuantity, productID); ;
                        dgvReservation.DataSource = db.sp_view_stocks();
                        dgvReservation.Rows.Remove(row);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvReservation.Rows.Add(dgvReservation.CurrentRow);
                }
            }
            catch { }
        }

        private void BtnRemoveDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvDelivery.Rows.Remove(dgvDelivery.CurrentRow);
                    foreach (DataGridViewRow row in dgvDelivery.SelectedRows)
                    {
                        int cancelQuantity = int.Parse(row.Cells[3].Value.ToString());
                        string productID = row.Cells[0].Value.ToString();
                        db.sp_cancel_order(cancelQuantity, productID); ;
                        dgvDelivery.DataSource = db.sp_view_stocks();
                        dgvDelivery.Rows.Remove(row);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvDelivery.Rows.Add(dgvDelivery.CurrentRow);
                }
            }
            catch { }
        }

        private void PnlDelivery_Paint(object sender, PaintEventArgs e)
        {
            dgvCustDelivery.DataSource = db.sp_select_delivery();
        }

        private void BtnProDelivery_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlDelivery.Show();
            pnlStocks.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnProRes_Click(object sender, EventArgs e)
        {
            pnlHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlStocks.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlUser_reg.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReports.Hide();
            lblUsertype1.Text = lblUsertype.Text;
            lblFirstname1.Text = lblFirstname.Text;
        }

        private void BtnStaffHome_Click(object sender, EventArgs e)
        {
            pnlSystemTitle.Show();
            pnlStaffMainMenu.Show();
            pnlStaffHeader.Hide();
            pnlReservation.Hide();
            pnlDelivery.Hide();
            pnlStocks.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffTransact_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlStaffHeader.Show();
            pnlCust_reg.Hide();
            pnlPro_reg.Hide();
            pnlAdminMenu.Hide();
            pnlUser_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlReports.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
            cmbTranType.Focus();
        }

        private void BtnManageCustomer_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffStocks_Click(object sender, EventArgs e)
        {
            pnlStocks.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffDelStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlDelivery.Show();
            pnlStocks.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffResStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlStocks.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffTransaction_Click(object sender, EventArgs e)
        {
            pnlCustOrder.Show();
            pnlStaffHeader.Show();
            pnlCust_reg.Hide();
            pnlAdminMenu.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
            cmbTranType.Focus();
        }

        private void BtnStaffCustomerReg_Click(object sender, EventArgs e)
        {
            pnlCust_reg.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStocks.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffStockReg_Click(object sender, EventArgs e)
        {
            pnlStocks.Show();
            pnlStaffHeader.Show();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlDelivery.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffDeliveryStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlDelivery.Show();
            pnlStocks.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlReservation.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void BtnStaffReservationStatus_Click(object sender, EventArgs e)
        {
            pnlStaffHeader.Show();
            pnlReservation.Show();
            pnlDelivery.Hide();
            pnlStocks.Hide();
            pnlAdminMenu.Hide();
            pnlCustOrder.Hide();
            pnlCust_reg.Hide();
            pnlSystemTitle.Hide();
            pnlStaffMainMenu.Hide();
            lblStaffUType.Text = lblUsertype.Text;
            lblStaffName.Text = lblFirstname.Text;
        }

        private void PbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Logout?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void PnlStocks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
