using AcademyManagementSystem.BL;
using GymManagementSystem;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string UserRole = "";
        public static int UserId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailUserNameContact.Text == "")
            {
                lblEmailUserNameContact.Text = "Required";
            }
            else if (txtPassword.Text == "")
            {
                lblPassword.Text = "Required";
            }
            else
            {
                DataTable dt = BlTblUser.Login(txtEmailUserNameContact.Text);
                if (dt.Rows.Count > 0)
                {
                    dt = BlTblUser.Login(txtEmailUserNameContact.Text, txtPassword.Text);
                    if (dt.Rows.Count > 0)
                    {
                        UserRole = "" + dt.Rows[0]["Role"];
                        UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                        FrmHome obj = new FrmHome();
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Email or Contact");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGenerateOtp obj = new FrmGenerateOtp();
            this.Hide();
            obj.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangePassword obj = new FrmChangePassword();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtEmailUserNameContact_TextChanged(object sender, EventArgs e)
        {
            lblEmailUserNameContact.Text = "";
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Text = "";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUserRegistration obj = new FrmUserRegistration();
            this.Hide();
            obj.ShowDialog();
        }
        private void txtEmailUserNameContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmailUserNameContact.Text == "Enter Email/Contact")
            {
                txtEmailUserNameContact.Text = "";
                txtEmailUserNameContact.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home=new FrmHome();
            this.Hide();
            home.ShowDialog();
        }
    }
}

