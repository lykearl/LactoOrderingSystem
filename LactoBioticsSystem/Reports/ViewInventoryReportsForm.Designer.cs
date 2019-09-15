namespace LactoBioticsSystem
{
    partial class ViewInventoryReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInventoryReportsForm));
            this.btnPrintInventory = new System.Windows.Forms.Button();
            this.picboxPUclose = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbox_filter = new System.Windows.Forms.ComboBox();
            this.datepicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.datepicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.inventoryReportXAML1 = new LactoBioticsSystem.Reports.InventoryReportXAML();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintInventory
            // 
            this.btnPrintInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInventory.ForeColor = System.Drawing.Color.White;
            this.btnPrintInventory.Location = new System.Drawing.Point(592, 695);
            this.btnPrintInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintInventory.Name = "btnPrintInventory";
            this.btnPrintInventory.Size = new System.Drawing.Size(175, 46);
            this.btnPrintInventory.TabIndex = 42;
            this.btnPrintInventory.Text = "Print";
            this.btnPrintInventory.UseVisualStyleBackColor = false;
            this.btnPrintInventory.Click += new System.EventHandler(this.BtnPrintInventory_Click);
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(1323, 2);
            this.picboxPUclose.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(41, 37);
            this.picboxPUclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPUclose.TabIndex = 43;
            this.picboxPUclose.TabStop = false;
            this.picboxPUclose.Click += new System.EventHandler(this.PicboxPUclose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(531, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 50);
            this.label8.TabIndex = 44;
            this.label8.Text = "Inventory Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(247, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(896, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________";
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
            this.cmbbox_filter.Location = new System.Drawing.Point(1110, 243);
            this.cmbbox_filter.Name = "cmbbox_filter";
            this.cmbbox_filter.Size = new System.Drawing.Size(121, 24);
            this.cmbbox_filter.TabIndex = 56;
            this.cmbbox_filter.SelectedIndexChanged += new System.EventHandler(this.Cmbbox_filter_SelectedIndexChanged);
            // 
            // datepicker_enddate
            // 
            this.datepicker_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_enddate.Location = new System.Drawing.Point(775, 245);
            this.datepicker_enddate.Name = "datepicker_enddate";
            this.datepicker_enddate.Size = new System.Drawing.Size(200, 22);
            this.datepicker_enddate.TabIndex = 55;
            // 
            // datepicker_startDate
            // 
            this.datepicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_startDate.Location = new System.Drawing.Point(569, 245);
            this.datepicker_startDate.Name = "datepicker_startDate";
            this.datepicker_startDate.Size = new System.Drawing.Size(200, 22);
            this.datepicker_startDate.TabIndex = 54;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(-3, 284);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1367, 404);
            this.elementHost1.TabIndex = 57;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.inventoryReportXAML1;
            // 
            // ViewInventoryReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1367, 764);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.cmbbox_filter);
            this.Controls.Add(this.datepicker_enddate);
            this.Controls.Add(this.datepicker_startDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.btnPrintInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewInventoryReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInventoryReportsForm";
            this.Load += new System.EventHandler(this.ViewInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrintInventory;
        private System.Windows.Forms.PictureBox picboxPUclose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbox_filter;
        private System.Windows.Forms.DateTimePicker datepicker_enddate;
        private System.Windows.Forms.DateTimePicker datepicker_startDate;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Reports.InventoryReportXAML inventoryReportXAML1;
    }
}