using SimpleMailSender.EmailExtension;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMailSender
{
    public partial class FrmBatchSend : Form
    {
        public FrmBatchSend(EmailServerConfig config)
        {
            InitializeComponent();
            this._config = config;
        }

        private EmailServerConfig _config = null;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            var result = open.ShowDialog();
            if (!string.IsNullOrEmpty(open.FileName))
            {
                var filePath = open.FileName;
                var dt = ExcelManager.ReadExcelToDataTable(filePath);
                if (dt != null)
                {
                    var hasError = false;
                    if (!dt.Columns.Contains("Subject"))
                    {
                        MessageBox.Show(@"缺少Subject列");
                        hasError = true;
                    }
                    if (!dt.Columns.Contains("Content"))
                    {
                        MessageBox.Show(@"缺少Content列");
                        hasError = true;
                    }
                    if (!dt.Columns.Contains("ToAddress"))
                    {
                        MessageBox.Show(@"缺少ToAddress列");
                        hasError = true;
                    }
                    if (hasError)
                    {
                        return;
                    }
                }
                dt.Columns.Add("IsSent");
                dt.Columns.Add("SentTime");
                dt.Columns.Add("Error");
                dataGridView1.DataSource = dt;
            }
        }

        /// <summary>
        /// 遍历发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var dt = (DataTable)dataGridView1.DataSource;
            var saveFile = string.Format(AppDomain.CurrentDomain.BaseDirectory + "\\Log_{0}.xls" , DateTime.Now.Ticks.ToString());
            _config.ShowDialog = false;
            try
            {
                //Subject, Content,ToAddress
                foreach (DataRow row in dt.Rows)
                {
                    var subject = row["Subject"];
                    var content = row["Content"];
                    var toAddress = row["ToAddress"];
                    
                    _config.Subject = subject.ToString();
                    _config.Content = content.ToString();
                    _config.To = toAddress.ToString();
                    if (string.IsNullOrWhiteSpace(_config.Subject) || string.IsNullOrWhiteSpace(_config.Content) || string.IsNullOrWhiteSpace(_config.To))
                    {
                        continue;
                    }
                    row["IsSent"] = _config.Send(); ;
                    row["SentTime"] = DateTime.Now;
                    row["Error"] = _config.Error;
                    dataGridView1.Refresh();
                    Thread.Sleep(100);
                }
                ExcelManager.SaveToExcel(saveFile, dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"发生异常，发送日志已保存至:" + saveFile);
                ExcelManager.SaveToExcel(saveFile, dt);
            }
           
        }
    }
}
