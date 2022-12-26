namespace uas_bd_1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.to_kasir = new System.Windows.Forms.Button();
            this.to_obat = new System.Windows.Forms.Button();
            this.to_history = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // to_kasir
            // 
            this.to_kasir.Font = new System.Drawing.Font("Trueno", 12F);
            this.to_kasir.Location = new System.Drawing.Point(59, 124);
            this.to_kasir.Name = "to_kasir";
            this.to_kasir.Size = new System.Drawing.Size(213, 53);
            this.to_kasir.TabIndex = 0;
            this.to_kasir.Text = "Kasir";
            this.to_kasir.UseVisualStyleBackColor = true;
            this.to_kasir.Click += new System.EventHandler(this.to_kasir_Click);
            // 
            // to_obat
            // 
            this.to_obat.Font = new System.Drawing.Font("Trueno", 12F);
            this.to_obat.Location = new System.Drawing.Point(59, 199);
            this.to_obat.Name = "to_obat";
            this.to_obat.Size = new System.Drawing.Size(213, 53);
            this.to_obat.TabIndex = 1;
            this.to_obat.Text = "Obat";
            this.to_obat.UseVisualStyleBackColor = true;
            this.to_obat.Click += new System.EventHandler(this.to_obat_Click);
            // 
            // to_history
            // 
            this.to_history.Font = new System.Drawing.Font("Trueno", 12F);
            this.to_history.Location = new System.Drawing.Point(59, 277);
            this.to_history.Name = "to_history";
            this.to_history.Size = new System.Drawing.Size(213, 53);
            this.to_history.TabIndex = 2;
            this.to_history.Text = "Sejarah Transaksi";
            this.to_history.UseVisualStyleBackColor = true;
            this.to_history.Click += new System.EventHandler(this.to_history_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Trueno", 10F);
            this.logout_btn.Location = new System.Drawing.Point(623, 22);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(165, 38);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.to_history);
            this.Controls.Add(this.to_obat);
            this.Controls.Add(this.to_kasir);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button to_kasir;
        private System.Windows.Forms.Button to_obat;
        private System.Windows.Forms.Button to_history;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
    }
}