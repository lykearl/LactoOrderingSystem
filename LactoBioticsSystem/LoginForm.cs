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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please input details!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int result;
                result = db.sp_login_acc(txtUser.Text, txtPass.Text).Count();
                dgvLogin.DataSource = db.sp_login_acc(txtUser.Text, txtPass.Text);
                if (result > 0)
                {
                    ClsLogin.userID = dgvLogin.Rows[0].Cells[0].Value.ToString();
                    ClsLogin.username = dgvLogin.Rows[0].Cells[1].Value.ToString();
                    ClsLogin.usertype = dgvLogin.Rows[0].Cells[3].Value.ToString();
                    ClsLogin.Firstname = dgvLogin.Rows[0].Cells[4].Value.ToString();
                    ClsLogin.userstatus = dgvLogin.Rows[0].Cells[7].Value.ToString();
                    if (ClsLogin.usertype == "Administrator")
                        if (ClsLogin.userstatus == "Active")
                        {
                            MessageBox.Show("Welcome Administrator", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminMainForm amf = new AdminMainForm();
                            amf.pnlAdminMenu.Show();
                            amf.lblUserID.Text = ClsLogin.usertype = dgvLogin.Rows[0].Cells[0].Value.ToString();
                            amf.lblUsertype.Text = ClsLogin.usertype = dgvLogin.Rows[0].Cells[3].Value.ToString();
                            amf.lblFirstname.Text = ClsLogin.Firstname = dgvLogin.Rows[0].Cells[4].Value.ToString();
                            this.Hide();
                            amf.Show();

                        }
                        else
                        {
                            MessageBox.Show("Please ask the Administrator!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    else if (ClsLogin.userstatus == "Active")
                    {
                        MessageBox.Show("Welcome Staff", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminMainForm amf = new AdminMainForm();
                        amf.pnlStaffMainMenu.Show();
                        amf.lblUserID.Text = ClsLogin.usertype = dgvLogin.Rows[0].Cells[0].Value.ToString();
                        amf.lblUsertype.Text = ClsLogin.usertype = dgvLogin.Rows[0].Cells[3].Value.ToString();
                        amf.lblFirstname.Text = ClsLogin.username = dgvLogin.Rows[0].Cells[4].Value.ToString();
                        this.Hide();
                        amf.Show();
                    }

                    else
                    {
                        MessageBox.Show("Please ask the Administrator!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void PicboxLogClose_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to Exit Application?", "System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {

            }
        }
    }
}
