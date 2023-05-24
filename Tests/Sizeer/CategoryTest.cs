using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class CategoriesTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Category.Open("https://sizeer.lt/");
        }

        [Test]
        public void CategoryTest()
        {
            CheckForCookiePopUp();

            Category.HoverCategoryWomen();
            Category.ClickTshirtsLink();

            string expectedHideFiltersButton = "SLĖPTI FILTRUS";
            string actualHideFiltersButton = Category.GetHideDataButtonLabel();

            Assert.AreEqual(expectedHideFiltersButton, actualHideFiltersButton);
        }
    }
}
