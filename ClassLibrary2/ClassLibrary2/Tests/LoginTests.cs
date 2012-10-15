using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingProject.TestHelpers;
using NUnit.Framework;
using TestingProject.Tests;

namespace TestingProject
{
    [TestFixture]
    public class LoginTests : BaseTests
    {
        static LoginHelper loginHelper = new LoginHelper();

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
