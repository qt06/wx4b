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
using wx4b.Properties;
namespace wx4b
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MainWindow : Form
    {
        public string accjs { get; set; }
        private string updateUrl = "https://raw.githubusercontent.com/qt06/wx4b/master/wx4b/acc.js";
        private string feedbackUrl = "http://apk.qt06.com/thread-index-fid-3-tid-5353-page-1.htm";
        private string donateUrl = "http://www.qt.hk/donation/";

        #region 窗体初始化、关闭等相关操作
                public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            this.RegisterHotkey();
            this.setWebBrowserObjectForScripting();
            this.LoadAccjs();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Settings.Default.CloseType == "Hide")
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.UnregisterHotkey();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 12345:
                            if (this.Visible)
                            {
                                this.Hide();
                            }
                            else
                            {
                                this.Show();
                            }
                            break;
                        case 101:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                HtmlElement he = webBrowser1.Document.GetElementById("iamwx");
                if (he == null)
                {
                                                HtmlElement ele = webBrowser1.Document.CreateElement("script");
            ele.Id = "iamwx";
                        ele.InnerHtml = this.accjs;
            webBrowser1.Document.Body.AppendChild(ele);
                    }
            }
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
        #region 工具栏按钮事件
        private void UpdateAccjsButton_Click(object sender, EventArgs e)
        {
            string s = Request.get(this.updateUrl, "utf-8");
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("更新失败，可能是服务器不可用。请稍后在尝试一下吧。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (File.Exists(Application.StartupPath + "\\acc.js")) File.Move(Application.StartupPath + "\\acc.js", Application.StartupPath + "\\acc-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".js");
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
            System.Diagnostics.Process.Start("iexplore.exe", this.donateUrl);
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", this.feedbackUrl);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingWindow sw = new SettingWindow(this);
            sw.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("微信网页版（晴天优化）， 版本：" + Application.ProductVersion, "关于", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region 通知区域相关事件
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
                    }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region hotkey register
        public void RegisterHotkey()
        {
            string[] sa = Settings.Default.Hotkey.Split(new char[] { '+' });
            if (sa.Length >= 2)
            {
                string[] ms = sa[0].Trim().Split(new Char[] { ',' });
                HotKey.KeyModifiers km = HotKey.KeyModifiers.None;
                for (int i = 0; i < ms.Length; i++)
                {
                    if (!string.IsNullOrEmpty(ms[i].Trim()))
                    {
                        try
                        {
                            HotKey.KeyModifiers k = (HotKey.KeyModifiers)Enum.Parse(typeof(HotKey.KeyModifiers), ms[i].Trim());
                            km = km | k;
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                    }
                }
                try
                {
                    Keys vk = (Keys)Enum.Parse(typeof(Keys), sa[1].Trim());
                    HotKey.RegisterHotKey(this.Handle, 12345, km, vk);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public void UnregisterHotkey()
        {
            HotKey.UnregisterHotKey(this.Handle, 12345);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.Focus();
            }
        }
        #endregion

        //end MainWindow
    }
}
