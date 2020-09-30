using AzureBookswagon.Pages;
using NUnit.Framework;
using System;
using System.Configuration;

namespace AzureBookswagon.BookSwagonTest
{
    public class Test : Base
    {
        [Obsolete]
        [Test, Order(1)]
        public void ValidLogin()
        {
            Login login = new Login(driver);
            login.LoginToBookSwagaon(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["password"]);
            string actualResult = driver.Url;
            string expectedResult = "https://www.bookswagon.com/myaccount.aspx";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(2)]
        [System.Obsolete]
        public void SearchBookTest()
        {
            Search search = new Search(driver);
            search.SearchBook();
            string url = "https://www.bookswagon.com/search-books/mahabharata";
            string actual = driver.Url;
            Assert.AreEqual(url, actual);
        }

        [Test, Order(3)]
        [System.Obsolete]
        public void BuyBookTest()
        {
            SearchHomePage search = new SearchHomePage(driver);
            search.PlaceOrderBook();
            string url = "https://www.bookswagon.com/checkout-login";
            string actual = driver.Url;
            Assert.AreEqual(url, actual);
        }
    }
}
