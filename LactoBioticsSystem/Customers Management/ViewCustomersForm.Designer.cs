namespace LactoBioticsSystem.Customers_Management
{
    partial class ViewCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Select_Customer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Search Customer";
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCust.Location = new System.Drawing.Point(196, 20);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(366, 25);
            this.txtSearchCust.TabIndex = 63;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.TxtSearchCust_TextChanged);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClose.Image")));
            this.picBoxClose.Location = new System.Drawing.Point(1002, 3);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(29, 29);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxClose.TabIndex = 62;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select_Customer});
            this.dgvCustomer.Location = new System.Drawing.Point(28, 51);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(883, 274);
            this.dgvCustomer.TabIndex = 61;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomer_CellContentClick);
            // 
            // Select_Customer
            // 
            this.Select_Customer.HeaderText = "Select";
            this.Select_Customer.Name = "Select_Customer";
            this.Select_Customer.ReadOnly = true;
            this.Select_Customer.Text = "Select Customer";
            this.Select_Customer.UseColumnTextForButtonValue = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(422, 25);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(290, 40);
            this.label15.TabIndex = 65;
            this.label15.Text = "Registered Customer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(219, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(673, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.dgvCustomer);
            this.groupBox1.Controls.Add(this.txtSearchCust);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(48, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 344);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1033, 460);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCustomersForm";
            this.Load += new System.EventHandler(this.ViewCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.PictureBox picBoxClose;
        public System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewButtonColumn Select_Customer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}