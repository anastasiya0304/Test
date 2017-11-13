using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC_tests
{
    class Electronic_Services
    {
        public Electronic_Services()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-main-page/app-get-patent/div[2]/app-electronic-services/div/div/ul/li[1]/a")]
        public IWebElement Status { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-main-page/app-get-patent/div[2]/app-electronic-services/div/div/ul/li[3]/a")]
        public IWebElement NeedPayment { get; set; }

        [FindsBy(How = How.Id, Using = "number")]
        public IWebElement NumberStatement { get; set; } 
        
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-electronic-services-page/div/div/section[1]/div[3]/div[2]/app-patent-claim-status/form/div[4]/button")] 
        public IWebElement CheckButton { get; set; }

        [FindsBy(How = How.Id, Using = "series")]
        public IWebElement Series { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-electronic-services-page/div/div/section[3]/div[3]/div[2]/app-patent-status-check/form/div[1]/input[2]")]
        public IWebElement NumberNDFL { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-electronic-services-page/div/div/section[3]/div[3]/div[2]/app-patent-status-check/form/div[4]/button")]
        public IWebElement CheckButtonNDFL { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-electronic-services-page/div/div/section[4]/div[3]/div[2]/app-find-out-inn/form/div[5]/button")]
        public IWebElement CheckButtonINN { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-worker/app-main-page/app-get-patent/div[2]/app-electronic-services/div/div/ul/li[4]/a")]
        public IWebElement INNLearn { get; set; }


        
        /// <summary> Найти элементы на странице </summary>
        public static ReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElements(by));
            }
            return driver.FindElements(by);
        }

        public void StatusPatent(string docnomer)
        {
            Status.Click();
            System.Threading.Thread.Sleep(2000);

            var editCommentTexts = FindElements(PropertiesCollection.driver, By.XPath("//*[@id=\"number\"]"), 20).First();
            editCommentTexts.Click();

            editCommentTexts.SendKeys(docnomer); 
            System.Threading.Thread.Sleep(4000);
            CheckButton.Click();

        }

        public void NeedPaymentNDFL(string series, string num_patent)
        {
            NeedPayment.Click();
            Series.SendKeys(series);
            NumberNDFL.SendKeys(num_patent);
            System.Threading.Thread.Sleep(3000);
            CheckButtonNDFL.Click();
        }

        public void INN (string num_patent, string numbertel)
        {
            INNLearn.Click();
            Series.SendKeys(num_patent);
            NumberNDFL.SendKeys(numbertel);
            System.Threading.Thread.Sleep(3000);
            CheckButtonINN.Click();
        }
    }
}
