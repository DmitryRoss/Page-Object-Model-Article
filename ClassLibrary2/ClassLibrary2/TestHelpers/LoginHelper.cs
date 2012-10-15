using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingProject.Pages;
using NUnit.Framework;

namespace TestingProject.TestHelpers
{
    public class LoginHelper
    {
        LoginPage loginPage = new LoginPage();
        LandingPage landingPage = new LandingPage();

        public LoginHelper DoLogin(string userName, string password)
        {
            TestFramework.InitPage(loginPage);
            loginPage.
                TypeUserName(userName).
                TypePassword(password).
                ClickLoginButton();
            return this;
        }

        public LoginHelper AssertUserName(string userName)
        {
            landingPage.AssertUserName(userName);
            return this;
        }
    }
}
