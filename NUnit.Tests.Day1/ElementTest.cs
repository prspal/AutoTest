using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests.Day1
{
    class ElementTest
    {

        Browser browser;

        /*
        [OneTimeSetUp]
        public void OnetimeSetup()
        {
            browser =  Browser.Init(Browser.Type.Chrome);
            browser =  Browser.Init(Browser.Type.Chrome);
            browser =  Browser.Init(Browser.Type.Chrome);

            var login = new Login(browser.Driver);
            login.DoLogin();
        }

        [OneTimeTearDown]
        public void OnceTeardown()
        {
            browser.Quit();
            browser =  Browser.Init(Browser.Type.Chrome);
        }
        */

        [SetUp]
        public void Setup()
        {
            browser =  Browser.Init(Browser.Type.Chrome); 
        }

        [TearDown]
        public void Teardown()
        {
            browser.Quit();
        }


        [Test]
        public void Test1()
        { 
        }
        [Test]
        public void Test2()
        {
            //browser.Url = "http://google.com";
        }
        public void Test()
        {
            //SLEEP                 90 sec
            //Implicit wait         90 sec
            //Explicit wait         90 sec

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(""));

            try
            {
                SetContainer("drdom030.lab/AutoDN2020Apr21/M8yjaayCD1");
            }
            catch
            {
                ;
            }


        }

        private void SetContainer(string path)
        {

            var arr = path.Split('/');

            var xpath = "//*[normalize-space(text())='All My Managed Domains']/preceding-sibling::tree-node-expander";
            var elem = browser.Driver.FindElement(By.XPath(xpath));
            elem.Click();

            for (int idx = 0;idx< arr.Length; idx++)
            {
                var baseX = "../..//*[normalize-space(text())='" + arr[idx] + "']";
                xpath = idx + 1 != arr.Length ? $"{baseX}/preceding-sibling::tree-node-expander" : baseX;

                elem = elem.FindElement(By.XPath(xpath));
                elem.Click();

            }

        }

    }
}
