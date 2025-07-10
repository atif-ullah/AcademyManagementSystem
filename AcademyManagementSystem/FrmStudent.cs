using AcademyManagementSystem.BlStudent;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        public static int check = 0;
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
            else if (txtcontact.Text == "")
            {
                lblContact.Text = "Required";
            }
            else if (txtCnic.Text == "")
            {
                lblCnic.Text = "Required";
            }
            else if (txtEmail.Text == "")
            {
                lblEmail.Text = "Required";
            }
            else if (txtaddress.Text == "")
            {
                lblAddress.Text = "Required";
            }
            else if (txtcontact.Text.Length < 11)
            {
                lblContact.Text = "invalid contact";
            }
            else if (txtCnic.Text.Length < 13)
            {
                lblCnic.Text = "Invalid CNIC";
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
                    lblEmail.Text = "Use Example @gmail.com";
                }
                else if (value[1].Length > 9)
                {
                    lblEmail.Text = ".com is valid only";
                }
                else
                {
                    if (StudentId > 0)
                    {
                        DataTable dt12 = BlTblStudent.CheckDublicateUpdate("Email", txtEmail.Text, StudentId);
                        DataTable dt13 = BlTblStudent.CheckDublicateUpdate("Contact", txtcontact.Text, StudentId);
                        DataTable dt14 = BlTblStudent.CheckDublicateUpdate("Cnic", txtCnic.Text, StudentId);
                        if (dt12.Rows.Count > 0)
                        {
                            MessageBox.Show("This Email:" + txtEmail.Text + " is Already exist");
                        }
                        else if (dt13.Rows.Count > 0)
                        {
                            MessageBox.Show("This Contact:" + txtcontact.Text + " is Already exist");
                        }
                        else if (dt14.Rows.Count > 0)
                        {
                            MessageBox.Show("This Cnic:" + txtCnic.Text + " is Already exist");
                        }
                        else
                        {


                            if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                BlTblStudent obj = new BlTblStudent();
                                obj.FirstName = txtFirstName.Text;
                                obj.LastName = txtLastName.Text;
                                obj.Image = GetImage();
                                obj.Cnic = txtCnic.Text;
                                obj.Contact = txtcontact.Text;
                                obj.Address = txtaddress.Text;
                                obj.Email = txtEmail.Text;
                                obj.StudentId = StudentId;

                                obj.IsDeleted = false;
                                if (BlTblStudent.Save(obj) == 1)
                                {
                                    MessageBox.Show("Updated");
                                    dgvList.DataSource = DataAccess.SpGetData("Select * from TblStudent");
                                }

                            }
                        }
                    }

                    else
                    {
                        DataTable dt9 = BlTblStudent.CheckDublicateEntry("Email", txtEmail.Text);
                        DataTable dt10 = BlTblStudent.CheckDublicateEntry("contact", txtcontact.Text);
                        DataTable dt11 = BlTblStudent.CheckDublicateEntry("Cnic", txtCnic.Text);
                        if (dt9.Rows.Count > 0)
                        {
                            MessageBox.Show("This Email:" + txtEmail.Text + " is already exist");
                        }
                        else if (dt10.Rows.Count > 0)
                        {
                            MessageBox.Show("This contactl:" + txtcontact.Text + " is already exist");
                        }
                        else if (dt11.Rows.Count > 0)
                        {
                            MessageBox.Show("This CNIC:" + txtCnic.Text + " is already exist");
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                BlTblStudent obj = new BlTblStudent();
                                obj.FirstName = txtFirstName.Text;
                                obj.LastName = txtLastName.Text;
                                obj.Cnic = txtCnic.Text;
                                obj.Contact = txtcontact.Text;
                                obj.Address = txtaddress.Text;
                                obj.Email = txtEmail.Text;
                                obj.Status = ddlStatus.Text;
                                obj.Image = GetImage();

                                obj.IsDeleted = false;
                                if (BlTblStudent.Save(obj) == 1)
                                {
                                    MessageBox.Show("inserted");
                                    dgvList.DataSource = DataAccess.SpGetData("select * from TblStudent");
                                    FrmAddmision Obj = new FrmAddmision();
                                    check = 1;
                                    this.Hide();
                                    Obj.ShowDialog();
                                }
                            }

                        }

                    }

                }
            }
        }
        // int studentId;
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

        private void txtaddress_TextChanged(object sender, EventArgs e)
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

        private void btnRemove_Click(object sender, EventArgs e)

        {
            ImgUser.Image = Properties.Resources.images;

        }

        int StudentId;
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                StudentId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["StudentId"].Value);
                txtFirstName.Text = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["FirstName"].Value);
                txtLastName.Text = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["LastName"].Value);
                txtCnic.Text = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["Cnic"].Value);
                txtcontact.Text = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["Contact"].Value);
                txtaddress.Text = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["Address"].Value);
                txtEmail.Text = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["Email"].Value);
            }
            else if (e.ColumnIndex == 1)
            {
                StudentId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["StudentId"].Value);
                DialogResult d = MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblStudent.Delete(StudentId) == 1)
                    {
                        dgvList.DataSource = BlTblStudent.GetData();

                    }
                }
            }
        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvList.Columns[e.ColumnIndex].Name == "Image")
            {
                DataGridViewImageCell cell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                cell.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                dgvList.Columns[0].Visible = false;
                dgvList.Columns[1].Visible = false;
            }
            DataTable dt = BlTblStudent.GetData();
            dgvList.DataSource = dt;
        }
    }
}
