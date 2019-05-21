using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests.Stepdefs
{
    [Binding]
    public class Stepdefinations
    {
        [Given(@"I launch the Application")]
        public void ILaunchApplication()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Navigate().GoToUrl("https://testapp.galemframework.com");

        }

        [When(@"I enter search (.*/.)")]
        public void InvalidCookieException(string value)
        {
            ;
        }
        [Then]

    }
}