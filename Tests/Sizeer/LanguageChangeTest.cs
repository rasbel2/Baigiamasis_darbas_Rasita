﻿using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class LanguageChangeTest : BaseTest
    {
        [Test]
        public void LanguageSelectTest()
        {
            CheckForCookiePopUp();

            LanguageSection.ClickLanguageSelector();
            LanguageSection.ClickLanguage();

            CheckForCookiePopUp();

            string expectedLanguage = "ANMELDUNG";
            string actualLanguage = LanguageSection.GetLanguage();

            Assert.AreEqual(expectedLanguage, actualLanguage);
        }
    }
}
