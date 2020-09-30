using AzureBookswagon.Pages;
using NUnit.Framework;
using System;
using System.Configuration;

namespace AzureBookswagon.BookSwagonTest
{
   public class Test : Base
    {
        [Obsolete]
        [Test]
        public void ValidLogin()
        {
            Login login = new Login(driver);
            login.LoginToBookSwagaon(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["password"]);
            string actualResult = driver.Url;
            string expectedResult = "https://www.bookswagon.com/myaccount.aspx";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
