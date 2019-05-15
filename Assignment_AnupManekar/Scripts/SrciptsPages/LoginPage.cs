using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;

namespace Scripts
{
    public class LoginPage
    {
public IWebDriver driver;
        [FindsBy(How=How.XPath, Using="//input[@id='user_login']")]
        public IWebElement UserName{ get; set; }
        [FindsBy(How=How.Id,Using="user_pass")]
        public IWebElement UserPassword{ get; set; }
        [FindsBy(How=How.Id, Using="wp-submit")]
        public IWebElement SubmitButton{ get; set; }
        
        

        
        
    }
}