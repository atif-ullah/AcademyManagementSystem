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
    internal class BlTblAdmission
    {
        public int AdmissionId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int ClassId { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }

        public static int save(BlTblAdmission obj)
        {
            SqlParameter[] prm = new SqlParameter[8];
            if (obj.AdmissionId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@AdmissionId", obj.AdmissionId);
            prm[2] = new SqlParameter("StudentId", obj.StudentId);
            prm[3] = new SqlParameter("TeacherId", obj.TeacherId);
            prm[4] = new SqlParameter("CourseId", obj.CourseId);
            prm[5] = new SqlParameter("ClassId", obj.ClassId);
            prm[6] = new SqlParameter("Status", obj.Status);
            prm[7] = new SqlParameter("IsDeleted", obj.IsDeleted);

            return DataAccess.SpexecuteQuery("SpTblAdmission", prm);
        }
        public static DataTable GetData()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblAdmission", prm);
        }
      
        public static DataTable GetStudentCourses(int StudentId)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "GetStudentCourses");
            prm[1] = new SqlParameter("@StudentId", StudentId);
            return DataAccess.SpGetData("SpTblAdmission", prm);
        } 
        public static DataTable GetTeacherCount(int TeacherId)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "GetTeacherCount");
            prm[1] = new SqlParameter("@TeacherId", TeacherId);
            return DataAccess.SpGetData("SpTblAdmission", prm);
        } 
        public static DataTable CheckDuplicateClassTime(int StudentId,int ClassId)
        {

            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", "CheckDuplicateClassTime");
            prm[1] = new SqlParameter("@StudentId", StudentId);
            prm[2] = new SqlParameter("@ClassId", ClassId);
            return DataAccess.SpGetData("SpTblAdmission", prm);
        }
       
        public static DataTable Searching(string ColumnName, string value)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Searching");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpTblAdmission", prm);
        }

        public static int Delete(int AdmissionId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@AdmissionId",AdmissionId);
            return DataAccess.SpexecuteQuery("SpTblAdmission", prm);
        }
    }
}
    
  
