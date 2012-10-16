using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using Selenium;
using NUnit.Framework;

namespace TestingProject.Framework
{
    class Utils : BaseObject
    {
        public static string baseUrl = "http://www.facebook.com";
        private const int DEFAULT_TIMEOUT = 30;

        public static void WaitForElementPresent(string locator, int timeOut = DEFAULT_TIMEOUT)
        {
            for (int i = 0; i < timeOut; i++)
            {
                
                if (Selenium.IsElementPresent(locator))
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
