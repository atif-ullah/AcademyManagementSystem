using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmExpenseHead : Form
    {
        public FrmExpenseHead()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtExpenseHeadName.Text == "")
            {
                lblExpenseheadName.Text = "required";
            }
            else
            {


                if (ExpenseHeadId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblExpenseHead obj = new BlTblExpenseHead();
                        obj.ExpenseHeadName = txtExpenseHeadName.Text;
                        obj.Status = ddlStatus.Text;

                        obj.IsDeleted = false;

                        obj.ExpenseHeadId = ExpenseHeadId;
                        if (BlTblExpenseHead.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblExpenseHead");
                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblExpenseHead obj = new BlTblExpenseHead();
                        obj.ExpenseHeadName = txtExpenseHeadName.Text;
                        obj.Status = ddlStatus.Text;
                        obj.IsDeleted = false;
                        if (BlTblExpenseHead.save(obj) == 1)
                        {
                            //MessageBox.Show("Inserted");
                            //DgvList.DataSource = DataAccess.SpGetData("Select * from TblExpenseHead");
                            FrmExpense expense = new FrmExpense();
                            this.Hide();
                            expense.ShowDialog();
                        }
                    }
                }
            }

        }

        int ExpenseHeadId;
        private void DgvList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                ExpenseHeadId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ExpenseHeadId"].Value);
                txtExpenseHeadName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["ExpenseHeadName"].Value);
            }
            else if (e.ColumnIndex == 0)
            {
                ExpenseHeadId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ExpenseHeadId"].Value);
                DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblExpenseHead.Delete(ExpenseHeadId) == 1)
                    {
                        DgvList.DataSource = BlTblExpenseHead.GetData();
                    }
                }
            }
        }

        private void FrmExpenseHead_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DgvList.DataSource = BlTblExpenseHead.GetData();
        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
        }
    }
}

