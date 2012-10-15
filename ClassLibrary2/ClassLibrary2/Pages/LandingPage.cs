using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingProject.TestHelpers;
using NUnit.Framework;

namespace TestingProject.Pages
{
    public class LandingPage : TestFramework
    {

        public static LandingPage GetLandingPage()
        {
            LandingPage landingPage = new LandingPage();
            InitPage(landingPage);
            return landingPage;
        }

        public LandingPage AssertUserName(string displayedUserName)
        {
            WaitForElementPresent(USER_NAME_TEXT.Replace("#", displayedUserName));
            return GetLandingPage();
        }

        public const string USER_NAME_TEXT = "//img[contains(@id,'profile_pic_header')]/../span[contains(text(),'#')]";
    }
}
