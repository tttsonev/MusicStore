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
    public class OrderPage : Page
    {

        [FindsBy(How = How.Id, Using ="FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastName { get; set; }


        [FindsBy(How = How.Id, Using = "Address")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "City")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "State")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "PostalCode")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Id, Using = "Country")]
        public IWebElement Country { get; set; }


        [FindsBy(How = How.Id, Using = "Phone")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "PromoCode")]
        public IWebElement PromoCode { get; set; }


        [FindsBy(How = How.CssSelector, Using = "[type=\"submit\"]")]
        public IWebElement ButtonSubmit { get; set; }





        public static OrderPage NavigateTo(IWebDriver driver)
        {


            var orderPageInstance = PageFactoryExtensions.InitPage<OrderPage>(driver);

            return orderPageInstance;
        }
    }
}
