using System;
using OpenQA.Selenium;
namespace Wrappers
{
    public class CommonFunction
    {
        public static void click(IWebElement webElement)
        {
            if (webElement.Displayed)
            {
                if (webElement.Enabled)
                {
                    webElement.Click();
                }
                else
                {
                    throw new ElementNotSelectableException("Element is not enabled");
                }
            }
            else
                throw new ElementNotVisibleException("Element is not visible");

        }
        public static void enterKeys(IWebElement webElement, string message)
        {
            if (webElement.Displayed)
            {
                if (webElement.Enabled)
                {
                    webElement.Clear();
                    webElement.SendKeys(message);
                }
                else
                {
                    throw new ElementNotSelectableException("Element is not enabled");
                }
            }
            else
                throw new ElementNotVisibleException("Element is not visible");


        }
    }
}