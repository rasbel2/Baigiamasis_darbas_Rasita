using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using OpenQA.Selenium.Support.Extensions;
using System.ComponentModel;

namespace Framework
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void HoverElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.MoveToElement(element);
            actions.Perform();
        }

        internal static void Navigate(string url)
        {
            Driver.GetDriver().Navigate().GoToUrl(url);
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }
        
        internal static void PressEnter(string locator)
        {
            GetElement(locator).SendKeys(Keys.Enter);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetElementAttribute(string locator, string attribute)
        {
            return GetElement(locator).GetAttribute(attribute);
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static void ExecuteScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }
        // found here: https://stackoverflow.com/a/630900
        internal static string GetEnumDescriptionValue<T>(T enumValue)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])enumValue
                .GetType()
                .GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        } 
    }
}
