using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace TestingProject
{   
    public class TestFramework
    {
        public static RemoteWebDriver driver = null;
        public static DefaultSelenium selenium = null;
        public static string baseUrl = "http://www.facebook.com";

        public const int DEFAULT_TIMEOUT = 30;

        public static void InitPage<T>(T pageClass) where T : TestFramework
        {
            PageFactory.InitElements(driver, pageClass);
        }

        public static void WaitForElementPresent(string locator, int timeOut = DEFAULT_TIMEOUT)
        {            
            for (int i = 0; i < timeOut; i++)
            {
                if (selenium.IsElementPresent(locator))
                {
                    return;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000); ;
                }
            }
            Assert.Fail("Element '" + locator + "' is not found");
        }
    }
}
