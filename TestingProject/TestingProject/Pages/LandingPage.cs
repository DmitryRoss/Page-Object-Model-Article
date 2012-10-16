using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingProject.TestHelpers;
using NUnit.Framework;
using TestingProject.Framework;

namespace TestingProject.Pages
{
    public class LandingPage : BaseObject
    {

        public static LandingPage GetLandingPage()
        {
            LandingPage landingPage = new LandingPage();
            InitPage(landingPage);
            return landingPage;
        }

        public LandingPage AssertUserName(string displayedUserName)
        {
            Utils.WaitForElementPresent(USER_NAME_TEXT.Replace("#", displayedUserName));
            return GetLandingPage();
        }

        public const string USER_NAME_TEXT = "//img[contains(@id,'profile_pic_header')]/../span[contains(text(),'#')]";
    }
}
