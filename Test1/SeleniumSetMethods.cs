using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace MMC_tests
{
    class SeleniumSetMethods
    {
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if(elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
        }

        public static void Click(string element, PropertyType elementtype, string text) //нажатие на кнопку // T-передаваемый текст, еслли одинаковые классы
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            if (elementtype == PropertyType.LinkText)
                PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
            
        }

        public static void SelectDropDown(string element, string value, PropertyType elementtype, string text) //смена блока
        {
            if (elementtype == PropertyType.Id)
               new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
        }



        public static ICollection<IWebElement> GetElementsByClass(IWebDriver driver, string className)
        {
            return driver.FindElements(By.ClassName(className)).ToList();
        }
    }
}
