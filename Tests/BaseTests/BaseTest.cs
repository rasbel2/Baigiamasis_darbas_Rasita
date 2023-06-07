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
            Driver.OpenUrl("https://sizeer.lt/");
            Home.ClickCookieOkButton();
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
    }
}
