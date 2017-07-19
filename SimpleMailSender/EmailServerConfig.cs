using System;
using System.Windows.Forms;

namespace SimpleMailSender
{
    [Serializable]
    public class EmailServerConfig
    {
        public int Port; //发送邮件所用的端口号（htmp协议默认为25）
        public string HostAddress { get; set; }//发件箱的邮件服务器地址（IP形式或字符串形式均可）
        public string SenderDisplayName { get; set; }//发件箱的用户名（即@符号前面的字符串，例如：hello@163.com，用户名为：hello）
        public string ServerEmail { get; set; } //发件箱的用户名（即@符号前面的字符串，例如：hello@163.com，用户名为：hello）
        public string ServerPassword { get; set; } //发件箱的密码
        public string ServerUserName { get; set; } //发件箱的用户名（即@符号前面的字符串，例如：hello@163.com，用户名为：hello）
        public bool EnableSsl { get; set; } //是否对邮件内容进行socket层加密传输
        public bool EnablePwdAuthentication { get; set; } = true; //是否对发件人邮箱进行密码验证
        public int Timeout { get; set; } = 30000;
        public bool UseDefaultCredentials { get; set; } = false;
        public string Subject { get; set; }  
        public string Content { get; set; } 
        public string To { get; set; }
        public bool ShowDialog { get; set; } = true;
        public string Error { get; set; }
        public EmailServerConfig()
        {
            
        }
        /// <summary>
        /// 发送服务器配置
        /// </summary>
        /// <param name="hostAddress"></param>
        /// <param name="hostAccount"></param>
        /// <param name="hostPassword"></param>
        /// <param name="hostPort"></param>
        /// <param name="enableSsl"></param>
        /// <param name="senderEmail"></param>
        /// <param name="senderName"></param>
        /// <param name="subject"></param>
        /// <param name="content"></param>
        /// <param name="toList"></param>
        /// <param name="timeout"></param>
        public EmailServerConfig(
            string hostAddress, 
            string hostAccount,  
            string hostPassword, 
            int hostPort, 
            bool enableSsl, 
            string senderEmail, 
            string senderName, 
            string subject,
            string content,
            string toList,
            int timeout = 30000)
        {
            HostAddress = hostAddress;
            ServerUserName = hostAccount;
            ServerEmail = senderEmail;
            ServerPassword = hostPassword;
            Port = hostPort;
            EnableSsl = enableSsl;
            SenderDisplayName = senderName;
            Timeout = timeout;
            Subject = subject;
            Content = content;
            To = toList;
        }

        /// <summary>
        /// 设置并发送
        /// </summary>
        public bool Send()
        {
            EmailSender helper = new EmailSender(HostAddress, ServerUserName, ServerEmail, ServerPassword, Port, EnableSsl, SenderDisplayName, UseDefaultCredentials, Timeout);
            try
            {
                helper.Send(Subject, Content, To.Split(','));
                if(ShowDialog)
                MessageBox.Show(@"发送成功", @"提示");
                return true;
            }
            catch (Exception ex)
            {
                if(ShowDialog)
                    MessageBox.Show(ex.Message + ex.InnerException?.Message + ex.StackTrace);
                Error = ex.ToString();
                return false;
            }
        }

        public EmailServerConfig DeepCopy()
        {
            return MemberwiseClone() as EmailServerConfig;
        }
     }

    
}
