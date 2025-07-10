using AcademyManagementSystem.BL;
using AcademyManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.BlStudent
{
    internal class BlTblStudent
    {
        public int StudentId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Contact { get; set;}
        public string Cnic { get; set;}
        public string Email { get; set;}
        public string Address { get; set;}
        public byte [] Image { get; set; }
      
        public bool IsDeleted { get; set;}
        public string Status { get; set;}
        public static int Save(BlTblStudent obj)
        {
            SqlParameter[] prm = new SqlParameter[11];
            if (obj.StudentId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@FirstName", obj.FirstName);
            prm[2] = new SqlParameter("@LastName", obj.LastName);
            prm[3] = new SqlParameter("@Contact", obj.Contact);
            prm[4] = new SqlParameter("@CNIC", obj.Cnic);
            prm[5] = new SqlParameter("@Email", obj.Email);
            prm[6] = new SqlParameter("@Address", obj.Address);
           
            prm[7] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[8] = new SqlParameter("@Status", obj.Status);
            prm[9] = new SqlParameter("@Image", obj.Image);
            prm[10] = new SqlParameter("@StudentId", obj.StudentId);
            return DataAccess.SpexecuteQuery("SpTblStudent", prm);
        }
        public static DataTable SelectRecentInsertedStudent()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "SelectRecentInsertedStudent");
            return DataAccess.SpGetData("SpTblStudent", prm);
        }
        public static DataTable GetData()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblStudent", prm);
        } 
        public static DataTable GetStudentFullName(int? StudentId = null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "SelectStudentName");
            prm[1] = new SqlParameter("@StudentId", StudentId);
            return DataAccess.SpGetData("SpTblStudent", prm);
        }
       
        public static int Delete(int StudentId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@StudentId", StudentId);
            return DataAccess.SpexecuteQuery("SpTblStudent", prm);
        }
       
        public static DataTable CheckDublicateEntry(string columnName,string value)
        {
            SqlParameter[] prm=new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "CheckDublicateEntry");
            prm[1] = new SqlParameter("@" + columnName, value);
            return DataAccess.SpGetData("SpTblStudent", prm);
        }
        public static DataTable CheckDublicateUpdate(string columnName,string value,int StudentId)
        {
            SqlParameter[]prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", "CheckDublicateUpdate");
            prm[1] = new SqlParameter("@" + columnName, value);
            prm[2] = new SqlParameter("@StudentId", StudentId);
            return DataAccess.SpGetData("SpTblStudent", prm);

        }
    }
}
