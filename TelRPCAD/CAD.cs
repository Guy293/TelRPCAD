using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace TelRPCAD
{
    public partial class CAD : Form
    {
        public CAD()
        {
            InitializeComponent();
        }

        private void CAD_Load(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome;
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
            chrome = new ChromiumWebBrowser("http://134.119.181.113:6969/dJSIIJSDIJJidjsa88i281dsuj8jYUHjsHDUyh/index.php?server=Test+server");
            panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;

        }
    }
}
