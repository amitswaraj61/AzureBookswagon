using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace AzureBookswagon
{
   public class Base
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Initilize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            driver.Url = ConfigurationManager.AppSettings["URL"];
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}

