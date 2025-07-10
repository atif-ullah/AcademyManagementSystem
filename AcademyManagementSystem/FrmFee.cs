using AcademyManagementSystem.BL;
using AcademyManagementSystem.BlStudent;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmFee : Form
    {
        public FrmFee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (txtFeeAmount.Text == "")
            {
                LblFeeAmount.Text = "required";
            }
            else
            {


                if (FeeId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblFee obj = new BlTblFee();
                        obj.StudentId = (int)ddlStudent.SelectedValue;
                        obj.FeeAmount = txtFeeAmount.Text;
                        obj.IsDeleted = false;
                        obj.CreatedAt = dtpCreatedAt.Value.ToString("Y");
                        obj.FeeId = FeeId;
                        if (BlTblFee.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblFee");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblFee obj = new BlTblFee();
                        obj.StudentId = (int)ddlStudent.SelectedValue;
                        obj.FeeAmount = txtFeeAmount.Text;
                        obj.IsDeleted = false;
                        obj.CreatedAt = dtpCreatedAt.Value.ToString("Y");
                        if (BlTblFee.save(obj) == 1)
                        {
                            MessageBox.Show("Saved successfully");
                            DgvList.DataSource = BlTblFee.GetData();
                        }
                    }
                }
            }
        }

        int FeeId;

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 1)
                {
                    FeeId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["FeeId"].Value);
                    ddlStudent.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["StudentId"].Value);
                }
                else if (e.ColumnIndex == 0)
                {
                    FeeId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["FeeId"].Value);
                    DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                    {
                        if (BlTblFee.Delete(FeeId) == 1)
                        {
                            DgvList.DataSource = BlTblFee.GetData();
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tarsat dy kona werdo bya");
            }
        }
        private void FrmFee_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DgvList.DataSource = BlTblFee.GetData();
            ddlStudent.DataSource = BlTblStudent.GetStudentFullName();
            ddlStudent.DisplayMember = "StudentName";
            ddlStudent.ValueMember = "StudentId";
        }

        private void ddlStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int totalFee = 0;
            int StudentId = (int)ddlStudent.SelectedValue;
            DataTable dt = BlTblAdmission.GetStudentCourses(StudentId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int CourseId = (int)dt.Rows[i]["CourseId"];
                DataTable dtCourse = BlTblCourse.GetData(CourseId);
                int CourseFee = (int)dtCourse.Rows[0]["CourseFee"];
                totalFee += CourseFee;
            }
            txtFeeAmount.Text = Convert.ToString(totalFee);
            // txtFeeAmount.Text =""+totalFee;  
        }

        private void dtpPaid_ValueChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblFee.GetPaidStudents(dtpPaid.Value.ToString("Y"));
        }

        private void dtpUpPaid_ValueChanged(object sender, EventArgs e)
        {
            string Query = "select * from TblStudent where ";
            DataTable dt = BlTblFee.GetPaidStudents(dtpUpPaid.Value.ToString("Y"));
            int Length = dt.Rows.Count;
            if (Length > 1)
            {
                int i;
                for (i = 0; i < Length - 1; i++)
                {
                    Query += "StudentId <> " + dt.Rows[i]["StudentId"] + " and ";
                }
                if (Length == i + 1)
                {
                    Query += "StudentId <> " + dt.Rows[i]["StudentId"];
                }
                SqlDataAdapter adp = new SqlDataAdapter(Query, "server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
                dt = new DataTable();
                adp.Fill(dt);
                DgvList.DataSource = dt;
            }
            else if (Length == 1)
            {
                Query += "StudentId <> " + dt.Rows[0]["StudentId"];
                SqlDataAdapter adp = new SqlDataAdapter(Query, "server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
                dt = new DataTable();
                adp.Fill(dt);
                DgvList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Any payment for this month has not been paid");
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

