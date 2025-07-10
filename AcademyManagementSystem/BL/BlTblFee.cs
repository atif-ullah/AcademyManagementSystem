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
    internal class BlTblFee
    {
        public int FeeId { get; set; }
        public int StudentId { get; set; }
        public string FeeAmount { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedAt { get; set; }
        public static int save(BlTblFee obj)
        {
            SqlParameter[] prm = new SqlParameter[6];
            if (obj.FeeId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@FeeId", obj.FeeId);
            prm[2] = new SqlParameter("StudentId", obj.StudentId);
            prm[3] = new SqlParameter("FeeAmount", obj.FeeAmount);
            prm[4] = new SqlParameter("IsDeleted", obj.IsDeleted);
            prm[5] = new SqlParameter("CreatedAt", obj.CreatedAt);
            return DataAccess.SpexecuteQuery("SpTblFee", prm);
        }
        public static DataTable GetData()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblFee", prm);
        }
        public static DataTable Search(string ColumnName,string value)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Search");
            prm[1] = new SqlParameter("@"+ColumnName, value);
            return DataAccess.SpGetData("SpTblFee", prm);
        } 
        public static DataTable GetPaidStudents(string date)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "GetPaidStudents");
            prm[1] = new SqlParameter("@CreatedAt", date);
            return DataAccess.SpGetData("SpTblFee", prm);
        } 
       

        public static int Delete(int FeeId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@FeeId", FeeId);
            return DataAccess.SpexecuteQuery("SpTblFee", prm);
        }
    }
}
    
