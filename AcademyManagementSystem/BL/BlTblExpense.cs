using AcademyManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.BL
{
    internal class BlTblExpense
    {
        public int ExpenseId { get; set; }
        public int ExpenseHeadId { get; set; }
        public string Expense { get; set; }
        public string Amount { get; set; }
        public bool IsDeleted { get; set; }

        public static int save(BlTblExpense obj)
        {
            SqlParameter[] prm = new SqlParameter[6];
            if (obj.ExpenseId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@ExpenseId", obj.ExpenseId);
            prm[2] = new SqlParameter("expenseHeadId", obj.ExpenseHeadId);
            prm[3] = new SqlParameter("Expense", obj.Expense);
            prm[4] = new SqlParameter("Amount", obj.Amount);
            prm[5] = new SqlParameter("IsDeleted", obj.IsDeleted);

            return DataAccess.SpexecuteQuery("SpTblExpense", prm);
        }
        public static DataTable GetData()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblExpense", prm);
        }
        public static int Delete(int ExpenseId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@ExpenseId", ExpenseId);
            return DataAccess.SpexecuteQuery("SpTblExpense", prm);
        }
    }
}
