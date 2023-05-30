namespace Framework.Pages.Sizeer
{
    public class LanguageSection : BaseSection
    {
        public static void ClickLanguage()
        {
            Common.ExecuteScript($"document.getElementsByClassName('language-content')[0].querySelector('a[href=\"{Locators.LanguageChange.languageSelectFlagHref}\"]').click()");
        }

        public static string GetLanguage()
        {
            return Common.GetElementText(Locators.LanguageChange.languageIdentifier);
        }

        public static void ClickLanguageSelector()
        {
            Common.ExecuteScript($"document.getElementById('{Locators.LanguageChange.languageListArrowId}').click()");
        }
    }
}
