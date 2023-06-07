using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class CategoriesTest : BaseTest
    {
        [Test]
        public void CategoryTest()
        {
            Category.HoverCategoryWomen();
            Category.ClickTshirtsLink();

            string expectedHideFiltersButton = "SLĖPTI FILTRUS";
            string actualHideFiltersButton = Category.GetHideDataButtonLabel();

            Assert.AreEqual(expectedHideFiltersButton, actualHideFiltersButton);
        }
    }
}
