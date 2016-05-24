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

        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Shown(object sender, EventArgs e)
        {
            this.CloseType = Settings.Default.CloseType;
            this.Hotkey = Settings.Default.Hotkey;
            this.HotkeyField.Text = this.Hotkey;
            if (this.CloseType == "Exit")
            {
                this.ExitRadioButton.Checked = true;
            }
            else
            {
                this.HideRadioButton.Checked = true;
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
            this.Close();
        }

        private void CCBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
