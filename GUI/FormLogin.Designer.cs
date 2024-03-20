
namespace MDI_Form.GUI
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_nama = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_login = new System.Windows.Forms.Button();
            this.login_batal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // login_nama
            // 
            this.login_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_nama.Location = new System.Drawing.Point(100, 23);
            this.login_nama.Name = "login_nama";
            this.login_nama.Size = new System.Drawing.Size(198, 26);
            this.login_nama.TabIndex = 4;
            this.login_nama.TextChanged += new System.EventHandler(this.login_nama_TextChanged);
            // 
            // login_password
            // 
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_password.Location = new System.Drawing.Point(100, 55);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(198, 26);
            this.login_password.TabIndex = 5;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // login_login
            // 
            this.login_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_login.Location = new System.Drawing.Point(37, 104);
            this.login_login.Name = "login_login";
            this.login_login.Size = new System.Drawing.Size(89, 38);
            this.login_login.TabIndex = 8;
            this.login_login.Text = "Login";
            this.login_login.UseVisualStyleBackColor = false;
            this.login_login.Click += new System.EventHandler(this.login_login_Click);
            // 
            // login_batal
            // 
            this.login_batal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.login_batal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_batal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_batal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_batal.Location = new System.Drawing.Point(212, 104);
            this.login_batal.Name = "login_batal";
            this.login_batal.Size = new System.Drawing.Size(86, 38);
            this.login_batal.TabIndex = 9;
            this.login_batal.Text = "Batal";
            this.login_batal.UseVisualStyleBackColor = false;
            this.login_batal.Click += new System.EventHandler(this.login_batal_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 155);
            this.Controls.Add(this.login_batal);
            this.Controls.Add(this.login_login);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_nama;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_login;
        private System.Windows.Forms.Button login_batal;
    }
}