using AcademyManagementSystem.BL;
using AcademyManagementSystem.BlTeacher;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmSalary : Form
    {
        public FrmSalary()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtSalaryAmount.Text == "")
            {
                lblSalaryAmount.Text = "required";
            }
            else if (ddlPercentage.Text == "")
            {
                lblPercentage.Text = "required";
            }
            else
            {
                if (SalaryId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblSalary obj = new BlTblSalary();
                        obj.TeacherId = (int)ddlTeacher.SelectedValue;
                        obj.SalaryAmount = txtSalaryAmount.Text;
                        obj.Percentage = ddlPercentage.Text;
                        obj.IsDeleted = false;
                        obj.CreatedAt = dtpCreatedAt.Value.ToString("Y");
                        obj.SalaryId = SalaryId;
                        if (BlTblSalary.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblSalary");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblSalary obj = new BlTblSalary();
                        obj.TeacherId = (int)ddlTeacher.SelectedValue;
                        obj.SalaryAmount = txtSalaryAmount.Text;
                        obj.IsDeleted = false;
                        obj.Percentage = ddlPercentage.Text;
                        obj.CreatedAt = dtpCreatedAt.Value.ToString("Y");
                        if (BlTblSalary.save(obj) == 1)
                        {
                            MessageBox.Show("Saved successfully");
                            DgvList.DataSource = BlTblSalary.GetData();

                        }
                    }
                }
            }

        }

        int SalaryId;
        public static int TeacherId;
        string pName, pAmount;
        public static string FirstName, LastName, CNIC, contact, address, email;
        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 1)
                {
                    if (checkTeacher == 0)
                    {
                        SalaryId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["SalaryId"].Value);
                        ddlTeacher.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["TeacherId"].Value);
                    }
                    else
                    {
                        TeacherId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["TeacherId"].Value);
                        FirstName = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["FirstName"].Value);
                        LastName = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["LastName"].Value);
                        CNIC = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Cnic"].Value);
                        contact = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Contact"].Value);
                        address = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Address"].Value);
                        email = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Email"].Value);
                        FrmTeacher obj = new FrmTeacher();
                        this.Hide();
                        obj.ShowDialog();
                    }
                }
                else if (e.ColumnIndex == 0)
                {
                    SalaryId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["SalaryId"].Value);
                    DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                    {
                        if (BlTblSalary.Delete(SalaryId) == 1)
                        {
                            DgvList.DataSource = BlTblSalary.GetData();
                        }
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    pName = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["FirstName"].Value) + " " + Convert.ToString(DgvList.Rows[e.RowIndex].Cells["LastName"].Value);
                    pAmount = "" + DgvList.Rows[e.RowIndex].Cells["salaryAmount"].Value;
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                    // printDocument1.Print();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tarsat kelo ghol saffa ka yowar ");
            }


        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }

        private void FrmSalary_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DgvList.DataSource = BlTblSalary.GetData();
            ddlTeacher.DataSource = BlTblTeacher.GetTeacherFullName();
            ddlTeacher.DisplayMember = "TeacherName";
            ddlTeacher.ValueMember = "TeacherId";
        }



        private void ddlPercentage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int TotalFee = 0;
            DataTable dt = BlTblAdmission.GetTeacherCount((int)ddlTeacher.SelectedValue);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable dtFee = BlTblCourse.GetData((int)dt.Rows[i]["CourseId"]);
                int CourseFee = (int)dtFee.Rows[0]["CourseFee"];
                TotalFee += CourseFee;
            }
            string percentage = Convert.ToString(ddlPercentage.SelectedItem);
            int RequredPercent = 100 - Convert.ToInt32(percentage);
            int AcadmeyPercent = (RequredPercent * TotalFee) / 100;
            int NetSalary = TotalFee - AcadmeyPercent;
            txtSalaryAmount.Text = NetSalary.ToString();
        }

        private void dtpPaid_ValueChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblSalary.GetPaidTeachers(dtpPaid.Value.ToString("Y"));
        }
        public static int checkTeacher = 0;
        private void dtpUpPaid_ValueChanged(object sender, EventArgs e)
        {
            checkTeacher = 1;
            string Query = "select * from TblTeacher where ";
            DataTable dt = BlTblSalary.GetPaidTeachers(dtpUnPaid.Value.ToString("Y"));
            int Length = dt.Rows.Count;
            if (Length > 1)
            {
                int i;
                for (i = 0; i < Length - 1; i++)
                {
                    Query += "TeacherId <> " + dt.Rows[i]["TeacherId"] + " and ";
                }
                if (Length == i + 1)
                {
                    Query += "TeacherId <> " + dt.Rows[i]["TeacherId"];
                }
                SqlDataAdapter adp = new SqlDataAdapter(Query, "server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
                dt = new DataTable();
                adp.Fill(dt);
                DgvList.DataSource = dt;
            }
            else if (Length == 1)
            {
                Query += "TeacherId <> " + dt.Rows[0]["TeacherId"];
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Academy Managment System", new Font("Arial", 30, FontStyle.Bold), Brushes.Orange, new Point(140, 80));
            e.Graphics.DrawString("Name:           " + pName, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(180, 180));
            e.Graphics.DrawString("Amount:         " + pAmount, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(180, 250));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 300));
            e.Graphics.DrawString("***PAID***", new Font("Arial", 30, FontStyle.Bold), Brushes.Orange, new Point(220, 350));
        }
    }

}



