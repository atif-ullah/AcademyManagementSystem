using AcademyManagementSystem.BlClass;
using AcademyManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem
{
    internal class BlTblExpenseHead
    {
        public int ExpenseHeadId { get; set; }
        public string ExpenseHeadName { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
       
        public static int save(BlTblExpenseHead obj)
        {
            SqlParameter[] prm = new SqlParameter[5];
            if (obj.ExpenseHeadId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@ExpenseHeadId", obj.ExpenseHeadId);
            prm[2] = new SqlParameter("expenseHeadName", obj.ExpenseHeadName);  
            prm[3] = new SqlParameter("Status", obj.Status);
            prm[4] = new SqlParameter("IsDeleted", obj.IsDeleted);
           
            return DataAccess.SpexecuteQuery("SpTblExpenseHead", prm);
        }
        public static DataTable GetData()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblExpenseHead", prm);
        }
        public static int Delete(int ExpenseHeadId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@ExpenseHeadId", ExpenseHeadId);
            return DataAccess.SpexecuteQuery("SpTblExpenseHead", prm);
        }
       
        public static DataTable GetLatestExpenseHead()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "GetLatestExpenseHead");
            return DataAccess.SpGetData("SpTblExpenseHead", prm);
        }

    }
}
