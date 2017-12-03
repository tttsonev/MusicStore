using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class CartPage : Page
    {
        [FindsBy(How = How.LinkText, Using = "Checkout >>")]
        public IWebElement CheckOutButton { get; set; }

        public static CartPage NavigateTo(IWebDriver driver)
        {
            /*var page = LoginPage.NavigateTo(driver);
            System.Threading.Thread.Sleep(3000);

            page.LogIn();*/

            var cartPageInstance = PageFactoryExtensions.InitPage<CartPage>(driver);

            return cartPageInstance;
        }
    }
}
