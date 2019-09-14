namespace LactoBioticsSystem.Users_Management
{
    partial class UsersRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersRegistrationForm));
            this.pURclose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtans = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbQuest = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pURclose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pURclose
            // 
            this.pURclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pURclose.Image = ((System.Drawing.Image)(resources.GetObject("pURclose.Image")));
            this.pURclose.Location = new System.Drawing.Point(393, 3);
            this.pURclose.Name = "pURclose";
            this.pURclose.Size = new System.Drawing.Size(31, 27);
            this.pURclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pURclose.TabIndex = 62;
            this.pURclose.TabStop = false;
            this.pURclose.Click += new System.EventHandler(this.PURclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.txtans);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbQuest);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtuname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(48, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 477);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(102, 403);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(111, 30);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // txtans
            // 
            this.txtans.BackColor = System.Drawing.Color.White;
            this.txtans.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtans.ForeColor = System.Drawing.Color.Black;
            this.txtans.Location = new System.Drawing.Point(53, 363);
            this.txtans.Name = "txtans";
            this.txtans.Size = new System.Drawing.Size(211, 25);
            this.txtans.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(58, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Secret Answer";
            // 
            // cmbQuest
            // 
            this.cmbQuest.BackColor = System.Drawing.Color.White;
            this.cmbQuest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuest.ForeColor = System.Drawing.Color.Black;
            this.cmbQuest.FormattingEnabled = true;
            this.cmbQuest.ItemHeight = 17;
            this.cmbQuest.Items.AddRange(new object[] {
            "What is the name of your pet?",
            "Who is your favorite uncle?",
            "Who is your first crush?",
            "Who is your first kiss?"});
            this.cmbQuest.Location = new System.Drawing.Point(53, 312);
            this.cmbQuest.Name = "cmbQuest";
            this.cmbQuest.Size = new System.Drawing.Size(213, 25);
            this.cmbQuest.TabIndex = 9;
            this.cmbQuest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbQuest_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(57, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Secret Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Password";
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.White;
            this.txtlname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.Color.Black;
            this.txtlname.Location = new System.Drawing.Point(55, 68);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(211, 25);
            this.txtlname.TabIndex = 1;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.White;
            this.txtfname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.Black;
            this.txtfname.Location = new System.Drawing.Point(55, 116);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(211, 25);
            this.txtfname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Firstname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Username";
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.White;
            this.txtuname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.ForeColor = System.Drawing.Color.Black;
            this.txtuname.Location = new System.Drawing.Point(54, 164);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(210, 25);
            this.txtuname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Email Address";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(54, 215);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(211, 25);
            this.txtpass.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(53, 262);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(213, 25);
            this.txtemail.TabIndex = 7;
            // 
            // UsersRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(425, 568);
            this.Controls.Add(this.pURclose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pURclose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pURclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUser;
        public System.Windows.Forms.TextBox txtans;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cmbQuest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtlname;
        public System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtemail;
    }
}