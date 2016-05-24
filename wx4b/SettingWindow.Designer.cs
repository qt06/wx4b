namespace wx4b
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HotkeyField = new exscape.HotkeyControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HideRadioButton = new System.Windows.Forms.RadioButton();
            this.ExitRadioButton = new System.Windows.Forms.RadioButton();
            this.OKBTN = new System.Windows.Forms.Button();
            this.CCBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HotkeyField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快捷键";
            // 
            // HotkeyField
            // 
            this.HotkeyField.Hotkey = System.Windows.Forms.Keys.None;
            this.HotkeyField.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.HotkeyField.Location = new System.Drawing.Point(11, 25);
            this.HotkeyField.Name = "HotkeyField";
            this.HotkeyField.Size = new System.Drawing.Size(500, 21);
            this.HotkeyField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用于显示或隐藏主窗口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HideRadioButton);
            this.groupBox2.Controls.Add(this.ExitRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "关闭窗口时";
            // 
            // HideRadioButton
            // 
            this.HideRadioButton.AutoSize = true;
            this.HideRadioButton.Location = new System.Drawing.Point(80, 17);
            this.HideRadioButton.Name = "HideRadioButton";
            this.HideRadioButton.Size = new System.Drawing.Size(107, 16);
            this.HideRadioButton.TabIndex = 2;
            this.HideRadioButton.Text = "隐藏到通知区域";
            this.HideRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExitRadioButton
            // 
            this.ExitRadioButton.AutoSize = true;
            this.ExitRadioButton.Checked = true;
            this.ExitRadioButton.Location = new System.Drawing.Point(3, 17);
            this.ExitRadioButton.Name = "ExitRadioButton";
            this.ExitRadioButton.Size = new System.Drawing.Size(71, 16);
            this.ExitRadioButton.TabIndex = 1;
            this.ExitRadioButton.TabStop = true;
            this.ExitRadioButton.Text = "直接退出";
            this.ExitRadioButton.UseVisualStyleBackColor = true;
            // 
            // OKBTN
            // 
            this.OKBTN.Location = new System.Drawing.Point(10, 220);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(75, 23);
            this.OKBTN.TabIndex = 2;
            this.OKBTN.Text = "保存(&S)";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // CCBTN
            // 
            this.CCBTN.Location = new System.Drawing.Point(600, 220);
            this.CCBTN.Name = "CCBTN";
            this.CCBTN.Size = new System.Drawing.Size(75, 23);
            this.CCBTN.TabIndex = 3;
            this.CCBTN.Text = "取消(&C)";
            this.CCBTN.UseVisualStyleBackColor = true;
            this.CCBTN.Click += new System.EventHandler(this.CCBTN_Click);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CCBTN);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置 - 微信网页版";
            this.Shown += new System.EventHandler(this.SettingWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private exscape.HotkeyControl HotkeyField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton HideRadioButton;
        private System.Windows.Forms.RadioButton ExitRadioButton;
        private System.Windows.Forms.Button OKBTN;
        private System.Windows.Forms.Button CCBTN;
    }
}