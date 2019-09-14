namespace LactoBioticsSystem.Products_Management
{
    partial class AddNewStocksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStocksForm));
            this.lblUser_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStocks = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProCode = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.lblstockproID = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picboxAdminClose = new System.Windows.Forms.PictureBox();
            this.txtSearchPro = new System.Windows.Forms.TextBox();
            this.dgvStocksPro = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdminClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocksPro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser_id
            // 
            this.lblUser_id.AutoSize = true;
            this.lblUser_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_id.ForeColor = System.Drawing.Color.White;
            this.lblUser_id.Location = new System.Drawing.Point(179, 445);
            this.lblUser_id.Name = "lblUser_id";
            this.lblUser_id.Size = new System.Drawing.Size(14, 21);
            this.lblUser_id.TabIndex = 48;
            this.lblUser_id.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Search Products";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.btnAddStocks);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtProPrice);
            this.groupBox1.Controls.Add(this.txtProName);
            this.groupBox1.Controls.Add(this.txtProCode);
            this.groupBox1.Controls.Add(this.txtStockQuantity);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.lblstockproID);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label55);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(231, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 227);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // btnAddStocks
            // 
            this.btnAddStocks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStocks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStocks.ForeColor = System.Drawing.Color.White;
            this.btnAddStocks.Location = new System.Drawing.Point(155, 168);
            this.btnAddStocks.Name = "btnAddStocks";
            this.btnAddStocks.Size = new System.Drawing.Size(131, 37);
            this.btnAddStocks.TabIndex = 2;
            this.btnAddStocks.Text = "Add Stocks";
            this.btnAddStocks.UseVisualStyleBackColor = false;
            this.btnAddStocks.Click += new System.EventHandler(this.BtnAddStocks_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(320, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtProPrice
            // 
            this.txtProPrice.Enabled = false;
            this.txtProPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPrice.Location = new System.Drawing.Point(320, 73);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(260, 25);
            this.txtProPrice.TabIndex = 40;
            // 
            // txtProName
            // 
            this.txtProName.Enabled = false;
            this.txtProName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(28, 125);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(258, 25);
            this.txtProName.TabIndex = 40;
            // 
            // txtProCode
            // 
            this.txtProCode.Enabled = false;
            this.txtProCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCode.Location = new System.Drawing.Point(28, 75);
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.Size = new System.Drawing.Size(258, 25);
            this.txtProCode.TabIndex = 40;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BackColor = System.Drawing.Color.White;
            this.txtStockQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtStockQuantity.Location = new System.Drawing.Point(320, 124);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(260, 25);
            this.txtStockQuantity.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(32, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 21);
            this.label30.TabIndex = 27;
            this.label30.Text = "Product ID:";
            // 
            // lblstockproID
            // 
            this.lblstockproID.AutoSize = true;
            this.lblstockproID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockproID.ForeColor = System.Drawing.Color.DimGray;
            this.lblstockproID.Location = new System.Drawing.Point(123, 26);
            this.lblstockproID.Name = "lblstockproID";
            this.lblstockproID.Size = new System.Drawing.Size(28, 15);
            this.lblstockproID.TabIndex = 39;
            this.lblstockproID.Text = "       ";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.LightGray;
            this.label49.Location = new System.Drawing.Point(32, 102);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(113, 21);
            this.label49.TabIndex = 35;
            this.label49.Text = "Product Name:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.LightGray;
            this.label55.Location = new System.Drawing.Point(323, 50);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(105, 21);
            this.label55.TabIndex = 38;
            this.label55.Text = "Product Price:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.LightGray;
            this.label52.Location = new System.Drawing.Point(31, 51);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(107, 21);
            this.label52.TabIndex = 33;
            this.label52.Text = "Product Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(323, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Quantity:";
            // 
            // picboxAdminClose
            // 
            this.picboxAdminClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxAdminClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxAdminClose.Image")));
            this.picboxAdminClose.Location = new System.Drawing.Point(1061, 1);
            this.picboxAdminClose.Name = "picboxAdminClose";
            this.picboxAdminClose.Size = new System.Drawing.Size(29, 30);
            this.picboxAdminClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAdminClose.TabIndex = 45;
            this.picboxAdminClose.TabStop = false;
            this.picboxAdminClose.Click += new System.EventHandler(this.PicboxAdminClose_Click);
            // 
            // txtSearchPro
            // 
            this.txtSearchPro.Location = new System.Drawing.Point(245, 80);
            this.txtSearchPro.Name = "txtSearchPro";
            this.txtSearchPro.Size = new System.Drawing.Size(330, 20);
            this.txtSearchPro.TabIndex = 44;
            this.txtSearchPro.TextChanged += new System.EventHandler(this.TxtSearchPro_TextChanged);
            // 
            // dgvStocksPro
            // 
            this.dgvStocksPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocksPro.Location = new System.Drawing.Point(61, 106);
            this.dgvStocksPro.Name = "dgvStocksPro";
            this.dgvStocksPro.Size = new System.Drawing.Size(962, 230);
            this.dgvStocksPro.TabIndex = 43;
            this.dgvStocksPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStocksPro_CellContentClick);
            // 
            // AddNewStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1091, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picboxAdminClose);
            this.Controls.Add(this.txtSearchPro);
            this.Controls.Add(this.dgvStocksPro);
            this.Controls.Add(this.lblUser_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewStocksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStocksForm";
            this.Load += new System.EventHandler(this.AddNewStocksForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdminClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocksPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUser_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStocks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblstockproID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.PictureBox picboxAdminClose;
        private System.Windows.Forms.TextBox txtSearchPro;
        private System.Windows.Forms.DataGridView dgvStocksPro;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProCode;
    }
}