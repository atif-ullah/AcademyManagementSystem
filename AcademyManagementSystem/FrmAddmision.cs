using AcademyManagementSystem.BL;
using AcademyManagementSystem.BlClass;
using AcademyManagementSystem.BlStudent;
using AcademyManagementSystem.BlTeacher;
using GymManagementSystem;
using System;
using System.Data;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmAddmision : Form
    {
        public FrmAddmision()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = BlTblAdmission.CheckDuplicateClassTime((int)ddlStudent.SelectedValue, (int)ddlClass.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Duplicate class time!");
            }
            else
            {
                if (AdmissionId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblAdmission obj = new BlTblAdmission();
                        obj.StudentId = (int)ddlStudent.SelectedValue;
                        obj.TeacherId = (int)ddlTeacher.SelectedValue;
                        obj.CourseId = (int)ddlCourse.SelectedValue;
                        obj.ClassId = (int)ddlClass.SelectedValue;
                        obj.Status = ddlStatus.Text;
                        obj.AdmissionId = AdmissionId;
                        obj.IsDeleted = false;
                        obj.AdmissionId = AdmissionId;
                        if (BlTblAdmission.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = BlTblAdmission.GetData();
                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblAdmission obj = new BlTblAdmission();
                        obj.StudentId = (int)ddlStudent.SelectedValue;
                        obj.TeacherId = (int)ddlTeacher.SelectedValue;
                        obj.CourseId = (int)ddlCourse.SelectedValue;
                        obj.ClassId = (int)ddlClass.SelectedValue;
                        obj.Status = ddlStatus.Text;
                        obj.IsDeleted = false;
                        if (BlTblAdmission.save(obj) == 1)
                        {
                            MessageBox.Show("Saved successfully");
                            DgvList.DataSource = BlTblAdmission.GetData();
                        }
                    }
                }
            }

        }


        int AdmissionId;

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    AdmissionId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["AdmissionId"].Value);
                    ddlStudent.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["StudentName"].Value);
                    ddlTeacher.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["TeacherName"].Value);
                    ddlCourse.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["CourseName"].Value);
                    ddlClass.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["ClassTime"].Value);
                }
                else if (e.ColumnIndex == 0)
                {
                    AdmissionId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["AdmissionId"].Value);
                    DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                    {
                        if (BlTblAdmission.Delete(AdmissionId) == 1)
                        {
                            DgvList.DataSource = BlTblAdmission.GetData();
                        }
                    }
                }


            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void FrmAddmision_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole=="User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DgvList.DataSource = BlTblAdmission.GetData();
            // Loading Recent inserted Student data to StudentDropDownList
            if (FrmStudent.check == 1)
            {
                DataTable dt = BlTblStudent.SelectRecentInsertedStudent();
                int StudentId = (int)dt.Rows[0]["StudentId"];
                dt = BlTblStudent.GetStudentFullName(StudentId);
                ddlStudent.DataSource = dt;
                ddlStudent.DisplayMember = "StudentName";
                ddlStudent.ValueMember = "StudentId";
            }
            // Loading All Student data to StudentDropDownList
            else
            {
                ddlStudent.DataSource = BlTblStudent.GetStudentFullName();
                ddlStudent.DisplayMember = "StudentName";
                ddlStudent.ValueMember = "StudentId";
            }
            ddlTeacher.DataSource = BlTblTeacher.GetTeacherFullName();
            ddlTeacher.DisplayMember = "TeacherName";
            ddlTeacher.ValueMember = "TeacherId";
            ddlCourse.DataSource = BlTblCourse.GetCourseName();
            ddlCourse.DisplayMember = "CourseName";
            ddlCourse.ValueMember = "CourseId";
            ddlClass.DataSource = BlTblClass.GetClassTime();
            ddlClass.DisplayMember = "ClassTime";
            ddlClass.ValueMember = "ClassId";
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblAdmission.Searching("Student", txtStudent.Text);
        }

        private void txtTeacher_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblAdmission.Searching("Teacher", txtTeacher.Text);
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblAdmission.Searching("Course", txtCourse.Text);
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblAdmission.Searching("Class", txtClass.Text);
        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }
    }



}






