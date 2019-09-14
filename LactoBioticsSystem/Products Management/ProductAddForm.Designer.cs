namespace LactoBioticsSystem.Products_Management
{
    partial class ProductAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddForm));
            this.picboxPAclose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProCategory = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtpro_desc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpro_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpro_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpro_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPAclose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxPAclose
            // 
            this.picboxPAclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPAclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPAclose.Image")));
            this.picboxPAclose.Location = new System.Drawing.Point(386, 3);
            this.picboxPAclose.Name = "picboxPAclose";
            this.picboxPAclose.Size = new System.Drawing.Size(29, 30);
            this.picboxPAclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPAclose.TabIndex = 38;
            this.picboxPAclose.TabStop = false;
            this.picboxPAclose.Click += new System.EventHandler(this.PicboxPAclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.cmbProCategory);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.txtpro_desc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtpro_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpro_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpro_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 388);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // cmbProCategory
            // 
            this.cmbProCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProCategory.FormattingEnabled = true;
            this.cmbProCategory.Items.AddRange(new object[] {
            "Dog Food",
            "Herbal Medicine",
            "Soap"});
            this.cmbProCategory.Location = new System.Drawing.Point(52, 61);
            this.cmbProCategory.Name = "cmbProCategory";
            this.cmbProCategory.Size = new System.Drawing.Size(198, 25);
            this.cmbProCategory.TabIndex = 25;
            this.cmbProCategory.SelectedIndexChanged += new System.EventHandler(this.CmbProCategory_SelectedIndexChanged);
            this.cmbProCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbProCategory_KeyPress);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(90, 312);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(117, 33);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // txtpro_desc
            // 
            this.txtpro_desc.BackColor = System.Drawing.Color.White;
            this.txtpro_desc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_desc.ForeColor = System.Drawing.Color.Black;
            this.txtpro_desc.Location = new System.Drawing.Point(52, 265);
            this.txtpro_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_desc.Name = "txtpro_desc";
            this.txtpro_desc.Size = new System.Drawing.Size(198, 25);
            this.txtpro_desc.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(63, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Product Description";
            // 
            // txtpro_price
            // 
            this.txtpro_price.BackColor = System.Drawing.Color.White;
            this.txtpro_price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_price.ForeColor = System.Drawing.Color.Black;
            this.txtpro_price.Location = new System.Drawing.Point(52, 215);
            this.txtpro_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_price.Name = "txtpro_price";
            this.txtpro_price.Size = new System.Drawing.Size(198, 25);
            this.txtpro_price.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Category";
            // 
            // txtpro_name
            // 
            this.txtpro_name.BackColor = System.Drawing.Color.White;
            this.txtpro_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_name.ForeColor = System.Drawing.Color.Black;
            this.txtpro_name.Location = new System.Drawing.Point(52, 161);
            this.txtpro_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_name.Name = "txtpro_name";
            this.txtpro_name.Size = new System.Drawing.Size(198, 25);
            this.txtpro_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Name";
            // 
            // txtpro_code
            // 
            this.txtpro_code.BackColor = System.Drawing.Color.White;
            this.txtpro_code.Enabled = false;
            this.txtpro_code.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro_code.ForeColor = System.Drawing.Color.Black;
            this.txtpro_code.Location = new System.Drawing.Point(52, 111);
            this.txtpro_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpro_code.Name = "txtpro_code";
            this.txtpro_code.Size = new System.Drawing.Size(198, 25);
            this.txtpro_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Product Code";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(397, 267);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(10, 13);
            this.lblUserID.TabIndex = 39;
            this.lblUserID.Text = " ";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(419, 488);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.picboxPAclose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductAddForm";
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPAclose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxPAclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.TextBox txtpro_desc;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtpro_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtpro_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtpro_code;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ComboBox cmbProCategory;
    }
}