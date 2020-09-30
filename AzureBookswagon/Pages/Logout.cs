using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AzureBookswagon.Pages
{
   public class Logout
    {
        /// <summary>
        /// craete IWebDriver
        /// </summary>
        public IWebDriver driver;

        /// <summary>
        /// create Logout method
        /// </summary>
        /// <param name="driver"></param>

        [System.Obsolete]
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        public IWebElement logoutButton;

        /// <summary>
        /// create Logout to Bookswagon method
        /// </summary>
        public void LogoutToBookSwagaon()
        {
            logoutButton.Click();
            Thread.Sleep(2000);
        }
    }
}
