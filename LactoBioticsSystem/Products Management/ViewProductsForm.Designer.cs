namespace LactoBioticsSystem.Products_Management
{
    partial class ViewProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.Select_Products = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Search";
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProducts.Location = new System.Drawing.Point(204, 90);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(451, 25);
            this.txtSearchProducts.TabIndex = 63;
            this.txtSearchProducts.TextChanged += new System.EventHandler(this.TxtSearchProducts_TextChanged);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClose.Image")));
            this.picBoxClose.Location = new System.Drawing.Point(1076, 3);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(30, 32);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxClose.TabIndex = 62;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select_Products});
            this.dgvStocks.Location = new System.Drawing.Point(71, 121);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.Size = new System.Drawing.Size(967, 250);
            this.dgvStocks.TabIndex = 61;
            this.dgvStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStocks_CellContentClick);
            // 
            // Select_Products
            // 
            this.Select_Products.HeaderText = "Select";
            this.Select_Products.Name = "Select_Products";
            this.Select_Products.ReadOnly = true;
            this.Select_Products.Text = "Select Products";
            this.Select_Products.UseColumnTextForButtonValue = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(430, 22);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(273, 40);
            this.label15.TabIndex = 65;
            this.label15.Text = "Product Availability";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(217, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(673, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(51, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 315);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1109, 423);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.dgvStocks);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProductsForm";
            this.Load += new System.EventHandler(this.ViewProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.PictureBox picBoxClose;
        public System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.DataGridViewButtonColumn Select_Products;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}