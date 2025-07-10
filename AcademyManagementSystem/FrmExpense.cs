using AcademyManagementSystem.BL;
using AcademyManagementSystem.DAL;
using GymManagementSystem;
using System;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();

        }

        private void FrmExpense_Load(object sender, EventArgs e)
        {
            if (FrmLogin.UserRole == "User")
            {
                DgvList.Columns[0].Visible = false;
                DgvList.Columns[1].Visible = false;
            }
            DgvList.DataSource = BlTblExpense.GetData();
            ddlExpenseHead.DataSource = BlTblExpenseHead.GetData();
            ddlExpenseHead.DisplayMember = "ExpenseHeadName";
            ddlExpenseHead.ValueMember = "ExpenseHeadId";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtExpense.Text == "")
            {
                lblExpenseheadName.Text = "required";
            }
            else
            {


                if (ExpenseId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblExpense obj = new BlTblExpense();
                        obj.Expense = txtExpense.Text;
                        obj.Amount = txtAmount.Text;

                        obj.IsDeleted = false;

                        obj.ExpenseId = ExpenseId;
                        if (BlTblExpense.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblExpense");
                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblExpense obj = new BlTblExpense();
                        obj.ExpenseHeadId = (int)ddlExpenseHead.SelectedValue;
                        obj.Expense = txtExpense.Text;
                        obj.Amount = txtAmount.Text;
                        obj.IsDeleted = false;
                        if (BlTblExpense.save(obj) == 1)
                        {
                            MessageBox.Show("Inserted");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblExpense");
                            obj.ExpenseId = 0;
                            txtExpense.Text = null;
                            txtAmount.Text = "";
                        }
                    }
                }
            }

        }

        int ExpenseId;

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    ExpenseId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ExpenseId"].Value);
                    txtExpense.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["Expense"].Value);
                }
                else if (e.ColumnIndex == 0)
                {
                    ExpenseId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ExpenseId"].Value);
                    DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                    {
                        if (BlTblExpense.Delete(ExpenseId) == 1)
                        {
                            DgvList.DataSource = BlTblExpense.GetData();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Koty da bacha error ha!");
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




