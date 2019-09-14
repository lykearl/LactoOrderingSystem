namespace LactoBioticsSystem.Reports
{
    partial class ViewSalesReport
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.salesReportsForm = new LactoBioticsSystem.Reports.SalesReportsForm();
            this.btn_printSalesReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1067, 457);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.salesReportsForm;
            // 
            // btn_printSalesReport
            // 
            this.btn_printSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_printSalesReport.Location = new System.Drawing.Point(0, 457);
            this.btn_printSalesReport.Name = "btn_printSalesReport";
            this.btn_printSalesReport.Size = new System.Drawing.Size(1067, 97);
            this.btn_printSalesReport.TabIndex = 1;
            this.btn_printSalesReport.Text = "Print Sales Report";
            this.btn_printSalesReport.UseVisualStyleBackColor = true;
            this.btn_printSalesReport.Click += new System.EventHandler(this.Btn_printSalesReport_Click);
            // 
            // ViewSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_printSalesReport);
            this.Controls.Add(this.elementHost1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewSalesReport";
            this.Text = "ViewSalesReport";
            this.Load += new System.EventHandler(this.ViewSalesReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SalesReportsForm salesReportsForm;
        private System.Windows.Forms.Button btn_printSalesReport;
    }
}