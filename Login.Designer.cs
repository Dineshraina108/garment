namespace LOGIN_MODEL
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnsignin = new System.Windows.Forms.Button();
            this.llblsignup = new System.Windows.Forms.LinkLabel();
            this.llblforgetpassword = new System.Windows.Forms.LinkLabel();
            this.lblslash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(98, 37);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(70, 22);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "LOGIN";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(34, 94);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(90, 17);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "USERNAME";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(141, 93);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 2;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(141, 143);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(34, 146);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(89, 17);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "PASSWORD";
            // 
            // btnsignin
            // 
            this.btnsignin.Location = new System.Drawing.Point(102, 215);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(75, 23);
            this.btnsignin.TabIndex = 5;
            this.btnsignin.Text = "SIGN IN";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // llblsignup
            // 
            this.llblsignup.AutoSize = true;
            this.llblsignup.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblsignup.Location = new System.Drawing.Point(274, 184);
            this.llblsignup.Name = "llblsignup";
            this.llblsignup.Size = new System.Drawing.Size(40, 15);
            this.llblsignup.TabIndex = 11;
            this.llblsignup.TabStop = true;
            this.llblsignup.Text = "Signup";
            this.llblsignup.Visible = false;
            this.llblsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblsignup_LinkClicked);
            // 
            // llblforgetpassword
            // 
            this.llblforgetpassword.AutoSize = true;
            this.llblforgetpassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblforgetpassword.Location = new System.Drawing.Point(176, 184);
            this.llblforgetpassword.Name = "llblforgetpassword";
            this.llblforgetpassword.Size = new System.Drawing.Size(88, 15);
            this.llblforgetpassword.TabIndex = 10;
            this.llblforgetpassword.TabStop = true;
            this.llblforgetpassword.Text = "Forget Password";
            this.llblforgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblforgetpassword_LinkClicked);
            // 
            // lblslash
            // 
            this.lblslash.AutoSize = true;
            this.lblslash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslash.Location = new System.Drawing.Point(264, 184);
            this.lblslash.Name = "lblslash";
            this.lblslash.Size = new System.Drawing.Size(10, 15);
            this.lblslash.TabIndex = 12;
            this.lblslash.Text = "/";
            this.lblslash.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LOGIN_MODEL.Properties.Resources.log2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(322, 283);
            this.Controls.Add(this.lblslash);
            this.Controls.Add(this.llblsignup);
            this.Controls.Add(this.llblforgetpassword);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbltitle);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnsignin;
        internal System.Windows.Forms.LinkLabel llblsignup;
        internal System.Windows.Forms.LinkLabel llblforgetpassword;
        internal System.Windows.Forms.Label lblslash;
    }
}

