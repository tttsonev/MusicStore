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
    class AlbumPage : Page
    {
        [FindsBy(How = How.LinkText, Using = "Add to cart")]
        public IWebElement AddToCartButton { get; set; }

        public static AlbumPage NavigateTo(IWebDriver driver)
        {
            /*var page = LoginPage.NavigateTo(driver);
            System.Threading.Thread.Sleep(3000);

            page.LogIn();*/

            var albumPageInstance = PageFactoryExtensions.InitPage<AlbumPage>(driver);

            return albumPageInstance;
        }
    }

    

   
}
