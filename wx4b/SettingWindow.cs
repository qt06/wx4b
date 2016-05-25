using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wx4b.Properties;
    namespace wx4b
{
    public partial class SettingWindow : Form
    {
        private string CloseType { get; set; }
        private string Hotkey { get; set; }
        private MainWindow mw;
        public SettingWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void SettingWindow_Shown(object sender, EventArgs e)
        {
            this.mw.UnregisterHotkey();
                        this.CloseType = Settings.Default.CloseType;
            this.Hotkey = Settings.Default.Hotkey;
            if (this.CloseType == "Exit")
            {
                this.ExitRadioButton.Checked = true;
            }
            else
            {
                this.HideRadioButton.Checked = true;
            }
            this.HotkeyField.Text = this.Hotkey;

            string[] sa = this.Hotkey.Split(new char[] { '+' });
            if (sa.Length >= 2)
            {
                try
                {
                                this.HotkeyField.HotkeyModifiers = (Keys)Enum.Parse(typeof(Keys), sa[0].Trim());
                this.HotkeyField.Hotkey = (Keys)Enum.Parse(typeof(Keys), sa[1].Trim());
                }
                catch (Exception)
                {
                    //此处错误则热键域默认为空即可
                    //throw;
                }

            }
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            if (this.ExitRadioButton.Checked)
            {
                this.CloseType = "Exit";
            }
            else
            {
                this.CloseType = "Hide";
            }
            Settings.Default.CloseType = this.CloseType;
            Settings.Default.Hotkey = this.HotkeyField.Text;
            Settings.Default.Save();
            this.mw.RegisterHotkey();
            this.Close();
        }

        private void CCBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
