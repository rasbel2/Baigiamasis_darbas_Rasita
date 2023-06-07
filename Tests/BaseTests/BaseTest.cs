using NUnit.Framework.Interfaces;
using NUnit.Framework;
using Framework;
using Framework.Pages.Sizeer;

namespace Tests.BaseTests
{
    public class BaseTest
    {
        [SetUp]
        public virtual void SetUp()
        {
            Driver.SetupDriver();
        }

        [SetUp]
        public void Open()
        {
            BaseSection.Open("https://sizeer.lt/");
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string fileName = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(fileName);
            }
            Driver.CloseDriver();
        }

        public void CheckForCookiePopUp()
        {
            try
            {
                BaseSection.ClickCookieOkButton();
            }
            catch
            {
            }
        }
    }
}
