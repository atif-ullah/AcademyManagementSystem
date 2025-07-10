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
    internal class BlTblCourse
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDuration { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public int CourseFee { get; set; }

        public static int save(BlTblCourse obj)
        {
            SqlParameter[] prm = new SqlParameter[7];
            if (obj.CourseId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@CourseId", obj.CourseId);
            prm[2] = new SqlParameter("CourseName", obj.CourseName);
            prm[3] = new SqlParameter("CourseDuration", obj.CourseDuration);
            prm[4] = new SqlParameter("Status", obj.Status);
            prm[5] = new SqlParameter("IsDeleted", obj.IsDeleted);
            prm[6] = new SqlParameter("CourseFee", obj.CourseFee);

            return DataAccess.SpexecuteQuery("SpTblCourse", prm);
        }
        public static DataTable GetData(int? CourseId=null)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Select");
            prm[1] = new SqlParameter("@CourseId", CourseId);
            return DataAccess.SpGetData("SpTblCourse", prm);
        }
        public static DataTable GetCourseName()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "SelectCourseName");
            return DataAccess.SpGetData("SpTblCourse", prm);
        }
        public static int Delete(int CourseId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@CourseId", CourseId);
            return DataAccess.SpexecuteQuery("SpTblCourse", prm);
        }
       public static DataTable getData()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblCourse", prm);
        }
        public static DataTable Search(string ColumnName, string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Search");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpTblCourse", prm);
        }
    }
}
  