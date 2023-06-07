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
            Menu.ClickCategoryByName(Menu.MenuNames.Moterims, Menu.CategoryNames.Marskineliai);

            string expectedHideFiltersButton = "SLĖPTI FILTRUS";
            string actualHideFiltersButton = Category.GetHideDataButtonLabel();

            Assert.AreEqual(expectedHideFiltersButton, actualHideFiltersButton);
        }
    }
}
