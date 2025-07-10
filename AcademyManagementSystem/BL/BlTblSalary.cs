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
    internal class BlTblSalary
    {
        public int SalaryId { get; set; }
        public int TeacherId { get; set; }
        public string SalaryAmount { get; set; }
        public string Percentage { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedAt { get; set; }

        public static int save(BlTblSalary obj)
        {
            SqlParameter[] prm = new SqlParameter[7];
            if (obj.SalaryId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@SalaryId", obj.SalaryId);
            prm[2] = new SqlParameter("TeacherId", obj.TeacherId);
            prm[3] = new SqlParameter("SalaryAmount", obj.SalaryAmount);
            prm[4] = new SqlParameter("IsDeleted", obj.IsDeleted);
            prm[5] = new SqlParameter("Percentage", obj.Percentage);
            prm[6] = new SqlParameter("CreatedAt", obj.CreatedAt);
            return DataAccess.SpexecuteQuery("SpTblSalary", prm);
        }
        public static DataTable GetData()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblSalary", prm);
        }
        public static DataTable Search(string ColumnName, string value)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Search");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpTblSalary", prm);
        }
        public static DataTable GetPaidTeachers(string date)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "GetPaidTeachers");
            prm[1] = new SqlParameter("@CreatedAt", date);
            return DataAccess.SpGetData("SpTblSalary", prm);
        }
        public static int Delete(int SalaryId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@SalaryId", SalaryId);
            return DataAccess.SpexecuteQuery("SpTblSalary", prm);
        }
    }
}
    
  
