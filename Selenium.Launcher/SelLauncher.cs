using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium.Launcher
{
    public partial class SelLauncher : Form
    {
        private RemoteWebDriver RemoWebDriver;

        public SelLauncher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chromedriver", " --port=10101 --verbose");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text, " --remote-debugging-port=10102");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            options.DebuggerAddress = "localhost:10102";
            //options.BinaryLocation = @"J:\ROOT\DOT.NET\CefSharp.MinimalExample-master\CefSharp.MinimalExample.WinForms\bin\x64\Debug\CefSharp.MinimalExample.WinForms.exe";
            //ChromeDriver driver = new ChromeDriver(options);
            RemoWebDriver = new RemoteWebDriver(new Uri("http://127.0.0.1:10101"), options.ToCapabilities());

        }

        private void button4_Click(object sender, EventArgs e)
        {

            RemoWebDriver.Url = "https://bing.com";
        }
    }
}
