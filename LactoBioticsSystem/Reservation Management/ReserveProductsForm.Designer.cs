namespace LactoBioticsSystem.Reservation_Management
{
    partial class ReserveProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveProductsForm));
            this.picboxResPro = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClaim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxResPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxResPro
            // 
            this.picboxResPro.Image = ((System.Drawing.Image)(resources.GetObject("picboxResPro.Image")));
            this.picboxResPro.Location = new System.Drawing.Point(920, 1);
            this.picboxResPro.Name = "picboxResPro";
            this.picboxResPro.Size = new System.Drawing.Size(30, 33);
            this.picboxResPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxResPro.TabIndex = 66;
            this.picboxResPro.TabStop = false;
            this.picboxResPro.Click += new System.EventHandler(this.PicboxResPro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(492, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 64;
            this.button1.Text = "Deliver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClaim
            // 
            this.btnClaim.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClaim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClaim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaim.ForeColor = System.Drawing.Color.White;
            this.btnClaim.Location = new System.Drawing.Point(320, 422);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(122, 40);
            this.btnClaim.TabIndex = 65;
            this.btnClaim.Text = "Claim";
            this.btnClaim.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Search Reservation";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 303);
            this.dataGridView1.TabIndex = 61;
            // 
            // ReserveProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(952, 487);
            this.Controls.Add(this.picboxResPro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClaim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReserveProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReserveProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picboxResPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxResPro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}