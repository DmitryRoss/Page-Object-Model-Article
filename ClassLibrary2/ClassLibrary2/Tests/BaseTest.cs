using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using Selenium;
using OpenQA.Selenium.Remote;

namespace TestingProject.Tests
{
    [TestFixture]
    public class BaseTests : TestFramework
    {
        [TestFixtureSetUp]
        public void beforeClass()
        {
            driver = new FirefoxDriver();
            selenium = new WebDriverBackedSelenium(driver, baseUrl);
            selenium.Start();
            selenium.WindowMaximize();
        }

        [SetUp]
        public void beforeTest()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        [TestFixtureTearDown]
        public void afterClass()
        {
            driver.Close();
            selenium.Close();
        }        
    }
}
