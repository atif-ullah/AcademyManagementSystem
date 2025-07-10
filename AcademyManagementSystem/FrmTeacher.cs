using AcademyManagementSystem.BlTeacher;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }
        private Image loadImage(byte[] img)
        {
            MemoryStream stream = new MemoryStream();
            return Image.FromStream(stream);
        }
        private byte[] getimage()
        {
            MemoryStream stream = new MemoryStream();
            ImgUser.Image.Save(stream, ImgUser.Image.RawFormat);
            return stream.GetBuffer();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                lblFirstName.Text = "required";
            }
            else if (txtLastName.Text == "")
            {
                lblLastName.Text = "required";
            }
            else if (txtcontact.Text == "")
            {
                lblContact.Text = "required";
            }
            else if (txtCnic.Text == "")
            {
                lblCnic.Text = "required";
            }
            else if (txtEmail.Text == "")
            {
                lblEmail.Text = "required";
            }
            else if (txtAddress.Text == "")
            {
                lblAddress.Text = "required";
            }
            else if (txtCnic.Text.Length < 13)
            {
                lblCnic.Text = "invalid Cnic";
            }
            else if (txtcontact.Text.Length < 11)
            {
                lblContact.Text = "invalid";
            }
            else
            {
                string[] value = txtEmail.Text.Split('@');
                if (txtEmail.Text.Contains("@gmail.com") == false)
                {
                    lblEmail.Text = "@gmail.com is reauired";
                }
                else if (value[0] == "")
                {
                    lblEmail.Text = "Use Example @gmail .com";
                }
                else if (value[1].Length > 9)
                {
                    lblEmail.Text = ".com is valid only";
                }
                else
                {
                    if (TeacherId > 0)
                    {
                        DataTable dt20 = BlTblTeacher.CheckDublicateUpdate("email", txtEmail.Text, TeacherId);
                        DataTable dt22 = BlTblTeacher.CheckDublicateUpdate("contact", txtcontact.Text, TeacherId);
                        DataTable dt23 = BlTblTeacher.CheckDublicateUpdate("cnic", txtCnic.Text, TeacherId);
                        if (dt20.Rows.Count > 0)
                        {
                            MessageBox.Show("this email:" + txtEmail.Text + "is already exist");
                        }
                        else if (dt22.Rows.Count > 0)
                        {
                            MessageBox.Show("this contact:" + txtcontact.Text + "is already exist");
                        }
                        else if (dt23.Rows.Count > 0)
                        {
                            MessageBox.Show("thic  Cnic:" + txtCnic.Text + "is already exist");
                        }

                        else
                        {
                            if (MessageBox.Show("are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                BlTblTeacher obj = new BlTblTeacher();
                                obj.FirstName = txtFirstName.Text;
                                obj.LastName = txtLastName.Text;
                                obj.Image = getimage();
                                obj.Contact = txtcontact.Text;
                                obj.Cnic = txtCnic.Text;
                                obj.Email = txtEmail.Text;
                                obj.Address = txtAddress.Text;
                                obj.TeacherId = TeacherId;

                                obj.IsDeleted = false;
                                if (BlTblTeacher.Save(obj) == 1)
                                {
                                    MessageBox.Show("Updated");
                                    DgvList.DataSource = DataAccess.SpGetData("select * from TblTeacher");
                                }
                            }
                        }
                    }
                    else
                    {
                        DataTable dt25 = BlTblTeacher.CheckDublicateEntry("Email", txtEmail.Text);
                        DataTable dt26 = BlTblTeacher.CheckDublicateEntry("Contact", txtcontact.Text);
                        DataTable dt27 = BlTblTeacher.CheckDublicateEntry("Cnic", txtCnic.Text);
                        if (dt25.Rows.Count > 0)
                        {
                            MessageBox.Show("this email:" + txtEmail.Text + "is already exist");
                        }
                        else if (dt26.Rows.Count > 0)
                        {
                            MessageBox.Show("this contact:", txtcontact.Text + "is already exist");
                        }
                        else if (dt27.Rows.Count > 0)
                        {
                            MessageBox.Show("this Cnic", txtCnic.Text + "is already exist");
                        }
                        else
                        {
                            if (MessageBox.Show(" are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                BlTblTeacher obj = new BlTblTeacher();
                                obj.FirstName = txtFirstName.Text;
                                obj.LastName = txtLastName.Text;
                                obj.Image = getimage();
                                obj.Contact = txtcontact.Text;
                                obj.Cnic = txtCnic.Text;
                                obj.Email = txtEmail.Text;
                                obj.Address = txtAddress.Text;
                                obj.TeacherId = TeacherId;

                                obj.IsDeleted = false;
                                if (BlTblTeacher.Save(obj) == 1)
                                {
                                    MessageBox.Show("inserted");
                                    DgvList.DataSource = DataAccess.SpGetData("Select * from TblTeacher");
                                    //FrmSalary Salary = new FrmSalary();
                                    //this.Hide();
                                    //Salary.ShowDialog();

                                }
                            }
                        }
                    }
                }
            }
        }

        int TeacherId;
        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                TeacherId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["TeacherId"].Value);
                txtFirstName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["FirstName"].Value);
                txtLastName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["LastName"].Value);
                txtCnic.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Cnic"].Value);
                txtcontact.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Contact"].Value);
                txtAddress.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Address"].Value);
                txtEmail.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Email"].Value);
            }
            else if (e.ColumnIndex == 1)
            {
                TeacherId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["TeacherId"].Value);
                DialogResult d = MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblTeacher.Delete(TeacherId) == 1)
                    {
                        DgvList.DataSource = BlTblTeacher.GetData();
                    }
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFirstName.Text = "";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Text = "";
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            lblContact.Text = "";
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

        private void ImgUser_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ImgUser.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') & (e.KeyChar != 8))
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

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            if (txtcontact.Text.Length > 11)
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
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar < 'a' || e.KeyChar > 'z') & (e.KeyChar != 8) & (e.KeyChar != '@') & (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DataTable dt = BlTblTeacher.GetData();
            DgvList.DataSource = dt;
            if (FrmSalary.checkTeacher == 1)
            {
                TeacherId = FrmSalary.TeacherId;
                txtFirstName.Text = FrmSalary.FirstName;
                txtLastName.Text = FrmSalary.LastName;
                txtEmail.Text = FrmSalary.email;
                txtAddress.Text = FrmSalary.address;
                txtcontact.Text = FrmSalary.contact;
                txtCnic.Text = FrmSalary.CNIC;
            }
        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }
    }
}

