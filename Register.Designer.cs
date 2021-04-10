namespace LOGIN_MODEL
{
    partial class Register
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
            this.regpanel = new System.Windows.Forms.Panel();
            this.Regmainpanel = new System.Windows.Forms.Panel();
            this.txtmobno = new System.Windows.Forms.TextBox();
            this.lblmobno = new System.Windows.Forms.Label();
            this.cmbgen = new System.Windows.Forms.ComboBox();
            this.lblgen = new System.Windows.Forms.Label();
            this.dtbdob = new System.Windows.Forms.DateTimePicker();
            this.lbldob = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.rtxtaddr = new System.Windows.Forms.RichTextBox();
            this.lblpri = new System.Windows.Forms.Label();
            this.rbyes = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.llblallogin = new System.Windows.Forms.LinkLabel();
            this.btnreg = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.forgetpanel = new System.Windows.Forms.Panel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.lblrepass = new System.Windows.Forms.Label();
            this.llblalacc = new System.Windows.Forms.LinkLabel();
            this.btnfcan = new System.Windows.Forms.Button();
            this.btnsignup = new System.Windows.Forms.Button();
            this.regpanel.SuspendLayout();
            this.Regmainpanel.SuspendLayout();
            this.forgetpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regpanel
            // 
            this.regpanel.AutoSize = true;
            this.regpanel.BackgroundImage = global::LOGIN_MODEL.Properties.Resources.log2;
            this.regpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regpanel.Controls.Add(this.forgetpanel);
            this.regpanel.Controls.Add(this.Regmainpanel);
            this.regpanel.Controls.Add(this.lbltitle);
            this.regpanel.Location = new System.Drawing.Point(3, 3);
            this.regpanel.Name = "regpanel";
            this.regpanel.Size = new System.Drawing.Size(872, 506);
            this.regpanel.TabIndex = 0;
            // 
            // Regmainpanel
            // 
            this.Regmainpanel.AutoSize = true;
            this.Regmainpanel.BackgroundImage = global::LOGIN_MODEL.Properties.Resources.log2;
            this.Regmainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regmainpanel.Controls.Add(this.btncancel);
            this.Regmainpanel.Controls.Add(this.btnreg);
            this.Regmainpanel.Controls.Add(this.llblallogin);
            this.Regmainpanel.Controls.Add(this.rbno);
            this.Regmainpanel.Controls.Add(this.rbyes);
            this.Regmainpanel.Controls.Add(this.lblpri);
            this.Regmainpanel.Controls.Add(this.rtxtaddr);
            this.Regmainpanel.Controls.Add(this.lbladdr);
            this.Regmainpanel.Controls.Add(this.txtemail);
            this.Regmainpanel.Controls.Add(this.lblemail);
            this.Regmainpanel.Controls.Add(this.txtmobno);
            this.Regmainpanel.Controls.Add(this.lblmobno);
            this.Regmainpanel.Controls.Add(this.cmbgen);
            this.Regmainpanel.Controls.Add(this.lblgen);
            this.Regmainpanel.Controls.Add(this.dtbdob);
            this.Regmainpanel.Controls.Add(this.lbldob);
            this.Regmainpanel.Controls.Add(this.Txtname);
            this.Regmainpanel.Controls.Add(this.lblname);
            this.Regmainpanel.Location = new System.Drawing.Point(34, 82);
            this.Regmainpanel.Name = "Regmainpanel";
            this.Regmainpanel.Size = new System.Drawing.Size(386, 411);
            this.Regmainpanel.TabIndex = 2;
            // 
            // txtmobno
            // 
            this.txtmobno.Location = new System.Drawing.Point(176, 151);
            this.txtmobno.Name = "txtmobno";
            this.txtmobno.Size = new System.Drawing.Size(155, 20);
            this.txtmobno.TabIndex = 7;
            this.txtmobno.TextChanged += new System.EventHandler(this.txtmobno_TextChanged);
            this.txtmobno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmobno_KeyDown);
            // 
            // lblmobno
            // 
            this.lblmobno.AutoSize = true;
            this.lblmobno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobno.Location = new System.Drawing.Point(59, 154);
            this.lblmobno.Name = "lblmobno";
            this.lblmobno.Size = new System.Drawing.Size(91, 17);
            this.lblmobno.TabIndex = 6;
            this.lblmobno.Text = "MOBILE NO";
            // 
            // cmbgen
            // 
            this.cmbgen.FormattingEnabled = true;
            this.cmbgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgen.Location = new System.Drawing.Point(176, 112);
            this.cmbgen.Name = "cmbgen";
            this.cmbgen.Size = new System.Drawing.Size(155, 21);
            this.cmbgen.TabIndex = 5;
            this.cmbgen.SelectedIndexChanged += new System.EventHandler(this.cmbgen_SelectedIndexChanged);
            this.cmbgen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbgen_KeyDown);
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgen.Location = new System.Drawing.Point(59, 112);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(68, 17);
            this.lblgen.TabIndex = 4;
            this.lblgen.Text = "GENDER";
            // 
            // dtbdob
            // 
            this.dtbdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbdob.Location = new System.Drawing.Point(176, 73);
            this.dtbdob.MaxDate = new System.DateTime(2021, 4, 2, 0, 0, 0, 0);
            this.dtbdob.Name = "dtbdob";
            this.dtbdob.Size = new System.Drawing.Size(155, 20);
            this.dtbdob.TabIndex = 3;
            this.dtbdob.Value = new System.DateTime(2021, 4, 2, 0, 0, 0, 0);
            this.dtbdob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtbdob_KeyDown);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(59, 73);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(40, 17);
            this.lbldob.TabIndex = 2;
            this.lbldob.Text = "DOB";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(176, 32);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(155, 20);
            this.Txtname.TabIndex = 1;
            this.Txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtname_KeyDown);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(59, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 17);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "NAME";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(125, 47);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(171, 22);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "REGISTER FORM";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(176, 188);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(155, 20);
            this.txtemail.TabIndex = 9;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(59, 188);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(74, 17);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "EMAIL ID";
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.Location = new System.Drawing.Point(59, 224);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(76, 17);
            this.lbladdr.TabIndex = 10;
            this.lbladdr.Text = "ADDRESS";
            // 
            // rtxtaddr
            // 
            this.rtxtaddr.Location = new System.Drawing.Point(176, 224);
            this.rtxtaddr.Name = "rtxtaddr";
            this.rtxtaddr.Size = new System.Drawing.Size(155, 57);
            this.rtxtaddr.TabIndex = 11;
            this.rtxtaddr.Text = "";
            this.rtxtaddr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtaddr_KeyDown);
            // 
            // lblpri
            // 
            this.lblpri.AutoSize = true;
            this.lblpri.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpri.Location = new System.Drawing.Point(59, 300);
            this.lblpri.Name = "lblpri";
            this.lblpri.Size = new System.Drawing.Size(87, 17);
            this.lblpri.TabIndex = 12;
            this.lblpri.Text = "PRIVILAGE";
            // 
            // rbyes
            // 
            this.rbyes.AutoSize = true;
            this.rbyes.Location = new System.Drawing.Point(193, 300);
            this.rbyes.Name = "rbyes";
            this.rbyes.Size = new System.Drawing.Size(46, 17);
            this.rbyes.TabIndex = 13;
            this.rbyes.TabStop = true;
            this.rbyes.Text = "YES";
            this.rbyes.UseVisualStyleBackColor = true;
            this.rbyes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbyes_KeyDown);
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Location = new System.Drawing.Point(255, 300);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(41, 17);
            this.rbno.TabIndex = 14;
            this.rbno.TabStop = true;
            this.rbno.Text = "NO";
            this.rbno.UseVisualStyleBackColor = true;
            this.rbno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbno_KeyDown);
            // 
            // llblallogin
            // 
            this.llblallogin.AutoSize = true;
            this.llblallogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblallogin.Location = new System.Drawing.Point(238, 333);
            this.llblallogin.Name = "llblallogin";
            this.llblallogin.Size = new System.Drawing.Size(134, 15);
            this.llblallogin.TabIndex = 15;
            this.llblallogin.TabStop = true;
            this.llblallogin.Text = "Already hava a account";
            this.llblallogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblallogin_LinkClicked);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(86, 372);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 16;
            this.btnreg.Text = "REGISTER";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(193, 372);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // forgetpanel
            // 
            this.forgetpanel.AutoSize = true;
            this.forgetpanel.BackgroundImage = global::LOGIN_MODEL.Properties.Resources.log2;
            this.forgetpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgetpanel.Controls.Add(this.btnfcan);
            this.forgetpanel.Controls.Add(this.btnsignup);
            this.forgetpanel.Controls.Add(this.llblalacc);
            this.forgetpanel.Controls.Add(this.txtrepass);
            this.forgetpanel.Controls.Add(this.lblrepass);
            this.forgetpanel.Controls.Add(this.txtpass);
            this.forgetpanel.Controls.Add(this.lblpass);
            this.forgetpanel.Controls.Add(this.txtuser);
            this.forgetpanel.Controls.Add(this.lbluser);
            this.forgetpanel.Location = new System.Drawing.Point(432, 82);
            this.forgetpanel.Name = "forgetpanel";
            this.forgetpanel.Size = new System.Drawing.Size(385, 256);
            this.forgetpanel.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(195, 47);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(108, 20);
            this.txtuser.TabIndex = 3;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(69, 47);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(90, 17);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "USERNAME";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(195, 91);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(108, 20);
            this.txtpass.TabIndex = 5;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(69, 91);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(89, 17);
            this.lblpass.TabIndex = 4;
            this.lblpass.Text = "PASSWORD";
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(195, 133);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.PasswordChar = '*';
            this.txtrepass.Size = new System.Drawing.Size(108, 20);
            this.txtrepass.TabIndex = 7;
            this.txtrepass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrepass_KeyDown);
            // 
            // lblrepass
            // 
            this.lblrepass.AutoSize = true;
            this.lblrepass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepass.Location = new System.Drawing.Point(69, 136);
            this.lblrepass.Name = "lblrepass";
            this.lblrepass.Size = new System.Drawing.Size(113, 17);
            this.lblrepass.TabIndex = 6;
            this.lblrepass.Text = "RE-PASSWORD";
            // 
            // llblalacc
            // 
            this.llblalacc.AutoSize = true;
            this.llblalacc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblalacc.Location = new System.Drawing.Point(248, 170);
            this.llblalacc.Name = "llblalacc";
            this.llblalacc.Size = new System.Drawing.Size(134, 15);
            this.llblalacc.TabIndex = 16;
            this.llblalacc.TabStop = true;
            this.llblalacc.Text = "Already hava a account";
            this.llblalacc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblalacc_LinkClicked);
            // 
            // btnfcan
            // 
            this.btnfcan.Location = new System.Drawing.Point(185, 205);
            this.btnfcan.Name = "btnfcan";
            this.btnfcan.Size = new System.Drawing.Size(75, 23);
            this.btnfcan.TabIndex = 19;
            this.btnfcan.Text = "CANCEL";
            this.btnfcan.UseVisualStyleBackColor = true;
            this.btnfcan.Click += new System.EventHandler(this.btnfcan_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(78, 205);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 18;
            this.btnsignup.Text = "SIGN UP";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LOGIN_MODEL.Properties.Resources.log2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 511);
            this.Controls.Add(this.regpanel);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.regpanel.ResumeLayout(false);
            this.regpanel.PerformLayout();
            this.Regmainpanel.ResumeLayout(false);
            this.Regmainpanel.PerformLayout();
            this.forgetpanel.ResumeLayout(false);
            this.forgetpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel regpanel;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel Regmainpanel;
        private System.Windows.Forms.TextBox txtmobno;
        private System.Windows.Forms.Label lblmobno;
        private System.Windows.Forms.ComboBox cmbgen;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.DateTimePicker dtbdob;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbyes;
        private System.Windows.Forms.Label lblpri;
        private System.Windows.Forms.RichTextBox rtxtaddr;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        internal System.Windows.Forms.LinkLabel llblallogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Panel forgetpanel;
        private System.Windows.Forms.Button btnfcan;
        private System.Windows.Forms.Button btnsignup;
        internal System.Windows.Forms.LinkLabel llblalacc;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.Label lblrepass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lbluser;
    }
}