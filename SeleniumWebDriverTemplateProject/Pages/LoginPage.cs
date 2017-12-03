﻿using OpenQA.Selenium;
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
    public class LoginPage : Page
    {
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-md-offset-2 input.btn")]
        public IWebElement LogInButton { get; set; }

        public static string Path { get { return "/Account/Login"; } }

        public static LoginPage NavigateTo(IWebDriver driver)
        {
            string baseURL = GeneralSettings.Default.BaseURL;
            driver.Navigate().GoToUrl(baseURL);

            if (driver.Manage().Cookies.AllCookies.Any())
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().GoToUrl(baseURL);
            }

            driver.Navigate().GoToUrl(baseURL + Path);

            var loginPageInstance = PageFactoryExtensions.InitPage<LoginPage>(driver);

            //Page.GlobalWait(driver).Until(d => driver.FindElements(By.Id("lfootercc")).Any());

            return loginPageInstance;
        }

        public void LogIn()
        {
            this.EmailTextBox.SendKeys(GeneralSettings.Default.UserName);
            this.PasswordTextBox.SendKeys(GeneralSettings.Default.Password);
            this.LogInButton.Click();

            // added because of firefox rushing
            System.Threading.Thread.Sleep(3000);
        }

        public void LogIn(string username, string password)
        {
            this.EmailTextBox.SendKeys(username);
            this.PasswordTextBox.SendKeys(password);
            this.LogInButton.Click();

            // added because of firefox rushing
            System.Threading.Thread.Sleep(3000);
        }
    }
}
