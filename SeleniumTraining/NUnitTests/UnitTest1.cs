using NUnit.Framework;
using Scripts;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;


namespace Tests
{
    public class Tests
    {
       private IWebDriver driver;
        private const bool Obj = true;
        Class1 c1 = new Class1();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Test1ChromeTest();
            // var ret=c1.testCond();
            // if(ret.Equals(Obj))
            // Assert.Pass();
            // else
            // Assert.Fail();
        }
        public void Test1ChromeTest()
        {
            driver = new ChromeDriver(@"C:\CSharpSelenium\SeleniumTraining\NUnitTests\drivers");
           // driver.Navigate().GoToUrl("https://Google.com");
            LaunchSiteTest();
            
            

           // driver.Close();
          
        }
        public void LaunchSiteTest()
        {
            driver.Navigate().GoToUrl("http://shop.demoqa.com");
            SearchInput();
        }


        public void SearchInput()
        {
            driver.FindElement(By.ClassName("noo-search")).Click();
            driver.FindElement(By.XPath("//input[@type='search']")).SendKeys("Rajni");
           // IWebElement element = driver.FindElement(By.XPath());
        }
    }
}