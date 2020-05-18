using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternProject.Utilities
{
    class Sync
    {
        //create a function WaitForVisibility
        public static void WaitForVisibility(IWebDriver driver, string locator, string locatorValue, int Seconds)
        {
            if (locator == "Id")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locator == "XPath")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Name")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
            }
            if (locator == "ClassName")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 50));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(locatorValue)));
            }


        }

        //create a function for button/ click Aucktion
        public static void WaitForClickAuction(IWebDriver driver, string locator, string locatorValue, int Seconds)
        {
            if (locator == "Id")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "XPath")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "Name")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }
            if (locator == "ClassName")
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(locatorValue)));
            }
        }

    }
}

     
