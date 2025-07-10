using AcademyManagementSystem.DAL;
using System.Data;
using System.Data.SqlClient;

namespace AcademyManagementSystem.BL
{
    internal class BlTblUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string CNIC { get; set; }
        public string Contact { get; set; }
        public string OTP { get; set; }
        public string UserName { get; set; }
        public byte[] Image { get; set; }
        public bool IsDeleted { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }

        public static int Save(BlTblUser obj)
        {
            SqlParameter[] prm = new SqlParameter[15];
            if (obj.UserId > 0)
            {
                prm[0] = new SqlParameter("@Type", "Update");
            }
            else
            {
                prm[0] = new SqlParameter("@Type", "Insert");
            }
            prm[1] = new SqlParameter("@FirstName", obj.FirstName);
            prm[2] = new SqlParameter("@LastName", obj.LastName);
            prm[3] = new SqlParameter("@UserName", obj.UserName);
            prm[4] = new SqlParameter("@Email", obj.Email);
            prm[5] = new SqlParameter("@Password", obj.Password);
            prm[6] = new SqlParameter("@CNIC", obj.CNIC);
            prm[7] = new SqlParameter("@Address", obj.Address);
            prm[8] = new SqlParameter("@Contact", obj.Contact);
            prm[9] = new SqlParameter("@Gender", obj.Gender);
            prm[10] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[11] = new SqlParameter("@Status", obj.Status);
            prm[12] = new SqlParameter("@Role", obj.Role);
            prm[13] = new SqlParameter("@Image", obj.Image);
            prm[14] = new SqlParameter("@UserId", obj.UserId);
            return DataAccess.SpexecuteQuery("SpTblUser", prm);
        }
        public static DataTable Search(string ColumnName, string value)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Searching");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static int Delete(int UserId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Delete");
            prm[1] = new SqlParameter("@UserId", UserId);
            return DataAccess.SpexecuteQuery("SpTblUser", prm);
        }
        public static int UpdatePassword(string value, string password)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Type", "UpdatePassword");
            prm[1] = new SqlParameter("@Email", value);
            prm[2] = new SqlParameter("@Contact", value);
            prm[3] = new SqlParameter("@Password", password);
            return DataAccess.SpexecuteQuery("SpTblUser", prm);
        }
        public static int UpdateOTP(string Email, string OTP)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", "UpdateOTP");
            prm[1] = new SqlParameter("@Email", Email);
            prm[2] = new SqlParameter("@OTP", OTP);
            return DataAccess.SpexecuteQuery("SpTblUser", prm);
        }
        public static DataTable GetData()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", "Select");
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckEmail(string Email)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "CheckEmail");
            prm[1] = new SqlParameter("@Email", Email);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckOTP(string Email, string OTP)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "CheckOTP");
            prm[1] = new SqlParameter("@Email", Email);
            prm[1] = new SqlParameter("@OTP", OTP);
            return DataAccess.SpGetData("SpTblUser", prm);
        }

        public static DataTable Login(string value, string Password)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Type", "CheckForLoginWithPassword");
            prm[1] = new SqlParameter("@UserName", value);
            prm[2] = new SqlParameter("@Contact", value);
            prm[3] = new SqlParameter("@Email", value);
            prm[4] = new SqlParameter("@Password", Password);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable Login(string value)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Type", "CheckForLogin");
            prm[1] = new SqlParameter("@UserName", value);
            prm[2] = new SqlParameter("@Contact", value);
            prm[3] = new SqlParameter("@Email", value);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckForChangePassword(string value, string Password)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Type", "CheckForChangePasswordWithPassword");
            prm[1] = new SqlParameter("@Email", value);
            prm[2] = new SqlParameter("@Contact", value);
            prm[3] = new SqlParameter("@Password", Password);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckForChangePassword(string value)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", "CheckForChangePassword");
            prm[1] = new SqlParameter("@Contact", value);
            prm[2] = new SqlParameter("@Email", value);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckUserName(string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "Select");
            prm[0] = new SqlParameter("@Username", value);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckDuplicateUser(string ColumnName, string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", "CheckDuplicateUser");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpTblUser", prm);
        }
        public static DataTable CheckDublicateUpdate(string ColumnName, string value, int UserId)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", "CheckDublicateUpdate");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            prm[2] = new SqlParameter("@UserId", UserId);
            return DataAccess.SpGetData("SpTblUser", prm);
        }

    }

}
