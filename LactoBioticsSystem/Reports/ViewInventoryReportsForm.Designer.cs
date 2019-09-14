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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintInventory = new System.Windows.Forms.Button();
            this.picboxPUclose = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbInRepType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(99, 223);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(827, 336);
            this.dgvInventory.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // btnPrintInventory
            // 
            this.btnPrintInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInventory.ForeColor = System.Drawing.Color.White;
            this.btnPrintInventory.Location = new System.Drawing.Point(444, 565);
            this.btnPrintInventory.Name = "btnPrintInventory";
            this.btnPrintInventory.Size = new System.Drawing.Size(131, 37);
            this.btnPrintInventory.TabIndex = 42;
            this.btnPrintInventory.Text = "Print";
            this.btnPrintInventory.UseVisualStyleBackColor = false;
            this.btnPrintInventory.Click += new System.EventHandler(this.BtnPrintInventory_Click);
            // 
            // picboxPUclose
            // 
            this.picboxPUclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPUclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxPUclose.Image")));
            this.picboxPUclose.Location = new System.Drawing.Point(992, 2);
            this.picboxPUclose.Name = "picboxPUclose";
            this.picboxPUclose.Size = new System.Drawing.Size(31, 30);
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
            this.label8.Location = new System.Drawing.Point(398, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 40);
            this.label8.TabIndex = 44;
            this.label8.Text = "Inventory Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(185, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(673, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // cmbInRepType
            // 
            this.cmbInRepType.FormattingEnabled = true;
            this.cmbInRepType.Items.AddRange(new object[] {
            "Daily Reports",
            "Weekly Reports",
            "Monthly Reports"});
            this.cmbInRepType.Location = new System.Drawing.Point(604, 186);
            this.cmbInRepType.Name = "cmbInRepType";
            this.cmbInRepType.Size = new System.Drawing.Size(225, 21);
            this.cmbInRepType.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(510, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Report Types:";
            // 
            // ViewInventoryReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1025, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbInRepType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picboxPUclose);
            this.Controls.Add(this.btnPrintInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewInventoryReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInventoryReportsForm";
            this.Load += new System.EventHandler(this.ViewInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPUclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintInventory;
        private System.Windows.Forms.PictureBox picboxPUclose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbInRepType;
        private System.Windows.Forms.Label label2;
    }
}