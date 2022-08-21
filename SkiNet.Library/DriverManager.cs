﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library
{
    public class DriverManager
    {
        private const string DefaultUrl = "https://skinet.herokuapp.com/shop";

        private static IWebDriver _driver;
        public IWebDriver Driver => _driver;

        public void Start()
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
                LoadUrl();
            }
        }

        private void LoadUrl(string url = null)
        {
            if (url == null)
            {
                //url = Config.Configuration.Url;
                url = DefaultUrl;
            }

            Driver.Url = url;
            Driver.Manage().Window.Maximize();
        }

        public void Quit() => Driver.Quit();
    }
}
