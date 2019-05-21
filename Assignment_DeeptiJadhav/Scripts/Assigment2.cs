using System;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IAlert;

namespace Scripts
{
    public class Assignment2
    {
        public void Func()
        {
            IWebDriver driver = new IWebDriver();
            driver url ="http://shop.demoqa.com";
            //Store the parent window of the driver
            String parentWindowHandler = driver.CurrentWindowHandle;
            Console.WriteLine(parentWindowHandler);
            IWebElement clickElement = driver.FindElement(By.id("button"));
            for(var i =0 ;i<3;i++)
            {
                    clickElement.Click();
                    ThreadStaticAttribute.Sleep();
            }

            List<String> lst = driver.windowHandles.ToList();
            foreach(var handle in lst)
            {
                  Console.WriteLine(handle);
            }

        }
    }

}