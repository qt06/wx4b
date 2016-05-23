using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using QTCSharpTool;
namespace wx4b
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MainWindow : Form
    {
        public string accjs { get; set; }
        private string updateUrl = "https://raw.githubusercontent.com/qt06/wx4b/master/wx4b/acc.js";

        public MainWindow()
        {
            InitializeComponent();
            this.setWebBrowserObjectForScripting();
            this.LoadAccjs();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement ele = webBrowser1.Document.CreateElement("script");
            ele.InnerText = this.accjs;
            webBrowser1.Document.Body.AppendChild(ele);
        }

        private void setWebBrowserObjectForScripting()
        {
            webBrowser1.ObjectForScripting = this;
        }
        private void LoadAccjs()
        {
            this.accjs = File.Exists(Application.StartupPath + "\\acc.js") ? File.ReadAllText(Application.StartupPath + "\\acc.js", Encoding.UTF8) : "";
        }
        private void reload()
        {
            webBrowser1.Navigate("https://wx.qq.com/");
        }

        private void UpdateAccjsButton_Click(object sender, EventArgs e)
        {
            string s = Request.get(this.updateUrl, "utf-8");
            if(string.IsNullOrEmpty(s))
            {
                MessageBox.Show("更新失败，可能是服务器不可用。请稍后在尝试一下吧。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
           if(File.Exists(Application.StartupPath + "\\acc.js")) File.Move(Application.StartupPath + "\\acc.js", Application.StartupPath + "\\acc-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".js");
            File.WriteAllText(Application.StartupPath + "\\acc.js", s, Encoding.UTF8);
            MessageBox.Show("更新完成，点击确定开始享用新的微信之旅吧。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.reload();
            }
            catch (Exception)
            {
                MessageBox.Show("更新失败，可能是当前目录没有权限。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.reload();
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.qt.hk/donation/");
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://apk.qt06.com/thread-index-fid-3-tid-5353-page-1.htm");
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("微信网页版（晴天优化）， 版本：" + Application.ProductVersion, "关于", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingWindow sw = new SettingWindow();
            sw.Show();
        }   
    }
}
