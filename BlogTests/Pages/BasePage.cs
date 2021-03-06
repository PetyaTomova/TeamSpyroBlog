﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BlogTests.Pages
{
    public class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        public string BaseUrl => "http://localhost:60634/Article/List";
    }
}
