                namespace wx4b
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.UpdateAccjsButton = new System.Windows.Forms.ToolStripButton();
            this.ReloadButton = new System.Windows.Forms.ToolStripButton();
            this.SettingButton = new System.Windows.Forms.ToolStripButton();
            this.DonateButton = new System.Windows.Forms.ToolStripButton();
            this.FeedbackButton = new System.Windows.Forms.ToolStripButton();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopToolStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(784, 561);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://wx.qq.com/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateAccjsButton,
            this.ReloadButton,
            this.SettingButton,
            this.DonateButton,
            this.FeedbackButton,
            this.AboutButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(784, 25);
            this.TopToolStrip.TabIndex = 1;
            this.TopToolStrip.TabStop = true;
            // 
            // UpdateAccjsButton
            // 
            this.UpdateAccjsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UpdateAccjsButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateAccjsButton.Image")));
            this.UpdateAccjsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateAccjsButton.Name = "UpdateAccjsButton";
            this.UpdateAccjsButton.Size = new System.Drawing.Size(60, 22);
            this.UpdateAccjsButton.Text = "更新脚本";
            this.UpdateAccjsButton.Click += new System.EventHandler(this.UpdateAccjsButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(60, 22);
            this.ReloadButton.Text = "重新加载";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(36, 22);
            this.SettingButton.Text = "设置";
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // DonateButton
            // 
            this.DonateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DonateButton.Image = ((System.Drawing.Image)(resources.GetObject("DonateButton.Image")));
            this.DonateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(60, 22);
            this.DonateButton.Text = "我要打赏";
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FeedbackButton.Image = ((System.Drawing.Image)(resources.GetObject("FeedbackButton.Image")));
            this.FeedbackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(60, 22);
            this.FeedbackButton.Text = "意见反馈";
            this.FeedbackButton.Click += new System.EventHandler(this.FeedbackButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(36, 22);
            this.AboutButton.Text = "关于";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "微信网页版（晴天优化）";
            this.notifyIcon1.BalloonTipTitle = "微信网页版（晴天优化）";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "微信网页版（晴天优化）";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleName = "上下文";
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMenuItem,
            this.ExitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 48);
            // 
            // ShowMenuItem
            // 
            this.ShowMenuItem.Name = "ShowMenuItem";
            this.ShowMenuItem.Size = new System.Drawing.Size(115, 22);
            this.ShowMenuItem.Text = "显示(&S)";
            this.ShowMenuItem.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(115, 22);
            this.ExitMenuItem.Text = "退出(&E)";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.webBrowser1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信网页版（晴天优化）";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton UpdateAccjsButton;
        private System.Windows.Forms.ToolStripButton ReloadButton;
        private System.Windows.Forms.ToolStripButton SettingButton;
        private System.Windows.Forms.ToolStripButton FeedbackButton;
        private System.Windows.Forms.ToolStripButton AboutButton;
        private System.Windows.Forms.ToolStripButton DonateButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    }
}

