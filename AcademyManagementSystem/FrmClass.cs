using AcademyManagementSystem.BlClass;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Data;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
        }
        int ClassId;
        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ClassId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ClassId"].Value);
                txtClassName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["ClassName"].Value);
            }
            else if (e.ColumnIndex == 1)
            {
                ClassId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ClassId"].Value);
                DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblClass.Delete(ClassId) == 1)
                    {
                        DgvList.DataSource = BlTblClass.GetData();
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = BlTblClass.DuplicateClassTime(ddlClassTime.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Duplicate Class Time!");
            }
            else if (txtClassName.Text == "")
            {
                lblClassName.Text = "required";
            }
            else
            {
                if (ClassId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblClass obj = new BlTblClass();
                        obj.ClassName = txtClassName.Text;
                        obj.Status = ddlStatus.Text;
                        obj.ClassTime = ddlClassTime.Text;
                        obj.IsDeleted = false;
                        obj.ClassId = ClassId;
                        if (BlTblClass.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblClass");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblClass obj = new BlTblClass();
                        obj.ClassName = txtClassName.Text;
                        obj.Status = ddlStatus.Text;
                        obj.ClassTime = ddlClassTime.Text;
                        obj.IsDeleted = false;

                        if (BlTblClass.save(obj) == 1)
                        {
                            MessageBox.Show("Inserted");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblClass");
                        }
                    }
                }
            }

        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DataTable dt = BlTblClass.GetData();
            DgvList.DataSource = dt;
        }
    }
}