using AcademyManagementSystem;
using AcademyManagementSystem.BlStudent;
using AcademyManagementSystem.BlTeacher;
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void PnlUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmUserRegistration user = new FrmUserRegistration();
                this.Hide();
                user.ShowDialog();
            }
        }

        private void PnlStudents_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmStudent student = new FrmStudent();
                this.Hide();
                student.ShowDialog();
            }
        }

        private void PnlTeachers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmTeacher teacher = new FrmTeacher();
                this.Hide();
                teacher.ShowDialog();
            }
        }

        private void PnlCourses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmCourse course = new FrmCourse();
                this.Hide();
                course.ShowDialog();
            }
        }

        private void PnlClasses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmClass classes = new FrmClass();
                this.Hide();
                classes.ShowDialog();
            }
        }

        private void PnlFee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmFee fee = new FrmFee();
                this.Hide();
                fee.ShowDialog();
            }
        }

        private void PnlSalary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmLogin.UserRole))
            {
                if (MessageBox.Show("Not Authenticated! Login First.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmLogin login = new FrmLogin();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                FrmSalary salary = new FrmSalary();
                this.Hide();
                salary.ShowDialog();
            }
        }

        private void PnlLogout_Click(object sender, EventArgs e)
        {
            FrmLogin.UserRole = "";
            FrmLogin.UserId = 0;
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void PnlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlClose_MouseEnter(object sender, EventArgs e)
        {
            PnlClose.BackColor = Color.Gray;
        }

        private void PnlClose_MouseLeave(object sender, EventArgs e)
        {
            PnlClose.BackColor = Color.White;
        }

        private void PnlLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            var dtStudents = BlTblStudent.GetData();
            var dtTeachers = BlTblTeacher.GetData();
            var dtCourses = BlTblCourse.GetData();
            var studentCount = dtStudents.Rows.Count;
            var teacherCount = dtTeachers.Rows.Count;
            var coursesCount = dtCourses.Rows.Count;
            txtStudentCount.Text = "" + studentCount;
            txtTeacherCount.Text = "" + teacherCount;
            txtCoursesCount.Text = "" + coursesCount;
        }
    }

}
