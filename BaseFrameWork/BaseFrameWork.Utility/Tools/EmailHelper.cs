using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrameWork.Utility.Tools
{
   public class EmailHelper
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="subject">邮件标题</param>
        /// <param name="body">邮件正文</param>
        /// <param name="to">收件人</param>
        /// <param name="Ishtml">是否为html格式</param>
        public static bool sendmail(string subject, string body, string to, bool Ishtml)
        {
            using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
            {
                msg.To.Add(to);
                msg.From = new System.Net.Mail.MailAddress("邮箱地址", "标题", System.Text.Encoding.UTF8);
                msg.Subject = subject;//邮件标题             
                msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码 
                msg.Body = body;//邮件内容 
                msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码 
                msg.IsBodyHtml = Ishtml;//是否是HTML邮件 
                msg.Priority = System.Net.Mail.MailPriority.High;//邮件优先级
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("邮箱地址", "密码");
                client.Host = "域名";
                object userState = msg;
                try
                {
                    client.Send(msg);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
