using OpenQA.Selenium;
using Protractor;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests.Day1
{
    class Login
    {
        IWebDriver Driver;

        public Login(IWebDriver driver)
        {
            Driver = driver;

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement TxtPassword { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//button[text()='Log in']")]
        private IWebElement BtnLogin { get;set; }

        public void DoLogin()
        {
            TxtUserName.Clear();
            TxtUserName.SendKeys("drdom030\\administrator");
            TxtPassword.SendKeys("Control123");
            ((NgWebDriver)Driver).WaitForAngular();
            BtnLogin.Click();
        }
    }
}
