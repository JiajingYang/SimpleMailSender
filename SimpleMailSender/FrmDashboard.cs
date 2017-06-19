using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleMailSender
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            Load();
        }
        public EmailServerConfig config = null;

        public void ReadToConfig()
        {
            config = new EmailServerConfig(
                tbServer.Text.Trim(),
                tbAccount.Text.Trim(),
                tbPassw0rd.Text.Trim(),
                Convert.ToInt32(tbPort.Text.ToString()),
                cbSsl.Checked,
                tbEmailAddress.Text.Trim(),
                tbDisplayName.Text.Trim(),
                tbSubject.Text,
                tbContent.Text,
                tbTo.Text);
        }
        public void Send()
        {
            ReadToConfig();
            config.SetConfigAndSend();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void FrmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"保存信息", @"确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Save();
            }
        }


        public void Load()
        {
            //LoadTemp 
            ReadToConfig();
            var configPath = AppDomain.CurrentDomain.BaseDirectory + @"/Config/";
            if (!Directory.Exists(configPath))
            {
                Directory.CreateDirectory(configPath);
            }
            if (File.Exists(configPath + @"/Temp.xml"))
            {
                var str = File.ReadAllText(configPath + @"/Temp.xml");
                config = str.XmlDeSerialize<EmailServerConfig>();
                SetToUi();
            }
        }

        private void SetToUi()
        {
            tbServer.Text = config.HostAddress;
            tbAccount.Text = config.ServerEmail;
            tbPassw0rd.Text = config.ServerPassword;
            tbPort.Text = config.Port.ToString();
            cbSsl.Checked = config.EnableSsl;
            tbEmailAddress.Text = config.ServerEmail;
            tbDisplayName.Text = config.SenderDisplayName;
            tbSubject.Text = config.Subject;
            tbContent.Text = config.Content;
            tbTo.Text = config.To;
        }

        public void Save()
        {
            ReadToConfig();
            var xml = config.XmlSerialize();
            var configPath = AppDomain.CurrentDomain.BaseDirectory + @"/Config/";
            if (!Directory.Exists(configPath))
            {
                Directory.CreateDirectory(configPath);
            }
            File.WriteAllText(configPath + @"/Temp.xml", xml);
        }

        private void 加载配置_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            var result = open.ShowDialog();
            if (string.IsNullOrEmpty(open.FileName))
            {
                return;
            }
            else
            {
                var str = File.ReadAllText(open.FileName);
                config = str.XmlDeSerialize<EmailServerConfig>();
                SetToUi();
            }

        }
    }
}
