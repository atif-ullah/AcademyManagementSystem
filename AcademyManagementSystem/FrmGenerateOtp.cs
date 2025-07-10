using AcademyManagementSystem.BL;
using AcademyManagementSystem.CustomClasses;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmGenerateOtp : Form
    {
        public FrmGenerateOtp()
        {
            InitializeComponent();
        }
        public static string Email;
        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email");
            }
            else
            {
                DataTable dt = BlTblUser.CheckEmail(txtEmail.Text);
                if (dt.Rows.Count > 0)
                {
                    string OTP = ClsEmailOtp.GenerateOtp();
                    int check = ClsEmailOtp.SendEmail(txtEmail.Text, "emailsender785@gmail.com", "Forget Password", "You Otp code is:" + OTP + "");
                    if (check == 1)
                    {

                        check = BlTblUser.UpdateOTP(txtEmail.Text, OTP);
                        if (check > 0)
                        {
                            Email = txtEmail.Text;
                            FrmForgetPassword obj = new FrmForgetPassword();
                            this.Hide();
                            obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("OTP updation failed");
                        }
                    }
                }
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Text == "Enter Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
    }
}
