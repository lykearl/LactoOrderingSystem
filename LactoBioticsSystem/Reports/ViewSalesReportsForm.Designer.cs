namespace LactoBioticsSystem
{
    partial class ViewSalesReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSalesReportsForm));
            this.picboxPUclose = new System.Windows.Forms.PictureBox();
            this.btnPrintSalesReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSalesInventory = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(1006, 2);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(32, 33);
            this.picboxPUclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPUclose.TabIndex = 48;
            this.picboxPUclose.TabStop = false;
            this.picboxPUclose.Click += new System.EventHandler(this.PicboxPUclose_Click);
            // 
            // btnPrintSalesReports
            // 
            this.btnPrintSalesReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintSalesReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintSalesReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSalesReports.ForeColor = System.Drawing.Color.White;
            this.btnPrintSalesReports.Location = new System.Drawing.Point(433, 516);
            this.btnPrintSalesReports.Name = "btnPrintSalesReports";
            this.btnPrintSalesReports.Size = new System.Drawing.Size(131, 37);
            this.btnPrintSalesReports.TabIndex = 47;
            this.btnPrintSalesReports.Text = "Print";
            this.btnPrintSalesReports.UseVisualStyleBackColor = false;
            this.btnPrintSalesReports.Click += new System.EventHandler(this.BtnPrintSalesReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(250, 138);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(465, 20);
            this.txtSearch.TabIndex = 45;
            // 
            // dgvSalesInventory
            // 
            this.dgvSalesInventory.AllowUserToAddRows = false;
            this.dgvSalesInventory.AllowUserToDeleteRows = false;
            this.dgvSalesInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInventory.Location = new System.Drawing.Point(111, 164);
            this.dgvSalesInventory.Name = "dgvSalesInventory";
            this.dgvSalesInventory.ReadOnly = true;
            this.dgvSalesInventory.Size = new System.Drawing.Size(827, 336);
            this.dgvSalesInventory.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(409, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 40);
            this.label8.TabIndex = 49;
            this.label8.Text = "Sales Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(196, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(673, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // ViewSalesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1040, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.btnPrintSalesReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSalesInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSalesReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSalesReportsForm";
            this.Load += new System.EventHandler(this.ViewSalesReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxPUclose;
        private System.Windows.Forms.Button btnPrintSalesReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSalesInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}