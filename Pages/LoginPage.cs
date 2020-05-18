using InternProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//it will read data from excel file like Username and Password
// populatecollection has 2 parameters (1 for file address and 2 file name) 
// you need to define address by @ bz its absulate path

namespace InternProject.Pages
{
    class LoginPage
    {
        //Creating a function 
        public void LoginSteps(IWebDriver driver)
        {
            ////Open the chrome browser
            //IWebDriver driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");
            //Thread.Sleep(1000);
            //hit URL
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/");
            driver.Manage().Window.Maximize();
            //wait for web page to be loaded and able to visible Sign in button 
            Sync.WaitForVisibility(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 10);
            //Thread.Sleep(2000);
            //Identify Sign in button and click on it 
            driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
            //Navigate to handle pop up 
            driver.SwitchTo().ActiveElement();
            //populate Login Page Test data collection
             ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "LoginPage ");
            Sync.WaitForVisibility(driver, "Name", "email", 10);
            //identify Email id and provide input 
            //using excellibhelper we readdata from excelsheet 
            driver.FindElement(By.Name("email")).SendKeys(ExcelLibHelpers.ReadData(2,"email"));
            //identify password and provide input
            driver.FindElement(By.Name("password")).SendKeys(ExcelLibHelpers.ReadData(2,"password"));
            //check on checkbox
            driver.FindElement(By.XPath("//input[@name='rememberDetails']")).Click();
            //click on Login button 
            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();
            //Driver swich to default window
            driver.SwitchTo().DefaultContent();
             Sync.WaitForVisibility(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 20);
            //Assertion for checking condition
            Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span")).Text, Is.EqualTo("Hi krupa"));
        }
    }
}
