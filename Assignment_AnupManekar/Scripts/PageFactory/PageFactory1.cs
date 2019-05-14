using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
namespace Scripts
{
    public class PageFactory1
    {
        LoginElements LoginEleObj = new LoginElements();
        LoginPage LoginScriptObj = new LoginPage();
        
        IWebDriver driver;
    }
}