namespace uas_bd_1
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.input_un = new System.Windows.Forms.TextBox();
            this.input_pw = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Trueno", 10F);
            this.login_btn.Location = new System.Drawing.Point(38, 218);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(282, 44);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_un
            // 
            this.input_un.Font = new System.Drawing.Font("Trueno", 10F);
            this.input_un.Location = new System.Drawing.Point(38, 82);
            this.input_un.Name = "input_un";
            this.input_un.Size = new System.Drawing.Size(282, 27);
            this.input_un.TabIndex = 1;
            this.input_un.Text = "admin";
            // 
            // input_pw
            // 
            this.input_pw.Font = new System.Drawing.Font("Trueno", 10F);
            this.input_pw.Location = new System.Drawing.Point(38, 156);
            this.input_pw.Name = "input_pw";
            this.input_pw.PasswordChar = '*';
            this.input_pw.Size = new System.Drawing.Size(282, 27);
            this.input_pw.TabIndex = 2;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Trueno", 12F);
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_username.Location = new System.Drawing.Point(34, 55);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(112, 24);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            this.label_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Trueno", 12F);
            this.label_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_password.Location = new System.Drawing.Point(34, 129);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(106, 24);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uas_bd_1.Properties.Resources.healthcare_white;
            this.pictureBox1.Location = new System.Drawing.Point(405, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(685, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.input_pw);
            this.Controls.Add(this.input_un);
            this.Controls.Add(this.login_btn);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox input_un;
        private System.Windows.Forms.TextBox input_pw;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}