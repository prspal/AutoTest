using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests.Day1
{
    class Browser
    {
        public readonly NgWebDriver Driver;

        public enum Type { Chrome, Firefox, IE }

        public string Url
        {
            get { return Driver.Url; }
            set { Driver.Url = value; }
        }

        private static bool isBrowserClosed = true;
        private static Browser _browser;
        public static Browser Init(Type type)
        {
            if (null == _browser || isBrowserClosed)
            {
                _browser = new Browser(type);
                isBrowserClosed = false;
            }

            return _browser;
        }


        private Browser(Type type)
        {
            IWebDriver driver = null;
            switch (type)
            {
                case Type.Chrome:
                    var copts = new ChromeOptions { AcceptInsecureCertificates = true };
                    driver = new ChromeDriver(copts);
                    break;
                case Type.Firefox:
                    var fopts = new FirefoxOptions { AcceptInsecureCertificates = true };
                    driver = new FirefoxDriver(fopts);
                    break;
                case Type.IE:
                    var iopts = new InternetExplorerOptions { AcceptInsecureCertificates = true };
                    driver = new InternetExplorerDriver(iopts);
                    break;
            }


            Driver = new NgWebDriver(driver);
        }

        internal void Quit()
        {
            Driver.Quit();
            isBrowserClosed = true;
        }
    }
}