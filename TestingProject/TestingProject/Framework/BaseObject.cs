using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingProject.Framework
{
    public class BaseObject
    {
        public static RemoteWebDriver Driver;
        public static DefaultSelenium Selenium;

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            PageFactory.InitElements(Driver, pageClass);
        }
    }
}
