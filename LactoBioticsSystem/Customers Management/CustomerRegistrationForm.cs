using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Customer_Management
{
    public partial class CustomerRegistrationForm : Form
    {
        public CustomerRegistrationForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();

        private void CmbuCType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PicboxCRclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || cmbuCType.Text == "")
                {
                    MessageBox.Show("Please input all fields", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    db.sp_add_customer(int.Parse(lblUserID.Text), txtName.Text, txtTin.Text, txtAddress.Text, txtBstyle.Text, txtContact.Text, cmbuCType.Text, DateTime.Now);
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtContact.Text = "";
                    cmbuCType.Text = "";
                    MessageBox.Show("Customer uccessfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainForm amf = new AdminMainForm();
                    amf.dgvCustomersAcc.DataSource = db.sp_view_customer();
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
