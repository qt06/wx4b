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

namespace wx4b
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MainWindow : Form
    {
        public string js;

        public MainWindow()
        {
            InitializeComponent();
            webBrowser1.ObjectForScripting = this;
            this.js = File.Exists(Application.StartupPath + "\\acc.js") ? File.ReadAllText(Application.StartupPath + "\\acc.js", Encoding.UTF8) : "";       
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string text = "alert(typeof MutationObserver);" +
            "var mcallback = function(records) {" +
            "alert(records.length);" +
            "    records.map(function(record) {" +
            "        if(record.addedNodes.length > 0){" +
            " for(i = 0; i < record.addedNodes.length; i++) {" +
            "alert(record.addedNodes[i].innerHTML);" +
            " }" +
            " } " +
            "    });" +
            "};" +
            "var mo = new MutationObserver(mcallback);" +
            "var moption = {" +
            "    'childList': true," +
            "    'subtree': true" +
            "};" +
            "mo.observe(document.body, moption);";
            HtmlElement ele = webBrowser1.Document.CreateElement("script");
            ele.InnerText = this.js;
            webBrowser1.Document.Body.AppendChild(ele);
        }
    }
}
