﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC_tests
{
    class SeleniumGetMothods
    {
        public static string GetText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.ClassName)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
            
            else return String.Empty;
        }


        public static string GetTextFromDDL(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.ClassName)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
