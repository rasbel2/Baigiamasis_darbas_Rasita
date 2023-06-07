using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class LanguageChangeTest : BaseTest
    {
        [Test]
        public void LanguageSelectTest()
        {
            LanguageSection.ClickLanguageSelector();
            LanguageSection.ClickLanguage();

            string expectedLanguage = "ANMELDUNG";
            string actualLanguage = LanguageSection.GetLanguage();

            Assert.AreEqual(expectedLanguage, actualLanguage);
        }
    }
}
