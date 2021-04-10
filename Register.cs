using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LOGIN_MODEL.Properties;
using System.Text.RegularExpressions;
namespace LOGIN_MODEL
{
    public partial class Register : Form
    {
        internal string btnname;
        string name, usname, pass, repass, dob, gen, mobno, email, address, role;
        DataTable dt = new DataTable();
        int uid;
        Common_actions ca = new Common_actions();
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            if (btnname == "Forget Password")
            {
                lbltitle.Text = "FORGET PASSWORD";
                forgetpanel.Visible = true;
                Regmainpanel.Visible = false;
                btnsignup.Text = "RESET";
                forgetpanel.Location = Regmainpanel.Location;
                forgetpanel.Width = Regmainpanel.Width;
                regpanel.Width = forgetpanel.Width;
                regpanel.Height = forgetpanel.Height;
                this.Width = regpanel.Width;
                this.Height = regpanel.Height;
                regpanel.Update();
                this.Update();
            }
            if (btnname == "Signup")
            {
                forgetpanel.Visible = false;
                Regmainpanel.Visible = true;
                regpanel.Width = Regmainpanel.Width;
                regpanel.Height = Regmainpanel.Height;
                this.Width = regpanel.Width;
                this.Height = regpanel.Height;
                regpanel.Update();
                this.Update();
            }
        }
        #region KEY DOWN FUNCTIONS
        private void cmbgen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtmobno_TextChanged(object sender, EventArgs e)
        {

        }
        private void Txtname_KeyDown(object sender, KeyEventArgs e)
        {
            Regex name = new Regex("^[A-Z][a-zA-Z]*$");
            if (e.KeyCode == Keys.Enter)
            {
                if (Txtname.Text != "")
                {
                    if (name.IsMatch(Txtname.Text))
                    {
                        dtbdob.Focus();
                    }
                    else
                    {
                        Console.WriteLine("INVALID NAME");
                        Txtname.Focus();
                    }
                }
                else
                {
                    Console.WriteLine(" NAME CANNOT BE EMPTY");
                    Txtname.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (Txtname.Text != "")
                {
                    if (name.IsMatch(Txtname.Text))
                    {
                        dtbdob.Focus();
                    }
                    else
                    {
                        Console.WriteLine("INVALID NAME");
                        Txtname.Focus();
                    }
                }
                else
                {
                    Console.WriteLine(" NAME CANNOT BE EMPTY");
                    Txtname.Focus();
                }
            }
            else
                Txtname.Focus();
        }
        private void dtbdob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbgen.Focus();
            else if (e.KeyCode == Keys.Tab)
                cmbgen.Focus();
            else
                dtbdob.Focus();
        }
        private void cmbgen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmobno.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtmobno.Focus();
            }
            else
            {
                cmbgen.Focus();
            }
        }
        private void txtmobno_KeyDown(object sender, KeyEventArgs e)
        {
            Regex Mno = new Regex(@"^[6-9]\d{9}$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtmobno.Text != "")
                {
                    if (Mno.IsMatch(txtmobno.Text))
                    {
                        txtemail.Focus();
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOBILE NUMBER");
                        txtmobno.Focus();
                    }
                }
                else
                {
                    Console.WriteLine(" MOBILE NUMBER CANNOT BE EMPTY");
                    txtmobno.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (txtmobno.Text != "")
                {
                    if (Mno.IsMatch(txtmobno.Text))
                    {
                        txtemail.Focus();
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOBILE NUMBER");
                        txtmobno.Focus();
                    }
                }
                else
                {
                    Console.WriteLine(" MOBILE NUMBER CANNOT BE EMPTY");
                    txtmobno.Focus();
                }
            }
            else
                txtmobno.Focus();
        }
        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            Regex emailformat = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtemail.Text != "")
                {
                    if (emailformat.IsMatch(txtemail.Text))
                        rtxtaddr.Focus();
                    else
                    {
                        Console.WriteLine("INVALID EMAIL ID");
                        txtemail.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("EMAIL ID CANNOT BE EMPTY");
                    txtemail.Focus();
                }
            }
        }
        private void rtxtaddr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rtxtaddr.Text != "")
                    rbyes.Focus();
                else
                {
                    Console.WriteLine("ADDRESS CANNOT BE EMPTY");
                    rtxtaddr.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (rtxtaddr.Text != "")
                    rbyes.Focus();
                else
                {
                    Console.WriteLine("ADDRESS CANNOT BE EMPTY");
                    rtxtaddr.Focus();
                }
            }
            else
                rtxtaddr.Focus();
        }
        private void rbyes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rbyes.Checked == true)
                {
                    rbno.Checked = false;
                    btnreg.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (rbyes.Checked == true)
                {
                    rbno.Checked = false;
                    btnreg.Focus();
                }
            }
            else
                rbyes.Focus();
        }
        private void rbno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rbno.Checked == true)
                {
                    rbyes.Checked = false;
                    btnreg.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (rbno.Checked == true)
                {
                    rbyes.Checked = false;
                    btnreg.Focus();
                }
            }
            else
                rbyes.Focus();
        }
        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtuser.Text != "")
                {
                    dt = ca.priv(txtuser.Text);
                    try
                    {
                        if (dt.Rows.Count >0)
                        {
                            txtpass.Focus();
                        }
                        else
                        {
                            Console.WriteLine("INVALID USER");
                        }  
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("INVALID USER" + ex.ToString());
                    }    
                }
                else
                {
                    Console.WriteLine("USERNAME NOT EMPTY");
                    txtuser.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (txtuser.Text != "")
                {
                    dt = ca.priv(txtuser.Text);
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            txtpass.Focus();
                        }
                        else
                        {
                            Console.WriteLine("INVALID USER");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("INVALID USER" + ex.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("USERNAME NOT EMPTY");
                    txtuser.Focus();
                }
            }
            else
                txtuser.Focus();
        }
        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            Regex pass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,12}$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpass.Text != "")
                {
                    if (pass.IsMatch(txtpass.Text))
                    {
                        txtrepass.Focus();
                    }
                    else
                    {
                        Console.WriteLine("PASSWORD NOT STRONG");
                        txtpass.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("PASWWORD NOT EMPTY");
                    txtpass.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (txtpass.Text != "")
                {
                    if (pass.IsMatch(txtpass.Text))
                    {
                        txtrepass.Focus();
                    }
                    else
                    {
                        Console.WriteLine("PASSWORD NOT STRONG");
                        txtpass.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("PASWWORD NOT EMPTY");
                    txtpass.Focus();
                }
            }
            else
                txtpass.Focus();
        }
        private void txtrepass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtrepass.Text != "")
                {
                    if (txtpass.Text == txtrepass.Text)
                        btnsignup.Focus();
                    else
                    {
                        Console.WriteLine(" PASWORD AND REPASSWORD NOT MATCH");
                        txtpass.Text = "";
                        txtrepass.Text = "";
                        txtpass.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("REPASSWORD NOT EMPTY");
                    txtrepass.Focus();
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (txtrepass.Text != "")
                {
                    if (txtpass.Text == txtrepass.Text)
                        btnsignup.Focus();
                    else
                    {
                        Console.WriteLine(" PASWORD AND REPASSWORD NOT MATCH");
                        txtpass.Text = "";
                        txtrepass.Text = "";
                        txtpass.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("REPASSWORD NOT EMPTY");
                    txtrepass.Focus();
                }
            }
            else
                txtrepass.Focus();
        }
        #endregion
        #region BUTTON CLICK FUNCTIONS
        private void llblallogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            if (Txtname.Text != "" && cmbgen.Text != "" && txtmobno.Text != "" && txtemail.Text != "" && rtxtaddr.Text !="")
            {
                name = Txtname.Text;
                dob = dtbdob.Value.ToString("dd/MM/yyyy");
                gen = cmbgen.Text;
                mobno = txtmobno.Text;
                email = txtemail.Text;
                address = rtxtaddr.Text;
                if (rbyes.Checked == true)
                {
                    role = "Y";
                }
                else
                {
                    role = "N";
                }
                dt = ca.sel();
                if (dt.Rows.Count != 0)
                {
                    uid = 1;
                }
                else
                {
                    uid = dt.Rows.Count + 1;
                }
                forgetpanel.Visible = true;
                Regmainpanel.Visible = false;
                forgetpanel.Location = Regmainpanel.Location;
                forgetpanel.Width = Regmainpanel.Width;
                regpanel.Width = forgetpanel.Width;
                regpanel.Height = forgetpanel.Height;
                this.Width = regpanel.Width;
                this.Height = regpanel.Height;
                regpanel.Update();
                this.Update();
            }
            else
            {
                MessageBox.Show("Please Enter all fields");
            }       
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }   
        private void llblalacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            usname = txtuser.Text;
            pass = txtpass.Text;
            repass = txtrepass.Text;
            if(txtuser.Text != "" && txtpass.Text != "" && txtrepass.Text != "")
            {
                if (btnname == "Forget Password")
                {
                    ca.passupdate(usname, pass, repass);
                }
                else
                {
                    ca.userinsert(uid, name, usname, pass, repass, dob, gen, mobno, email, address, role);
                }
                Login log = new Login();
                this.Close();
                log.Show();
            }
            else
            {
                MessageBox.Show("Please Enter all fields");
            }
            
        }
        private void btnfcan_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }
        #endregion
    }
}
