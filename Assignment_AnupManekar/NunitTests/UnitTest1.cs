using NUnit.Framework;
using Scripts;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using Wrappers;
using Tests;

namespace Tests
{
    public class Tests
    {
        static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            driver = new FirefoxDriver(@"C:\CSharpSeleniumAssignments\Assignment_AnupManekar\NunitTests\drivers");
            driver.Url = "http://shop.demoqa.com/";
            var homePage = new HomePage();
            PageFactory.InitElements(driver,homePage);
            
            CommonFunction.click(homePage.LogInTxt);
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver,loginPage);
            CommonFunction.enterKeys(loginPage.UserName,"testuser");
            CommonFunction.enterKeys(loginPage.UserPassword,"Test@123");
            // Now submit the form.
            CommonFunction.click(loginPage.SubmitButton);
            driver.Quit();
        }
    }
}