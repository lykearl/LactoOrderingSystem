namespace LactoBioticsSystem.Products_Management
{
    partial class DeliveryProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryProductsForm));
            this.btnClaim = new System.Windows.Forms.Button();
            this.picboxDelPro = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDelPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClaim
            // 
            this.btnClaim.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClaim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClaim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClaim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaim.ForeColor = System.Drawing.Color.White;
            this.btnClaim.Location = new System.Drawing.Point(388, 417);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(133, 45);
            this.btnClaim.TabIndex = 68;
            this.btnClaim.Text = "Claim";
            this.btnClaim.UseVisualStyleBackColor = false;
            // 
            // picboxDelPro
            // 
            this.picboxDelPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxDelPro.Image = ((System.Drawing.Image)(resources.GetObject("picboxDelPro.Image")));
            this.picboxDelPro.Location = new System.Drawing.Point(891, 1);
            this.picboxDelPro.Name = "picboxDelPro";
            this.picboxDelPro.Size = new System.Drawing.Size(29, 28);
            this.picboxDelPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDelPro.TabIndex = 69;
            this.picboxDelPro.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 303);
            this.dataGridView1.TabIndex = 66;
            // 
            // DeliveryProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(924, 496);
            this.Controls.Add(this.btnClaim);
            this.Controls.Add(this.picboxDelPro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picboxDelPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.PictureBox picboxDelPro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}