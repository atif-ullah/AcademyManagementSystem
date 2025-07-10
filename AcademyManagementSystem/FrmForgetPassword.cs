using AcademyManagementSystem.BL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == "")
            {
                MessageBox.Show("Enter OTP");
            }
            else if (txtCreatePassword.Text == "")
            {
                MessageBox.Show("Create Password");
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Confirm your Password");
            }
            else
            {
                if (txtCreatePassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Re-confirm your password");
                }
                else
                {
                    DataTable dt = BlTblUser.CheckOTP(FrmGenerateOtp.Email, txtOTP.Text);
                    if (dt.Rows.Count > 0)
                    {
                        int check = BlTblUser.UpdatePassword(FrmGenerateOtp.Email, txtCreatePassword.Text);
                        if (check == 1)
                        {
                            MessageBox.Show("Password updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Password Updation failed");
                        }
                    }
                }
            }
        }

        private void txtOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtOTP.Text == "Enter OTP")
            {
                txtOTP.Text = "";
                txtOTP.ForeColor = Color.Black;
            }
        }

        private void txtCreatePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCreatePassword.Text == "Create New Password")
            {
                txtCreatePassword.Text = "";
                txtCreatePassword.ForeColor = Color.Black;
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
    }
}
