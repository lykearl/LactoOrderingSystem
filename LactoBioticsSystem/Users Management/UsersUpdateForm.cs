using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Users_Management
{
    public partial class UsersUpdateForm : Form
    {
        public UsersUpdateForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void Cmbutype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmbstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbQuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblUser_ID.Text.Trim() == "" || txtuname.Text.Trim() == "" || txtpass.Text.Trim() == "" || txtuserType.Text.Trim() == "" ||
                txtlname.Text.Trim() == "" || txtfname.Text.Trim() == "" || txtemail.Text.Trim() == "" || cmbstatus.Text == "" ||
                cmbQuest.Text.Trim() == "" || txtans.Text.Trim() == "")
            {
                MessageBox.Show("Please input fields to update user account!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {              
                    AdminMainForm amf = new AdminMainForm();
                    db.sp_update_acc(int.Parse(lblUser_ID.Text), txtuname.Text, txtpass.Text, txtuserType.Text, txtfname.Text, txtlname.Text,
                   txtemail.Text, cmbstatus.Text, cmbQuest.Text, txtans.Text, DateTime.Now);
                    lblUser_ID.Text = "";
                    txtuname.Text = "";
                    txtpass.Text = "";
                    txtuserType.Text = "";
                    txtfname.Text = "";
                    txtlname.Text = "";
                    txtemail.Text = "";
                    amf.txtuserstatus.Text = "";
                    cmbQuest.Text = "";
                    txtans.Text = "";
                    MessageBox.Show("User successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    amf.dgvUsersAcc.DataSource = db.sp_view_acc();
                    this.Hide();
                }            
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void PUClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
