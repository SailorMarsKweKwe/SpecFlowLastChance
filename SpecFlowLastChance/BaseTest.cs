using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowLastChance
{
    public class BaseTest : IDisposable
    {
        public IWebDriver StartDriverWithURL(string url)
        {
            DriverHolder.driver = new ChromeDriver();
            DriverHolder.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            DriverHolder.driver.Manage().Window.Maximize();
            DriverHolder.driver.Navigate().GoToUrl(url);
            return DriverHolder.driver;
        }

        public void Dispose()
        {
            DriverHolder.driver.Quit();
        }

    }
}  