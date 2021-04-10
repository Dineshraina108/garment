using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LOGIN_MODEL.Properties;

namespace LOGIN_MODEL
{
    public partial class Login : Form
    {
        Common_actions ca = new Common_actions();
        public string uname, pass;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        #region KEY DOWN FUNCTIONS
        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            if (e.KeyCode == Keys.Enter)
                if (txtuser.Text != "")
                {
                    uname = txtuser.Text;
                    dt = ca.priv(uname);
                    try
                    {
                        if (dt.Rows[0].Field<string>("PRIVILAGE") == "Y")
                        {
                            llblsignup.Visible = true;
                            lblslash.Visible = true;
                        }
                        else
                        {
                            llblsignup.Visible = false;
                            lblslash.Visible = false;
                        }
                        txtpass.Focus();
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
            else if (e.KeyCode == Keys.Tab)
            {
                if (txtuser.Text != "")
                {
                    uname = txtuser.Text;
                    dt = ca.priv(uname);
                    try
                    {
                        if (dt.Rows[0].Field<string>("PRIVILAGE") == "Y")
                        {
                            llblsignup.Visible = true;
                            lblslash.Visible = true;
                        }
                        else
                        {
                            llblsignup.Visible = false;
                            lblslash.Visible = false;
                        }
                        txtpass.Focus();
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
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpass.Text != "")
                {
                    btnsignin.Focus();
                }
                else
                {
                    Console.WriteLine("PASSWORD NOT EMPTY");
                    txtpass.Focus();
                }
            }

            else if (e.KeyCode == Keys.Tab)
            {
                if (txtpass.Text != "")
                {
                    btnsignin.Focus();
                }
                else
                {
                    Console.WriteLine("PASSWORD NOT EMPTY");
                    txtpass.Focus();
                }
            }
            else
                txtpass.Focus();
        }
        #endregion
        #region BUTTON CLICK FUNCTIONS
        private void llblforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register  reg1 = new Register();
            using (Register reg = new Register())
            {
                reg1.btnname = llblforgetpassword.Text;
            }
            reg1.Show();
        }
        private void llblsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            using (Register reg1 = new Register())
            {
                reg.btnname = llblsignup.Text;
            }
            reg.Show();
        }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtuser.Text != " " && txtpass.Text != " ")
            {
                uname = txtuser.Text;
                pass = txtpass.Text;
                dt = ca.uservalid(uname, pass);
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        // this.Close(); 
                        this.Hide();
                        PRODUCT.Home P = new PRODUCT.Home();
                        P.Show();
                    }
                    else
                    {
                        MessageBox.Show("IVALID USERNAME OR PASSWORD");
                        txtuser.Text = "";
                        txtpass.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("INVALID USER" + ex.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("IVALID USERNAME OR PASSWORD");
                txtuser.Text = "";
                txtpass.Text = "";
            }
        }
        #endregion
    }
}
