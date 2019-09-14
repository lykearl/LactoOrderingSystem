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
            this.dgvSalesInventory = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datepicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.datepicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.cmbbox_filter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(1341, 2);
            this.picboxPUclose.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(43, 41);
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
            this.btnPrintSalesReports.Location = new System.Drawing.Point(577, 635);
            this.btnPrintSalesReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintSalesReports.Name = "btnPrintSalesReports";
            this.btnPrintSalesReports.Size = new System.Drawing.Size(175, 46);
            this.btnPrintSalesReports.TabIndex = 47;
            this.btnPrintSalesReports.Text = "Print";
            this.btnPrintSalesReports.UseVisualStyleBackColor = false;
            this.btnPrintSalesReports.Click += new System.EventHandler(this.BtnPrintSalesReports_Click);
            // 
            // dgvSalesInventory
            // 
            this.dgvSalesInventory.AllowUserToAddRows = false;
            this.dgvSalesInventory.AllowUserToDeleteRows = false;
            this.dgvSalesInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInventory.Location = new System.Drawing.Point(148, 202);
            this.dgvSalesInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalesInventory.Name = "dgvSalesInventory";
            this.dgvSalesInventory.ReadOnly = true;
            this.dgvSalesInventory.RowHeadersWidth = 51;
            this.dgvSalesInventory.Size = new System.Drawing.Size(1103, 414);
            this.dgvSalesInventory.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(545, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 50);
            this.label8.TabIndex = 49;
            this.label8.Text = "Sales Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(261, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(896, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // datepicker_startDate
            // 
            this.datepicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_startDate.Location = new System.Drawing.Point(589, 173);
            this.datepicker_startDate.Name = "datepicker_startDate";
            this.datepicker_startDate.Size = new System.Drawing.Size(200, 22);
            this.datepicker_startDate.TabIndex = 51;
            this.datepicker_startDate.ValueChanged += new System.EventHandler(this.Datepicker_startDate_ValueChanged);
            // 
            // datepicker_enddate
            // 
            this.datepicker_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_enddate.Location = new System.Drawing.Point(795, 173);
            this.datepicker_enddate.Name = "datepicker_enddate";
            this.datepicker_enddate.Size = new System.Drawing.Size(200, 22);
            this.datepicker_enddate.TabIndex = 52;
            this.datepicker_enddate.ValueChanged += new System.EventHandler(this.Datepicker_enddate_ValueChanged);
            // 
            // cmbbox_filter
            // 
            this.cmbbox_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_filter.FormattingEnabled = true;
            this.cmbbox_filter.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Custom"});
            this.cmbbox_filter.Location = new System.Drawing.Point(1130, 171);
            this.cmbbox_filter.Name = "cmbbox_filter";
            this.cmbbox_filter.Size = new System.Drawing.Size(121, 24);
            this.cmbbox_filter.TabIndex = 53;
            this.cmbbox_filter.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // ViewSalesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1387, 714);
            this.Controls.Add(this.cmbbox_filter);
            this.Controls.Add(this.datepicker_enddate);
            this.Controls.Add(this.datepicker_startDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.btnPrintSalesReports);
            this.Controls.Add(this.dgvSalesInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridView dgvSalesInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datepicker_startDate;
        private System.Windows.Forms.DateTimePicker datepicker_enddate;
        private System.Windows.Forms.ComboBox cmbbox_filter;
    }
}