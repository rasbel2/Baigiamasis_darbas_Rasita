namespace Framework.Pages.Sizeer
{
    public class UserSignIn
    { 
        public static void ClickProfileButton()
        {
            Common.ClickElement(Locators.UserSignIn.profileInButton);
        }

        public static void EnterEmailAddress(string emailAddress)
        {
            Common.ClickElement(Locators.UserSignIn.enterMailField);
            Common.SendKeys(Locators.UserSignIn.enterMailField, emailAddress);
        }

        public static void EnterPassword(string password)
        {
            Common.ClickElement(Locators.UserSignIn.enterPasswordField);
            Common.SendKeys(Locators.UserSignIn.enterPasswordField, password);
        }

        public static void ClickSubmitInButton()
        {
            Common.ClickElement(Locators.UserSignIn.submitButton);
        }

        public static string GetYourDataMessage()
        {
            return Common.GetElementText(Locators.UserSignIn.yourDataMassage);
        }
    }
}
