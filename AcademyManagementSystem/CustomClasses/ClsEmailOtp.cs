using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyManagementSystem.CustomClasses
{
    internal class ClsEmailOtp
    {
        public static int SendEmail(string To, string From, string Subject, string Body)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.To.Add(To);
                msg.From = new MailAddress(From);
                msg.Subject = Subject;
                msg.Body = Body;
                msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential(From, "qaqumdmgnysvjpna");
                smtp.EnableSsl = true;
                smtp.Send(msg);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public static string GenerateOtp()
        {
            string value = "0123456789";
            string OtpCode = "";
            int Index;
            Random obj = new Random();
            for (int i = 1; i < 5; i++)
            {
                Index = obj.Next(0, value.Length);
                OtpCode += value[Index].ToString();
            }
            return OtpCode;
        }
    }
}
