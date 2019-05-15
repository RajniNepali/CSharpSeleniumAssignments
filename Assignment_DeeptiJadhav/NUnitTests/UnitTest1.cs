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
        Class1 obje = new Class1();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            obje.Practice();  
        //      ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\CSharpSeleniumAssignments\Assignment_DeeptiJadhav\NUnitTests\drivers");
        //     IWebDriver driver = new ChromeDriver(service);
        //     driver.Navigate().GoToUrl("http://demo.guru99.com/test/delete_customer.php");
            
        //     driver.FindElement(By.Name("cusid")).SendKeys("53920");
        //     driver.FindElement(By.Name("submit")).Submit();
        //     IAlert alert = driver.SwitchTo().Alert();
        //     string alertmessage = driver.SwitchTo().Alert().Text;
        //    // Console.WriteLine(alertmessage);
        //     alert.Accept();                                                      
        //     Assert.Pass();
        }
    }
}