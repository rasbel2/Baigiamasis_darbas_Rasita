using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;


namespace Tests.Sizeer
{
    internal class UserSignInTest : BaseTest
    {
        [Test]
        public void SignInTest()
        {
            CheckForCookiePopUp();

            UserSignIn.ClickProfileButton();
            UserSignIn.EnterEmailAddress("pecelyterasita@gmail.com");
            UserSignIn.EnterPassword("Testauskas159_");
            UserSignIn.ClickSubmitInButton();
            UserSignIn.ClickProfileButton();

            string expectedYourDataLabel = "Jūsų duomenys";
            string actualYourDataLabel = UserSignIn.GetYourDataMessage();

            Assert.AreEqual(expectedYourDataLabel, actualYourDataLabel);
        }

    }
}
