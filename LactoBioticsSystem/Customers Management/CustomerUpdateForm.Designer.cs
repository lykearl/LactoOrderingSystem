namespace LactoBioticsSystem.Customer_Management
{
    partial class CustomerUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUpdateForm));
            this.picboxCUclose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCust_ID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbuCType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTin = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBstyle = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCUclose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxCUclose
            // 
            this.picboxCUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxCUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxCUclose.Image")));
            this.picboxCUclose.Location = new System.Drawing.Point(413, 3);
            this.picboxCUclose.Name = "picboxCUclose";
            this.picboxCUclose.Size = new System.Drawing.Size(28, 29);
            this.picboxCUclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxCUclose.TabIndex = 42;
            this.picboxCUclose.TabStop = false;
            this.picboxCUclose.Click += new System.EventHandler(this.PicboxCUclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCust_ID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbuCType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtTin);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtBstyle);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(60, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 447);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(84, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Business Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contact No.";
            // 
            // lblCust_ID
            // 
            this.lblCust_ID.AutoSize = true;
            this.lblCust_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust_ID.ForeColor = System.Drawing.Color.White;
            this.lblCust_ID.Location = new System.Drawing.Point(134, 46);
            this.lblCust_ID.Name = "lblCust_ID";
            this.lblCust_ID.Size = new System.Drawing.Size(16, 17);
            this.lblCust_ID.TabIndex = 28;
            this.lblCust_ID.Text = "  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Customer ID -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "TIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Address";
            // 
            // cmbuCType
            // 
            this.cmbuCType.BackColor = System.Drawing.Color.White;
            this.cmbuCType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbuCType.ForeColor = System.Drawing.Color.Black;
            this.cmbuCType.FormattingEnabled = true;
            this.cmbuCType.Items.AddRange(new object[] {
            "Walk-in Client",
            "Company Client"});
            this.cmbuCType.Location = new System.Drawing.Point(33, 342);
            this.cmbuCType.Name = "cmbuCType";
            this.cmbuCType.Size = new System.Drawing.Size(250, 25);
            this.cmbuCType.TabIndex = 4;
            this.cmbuCType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbuCType_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Costumer Type";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(33, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtTin
            // 
            this.txtTin.BackColor = System.Drawing.Color.White;
            this.txtTin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTin.ForeColor = System.Drawing.Color.Black;
            this.txtTin.Location = new System.Drawing.Point(33, 149);
            this.txtTin.Name = "txtTin";
            this.txtTin.Size = new System.Drawing.Size(250, 25);
            this.txtTin.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(33, 198);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 25);
            this.txtAddress.TabIndex = 2;
            // 
            // txtBstyle
            // 
            this.txtBstyle.BackColor = System.Drawing.Color.White;
            this.txtBstyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBstyle.ForeColor = System.Drawing.Color.Black;
            this.txtBstyle.Location = new System.Drawing.Point(33, 245);
            this.txtBstyle.Name = "txtBstyle";
            this.txtBstyle.Size = new System.Drawing.Size(250, 25);
            this.txtBstyle.TabIndex = 3;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(33, 292);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(250, 25);
            this.txtContact.TabIndex = 3;
            // 
            // CustomerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(443, 542);
            this.Controls.Add(this.picboxCUclose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerUpdateForm";
            this.Load += new System.EventHandler(this.CustomerUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxCUclose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxCUclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCust_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbuCType;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTin;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBstyle;
    }
}