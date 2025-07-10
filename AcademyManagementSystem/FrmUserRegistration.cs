using AcademyManagementSystem.BL;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmUserRegistration : Form
    {
        public FrmUserRegistration()
        {
            InitializeComponent();
        }
        private Image LoadImage(byte[] img)
        {
            MemoryStream stream = new MemoryStream(img);
            return Image.FromStream(stream);
        }
        private byte[] GetImage()
        {
            MemoryStream stream = new MemoryStream();
            ImgUser.Image.Save(stream, ImgUser.Image.RawFormat);
            return stream.GetBuffer();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                lblFirstName.Text = "Required";
            }
            else if (txtLastName.Text == "")
            {
                lblLastName.Text = "Required";
            }
            else if (txtUserName.Text == "")
            {
                lblUserName.Text = "Required";
            }
            else if (txtCnic.Text == "")
            {
                lblCnic.Text = "Required";
            }
            else if (txtContact.Text == "")
            {
                lblContact.Text = "Required";
            }
            else if (txtPassword.Text == "")
            {
                lblPassword.Text = "Required";
            }
            else if (txtAddress.Text == "")
            {
                lblAddress.Text = "Required";
            }
            else if (txtEmail.Text == "")
            {
                lblEmail.Text = "Required";
            }
            else if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                lblGender.Text = "Required";
            }
            else if (txtContact.Text.Length < 11)
            {
                lblContact.Text = "Invalid Contact";
            }
            else if (txtCnic.Text.Length < 13)
            {
                lblCnic.Text = "Invalid Cnic";
            }
            else
            {
                string[] value = txtEmail.Text.Split('@');
                if (txtEmail.Text.Contains("@gmail.com") == false)
                {
                    lblEmail.Text = "@gmail.com is required";
                }
                else if (value[0] == "")
                {
                    lblEmail.Text = "Use example @gmail.com";
                }
                else if (value[1].Length > 9)
                {
                    lblEmail.Text = ".com is valid only";
                }
                else
                {
                    if (UserId > 0)
                    {
                        DataTable dt5 = BlTblUser.CheckDublicateUpdate("UserName", txtUserName.Text, UserId);
                        DataTable dt6 = BlTblUser.CheckDublicateUpdate("Email", txtEmail.Text, UserId);
                        DataTable dt7 = BlTblUser.CheckDublicateUpdate("Contact", txtContact.Text, UserId);
                        DataTable dt8 = BlTblUser.CheckDublicateUpdate("Cnic", txtCnic.Text, UserId);
                        if (dt5.Rows.Count > 0)
                        {
                            MessageBox.Show("This UserName:" + txtUserName.Text + " is Already exist");
                        }
                        else if (dt6.Rows.Count > 0)
                        {
                            MessageBox.Show("This Email:" + txtEmail.Text + " is Already exist");
                        }
                        else if (dt7.Rows.Count > 0)
                        {
                            MessageBox.Show("This Contact:" + txtContact.Text + " is Already exist");
                        }
                        else if (dt8.Rows.Count > 0)
                        {
                            MessageBox.Show("This Cnic:" + txtContact.Text + " is Already exist");
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                BlTblUser obj = new BlTblUser();
                                obj.FirstName = txtFirstName.Text;
                                obj.LastName = txtLastName.Text;
                                obj.UserName = txtUserName.Text;
                                obj.CNIC = txtCnic.Text;
                                obj.Image = GetImage();
                                obj.Contact = txtContact.Text;
                                obj.Password = txtPassword.Text;
                                obj.Address = txtAddress.Text;
                                obj.Email = txtEmail.Text;
                                obj.UserId = UserId;
                                obj.IsDeleted = false;
                                if (BlTblUser.Save(obj) == 1)
                                {
                                    MessageBox.Show("Updated");
                                    DgvList.DataSource = BlTblUser.GetData();
                                }

                            }
                        }
                    }
                    else
                    {
                        DataTable dt1 = BlTblUser.CheckDuplicateUser("UserName", txtUserName.Text);
                        DataTable dt2 = BlTblUser.CheckDuplicateUser("Email", txtEmail.Text);
                        DataTable dt3 = BlTblUser.CheckDuplicateUser("Contact", txtContact.Text);
                        DataTable dt4 = BlTblUser.CheckDuplicateUser("Cnic", txtCnic.Text);
                        if (dt1.Rows.Count > 0)
                        {
                            MessageBox.Show("This Username:" + txtUserName.Text + " is already exist");
                        }
                        else if (dt2.Rows.Count > 0)
                        {
                            MessageBox.Show("This Email:" + txtEmail.Text + " is already exist");
                        }
                        else if (dt3.Rows.Count > 0)
                        {
                            MessageBox.Show("This Contactl:" + txtContact.Text + " is already exist");
                        }
                        else if (dt4.Rows.Count > 0)
                        {
                            MessageBox.Show("This CNIC:" + txtCnic.Text + " is already exist");
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                BlTblUser obj = new BlTblUser();
                                obj.FirstName = txtFirstName.Text;
                                obj.LastName = txtLastName.Text;
                                obj.UserName = txtUserName.Text;
                                obj.CNIC = txtCnic.Text;
                                obj.Image = GetImage();
                                obj.Contact = txtContact.Text;
                                obj.Password = txtPassword.Text;
                                obj.Address = txtAddress.Text;
                                obj.Email = txtEmail.Text;
                                obj.Status = ddlStatus.Text;
                                obj.Role = ddlRole.Text;

                                obj.IsDeleted = false;
                                if (rdoMale.Checked == true)
                                {
                                    obj.Gender = "Male";
                                }
                                else if (rdoFemale.Checked == true)
                                {
                                    obj.Gender = "Female";
                                }
                                if (BlTblUser.Save(obj) == 1)
                                {
                                    FrmHome home = new FrmHome();
                                    this.Hide();
                                    home.ShowDialog();
                                }
                            }

                        }
                    }


                }

            }
        }
        int UserId;

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                UserId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["UserId"].Value);
                txtFirstName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["FirstName"].Value);
                txtLastName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["LastName"].Value);
                txtUserName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["UserName"].Value);
                txtCnic.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Cnic"].Value);
                txtContact.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Contact"].Value);
                txtPassword.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Password"].Value);
                txtAddress.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Address"].Value);
                txtEmail.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Email"].Value);
            }
            else if (e.ColumnIndex == 1)
            {
                UserId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["UserId"].Value);
                DialogResult d = MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblUser.Delete(UserId) == 1)
                    {
                        DgvList.DataSource = BlTblUser.GetData();
                    }
                }
            }
        }

        private void ImgUser_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ImgUser.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ImgUser.Image = Properties.Resources.images;
        }

        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvList.Columns[e.ColumnIndex].Name == "Image")
            {
                DataGridViewImageCell cell = DgvList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                cell.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFirstName.Text = "";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Text = "";
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblUserName.Text = "";
                char ch = txtUserName.Text[0];
                if (ch >= '0' & ch <= '9')
                {
                    lblUserName.Text = "First Character must not be Integer";
                }
            }
            catch
            {

            }
        }

        private void pnlGender_Paint(object sender, PaintEventArgs e)
        {
            lblGender.Text = "";
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            lblCnic.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmail.Text = "";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            lblAddress.Text = "";
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            lblContact.Text = "";

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Text = "";
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8))

            {
                e.Handled = true;
            }
            if (txtContact.Text.Length > 11)
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') & (e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8) & (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            if (txtCnic.Text.Length > 13)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') & (e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8) & (e.KeyChar != '@') & (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtcnc_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblUser.Search("Cnic", txtcnc.Text);
        }

        private void txteml_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblUser.Search("Email", txteml.Text);
        }
       
        private void txtcnt_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblUser.Search("Contact", txtcnt.Text);
        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }

        private void FrmUserRegistration_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DataTable dt = BlTblUser.GetData();
            DgvList.DataSource = dt;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUser.Text == "UserName")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtcnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUser.Text == "CNIC")
            {
                txtcnc.Text = "";
                txtcnc.ForeColor = Color.Black;
            }
        }

        private void txteml_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txteml.Text == "Email")
            {
                txteml.Text = "";
                txteml.ForeColor = Color.Black;
            }
        }

        private void txtcnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtcnt.Text == "UserName")
            {
                txtcnt.Text = "";
                txtcnt.ForeColor = Color.Black;
            }
        }

        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblUser.Search("UserName", txtUser.Text);
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

