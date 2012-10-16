using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingProject.TestHelpers;
using NUnit.Framework;
using TestingProject.Tests;

namespace TestingProject.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        private static LoginHelper loginHelper = new LoginHelper();

        [Test]
        public static void AssertLogin()
        {
            string userName = "tuser125@mail.ru";
            string password = "password03";
            string displayedUserName = "Tobby  Tabulator";
            
            loginHelper.
                DoLogin(userName, password).
                AssertUserName(displayedUserName);
        }
    }
}
