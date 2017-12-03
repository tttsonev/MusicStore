using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class ExamTests : DesktopSeleniumTestFixturePrototype
    {
        public ExamTests(Browsers browser) : base(browser)
        { }

        [Test]
        public void LoginTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);

            Thread.Sleep(3000);

            Assert.AreEqual("Hello Administrator@test.com!", homePageInstance.UserGreetingTextBox.Text.ToString(),"Hello .. assert");
            Assert.IsTrue(homePageInstance.LogoutButton.Displayed, "Log off buton is Displayed");

        }

        [Test]
        public void LogOutTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);

            Thread.Sleep(3000);

            Assert.AreEqual("Hello Administrator@test.com!", homePageInstance.UserGreetingTextBox.Text.ToString(), "Hello .. assert");
            Assert.IsTrue(homePageInstance.LogoutButton.Displayed, "Log off button is Displayed");

            homePageInstance.LogoutButton.Click();
            Thread.Sleep(3000);

            Assert.IsTrue(homePageInstance.RegisterButton.Displayed, "Register button is Displayed");
            Assert.IsTrue(homePageInstance.LoginButton.Displayed, "Log off button is Displayed");
        }

        [Test]
        public void CompletePurchaseTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);

            Thread.Sleep(3000);


            Assert.IsFalse(homePageInstance.IsCartVisible(), "Is cart visible");

            var albumList = homePageInstance.GetAlbums2();

            Assert.IsTrue(albumList.Count > 0);

            albumList.First().Click();

            Thread.Sleep(3000);

            var albumPageInstance = AlbumPage.NavigateTo(this.Driver);

            albumPageInstance.AddToCartButton.Click();


            Thread.Sleep(3000);

            Assert.IsTrue(homePageInstance.IsCartVisible(), "Is cart visible");


            var carPageInstance = CartPage.NavigateTo(this.Driver);

            Thread.Sleep(3000);

            carPageInstance.CheckOutButton.Click();

            Thread.Sleep(3000);

            var orderPageInstance = OrderPage.NavigateTo(this.Driver);

            orderPageInstance.FirstName.SendKeys("sdfdsf");

            orderPageInstance.LastName.SendKeys("sdfdsf");

            orderPageInstance.City.SendKeys("sdfdsf");
            orderPageInstance.Country.SendKeys("sdfdsf");
            orderPageInstance.Phone.SendKeys("sdfdsf");
            orderPageInstance.Address.SendKeys("sdfdsf");
            orderPageInstance.State.SendKeys("sdfdsf");

            orderPageInstance.PostalCode.SendKeys("sdfdsf");

            orderPageInstance.Email.SendKeys("sdfdsf@asfds.com");

            orderPageInstance.PromoCode.SendKeys("FREE");


            orderPageInstance.ButtonSubmit.Click();

            Thread.Sleep(3000);

            Assert.IsTrue(this.Driver.Url.Contains("http://qaf2017demo1-001-site1.dtempurl.com/Checkout/Complete/"));

            Thread.Sleep(3000);

        }

    }
}
