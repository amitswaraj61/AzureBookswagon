using NUnit.Framework;
using NUnit.Framework.Interfaces;
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

        [TearDown]
        public void AddScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {

            string path= Screenshot.Capture(driver, TestContext.CurrentContext.Test.Name + "   " + "Failed");
                TestContext.AddTestAttachment(path, "failed");

            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
             string path= Screenshot.Capture(driver, TestContext.CurrentContext.Test.Name +"  " + "Passed");
                TestContext.AddTestAttachment(path, "passed");
            }
        }
    }
}

