using AcademyManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.BlClass
{
    internal class BlTblClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassTime { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
      
        public static int save(BlTblClass obj)
        {
            SqlParameter[] prm = new SqlParameter[6];
            if (obj.ClassId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
;            prm[1] = new SqlParameter("@ClassId", obj.ClassId);
            prm[2] = new SqlParameter("ClassName", obj.ClassName);
            prm[3] = new SqlParameter("ClassTime", obj.ClassTime);
            prm[4] = new SqlParameter("Status", obj.Status);
            prm[5] = new SqlParameter("IsDeleted", obj.IsDeleted);
           
            return DataAccess.SpexecuteQuery("SpTblClass", prm);
        }
        public static DataTable GetData()
        {

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblClass", prm);
        }
        public static DataTable GetClassTime()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "SelectClassTime");
            return DataAccess.SpGetData("SpTblClass", prm);
        }

        public static DataTable DuplicateClassTime(String ClassTime)
        {

            
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@Type", "DuplicateClassTime");
                prm[1] = new SqlParameter("@ClassTime", ClassTime);
                return DataAccess.SpGetData("SpTblClass", prm);
            
        }
        public static int Delete(int ClassId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@ClassId", ClassId);
            return DataAccess.SpexecuteQuery("SpTblClass", prm);
        }
        public static DataTable getData()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblClass", prm);
        }

    }
}
