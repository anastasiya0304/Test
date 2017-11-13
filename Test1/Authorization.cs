using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC_tests
{
    class Authorization
    {
        public Authorization()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-auth/app-login/div/form/button/span")]
        public IWebElement BtnEnter { get; set; }

        public News Login(string userName, string password)
        {
            UserName.Clear();
            UserName.SendKeys(userName);
            Password.Clear();
            Password.SendKeys(password);
            BtnEnter.Click();

            return new News();
        }
    }
}
