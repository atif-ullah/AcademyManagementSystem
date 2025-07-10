using AcademyManagementSystem.BL;
using GymManagementSystem;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtEmailContact.Text == "")
            {
                MessageBox.Show("Email or Contact required");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password required");
            }
            else if (txtCreateNewPassword.Text == "")
            {
                MessageBox.Show("New Password required");
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Confirm your Password");
            }
            else
            {
                if (txtCreateNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Re-Confirm your password");
                }
                else
                {
                    DataTable dt = BlTblUser.CheckForChangePassword(txtEmailContact.Text);
                    if (dt.Rows.Count > 0)
                    {
                        dt = BlTblUser.CheckForChangePassword(txtEmailContact.Text, txtPassword.Text);
                        if (dt.Rows.Count > 0)
                        {
                            int check = BlTblUser.UpdatePassword(txtEmailContact.Text, txtCreateNewPassword.Text);
                            if (check > 0)
                            {
                                MessageBox.Show("Password changed successfully");
                            }
                            else
                            {
                                MessageBox.Show("Password Updation failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Contact");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void txtEmailContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmailContact.Text == "Enter Email/Contact")
            {
                txtEmailContact.Text = "";
                txtEmailContact.ForeColor = Color.Black;
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

        private void txtCreateNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCreateNewPassword.Text == "Create New Passowrd")
            {
                txtCreateNewPassword.Text = "";
                txtCreateNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Your Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}

