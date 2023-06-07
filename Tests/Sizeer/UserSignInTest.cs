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
            string email = "pecelyterasita@gmail.com";
            string password = "Testauskas159_";
            string expectedYourDataLabel = "Jūsų duomenys";

            UserSignIn.ClickProfileButton();
            UserSignIn.EnterEmailAddress(email);
            UserSignIn.EnterPassword(password);
            UserSignIn.ClickSubmitInButton();
            UserSignIn.ClickProfileButton();
            string actualYourDataLabel = UserSignIn.GetYourDataMessage();

            Assert.AreEqual(expectedYourDataLabel, actualYourDataLabel);
        }

    }
}
