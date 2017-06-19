# SimpleMailSender
a mail sender for test, debug.
## 为什么有本程序? Why have this repo?
本程序能用debug方式来调试出错的原因，以及放在不同环境下，可以测试连通性。<br>
If you wanna to know, why my mail settings are all right but the email allways send failed.<br>
Once have this, no more confuse, no more anxious.


可以保存当前配置，或者另加载配置 <br>Host settings can save, and load.

## 主要代码 Key Code:<br>     
```C#
SmtpClient client = new SmtpClient(HostAddress, Port)
{
    EnableSsl = EnableSsl,
    Credentials = new System.Net.NetworkCredential(ServerUserName, ServerPassword)
};
var message = new MailMessage { From = new MailAddress(ServerEmail, SenderDisplayName) };
foreach (var addr in toUserAddresss)
{
    message.To.Add(new MailAddress(addr));
}
// Attachment.Foreach(r => message.Attachments.Add(r));
if (attachments != null)
{
    foreach (var s in attachments)
    {
        Attachment data = new Attachment(s, MediaTypeNames.Application.Octet);
        data.Name = s.Substring(s.LastIndexOf("/", StringComparison.Ordinal) + 1);
        data.NameEncoding = Encoding.UTF8;
        // Add time stamp information for the file.
        ContentDisposition disposition = data.ContentDisposition;
        disposition.CreationDate = File.GetCreationTime(s);
        disposition.ModificationDate = File.GetLastWriteTime(s);
        disposition.ReadDate = File.GetLastAccessTime(s);
        // Add the file attachment to this e-mail message.
        message.Attachments.Add(data);
    }
}
//Set CC list
if (cc != null)
{
    foreach (var s in cc)
    {
        message.CC.Add(s);
    }
}
//Set Bcc List
if (bcc != null)
{
    foreach (var s in bcc)
    {
        message.Bcc.Add(s);
    }
}
ServicePointManager.ServerCertificateValidationCallback = delegate (Object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
message.Subject = subject;
message.Body = mailBody;
message.BodyEncoding = BodyEncoding;
message.IsBodyHtml = IsHtmlBody;
client.Timeout = Timeout;
client.Send(message);
```
   
   
   
 
