using InternProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//populate Login Page Test data collection
//it will read data from excel file like Username and Password
// populatecollection has 2 parameters (1 for file address and 2 file name) 
// you need to define address by @ bz its absulate path

namespace InternProject.Pages
{
    class AddSellerProfile
    {
        //Creating functions are Description,Language,Skill,Education,Certificate Tab
       
        public void Description(IWebDriver driver)
        {
            // Description Tab
            //wait for profile page to be loaded and driver visible discription Tab
            Sync.WaitForClickAuction(driver, "XPath", ".//*[@class='ui fluid card']/div/div[1]/h3/span/i", 10);
            //click on a pen sign to write text in Description 
            driver.FindElement(By.XPath(".//*[@class='ui fluid card']/div/div[1]/h3/span/i")).Click();
            //clear the text 
            driver.FindElement(By.XPath(".//textarea[@name='value']")).Clear();
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "AddSellerProfile");
            //write into textbox
            driver.FindElement(By.Name("value")).SendKeys(ExcelLibHelpers.ReadData(2, "Description"));
            //click on  Save button 
            driver.FindElement(By.XPath(".//button[@type='button']")).Click();
           //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();

        }

        public void Language(IWebDriver driver)
        {
            //wait untill driver visible Language Tab
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='first']", 10);
            //click on Language tab
            driver.FindElement(By.XPath(".//a[@data-tab='first']")).Click();
            //wait untill Add new button click 
            Sync.WaitForClickAuction(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10);
            //click on Add New button 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "AddSellerProfile");
             //write language into Add Language Textbox
            driver.FindElement(By.XPath(".//input[@placeholder='Add Language']")).SendKeys(ExcelLibHelpers.ReadData(2, "Add Language"));
            Sync.WaitForVisibility(driver, "Name", "level", 20);
            //choose item from Drop-down box
            driver.FindElement(By.Name("level")).SendKeys(ExcelLibHelpers.ReadData(2, "Level of Language"));
            //click on Add button
            driver.FindElement(By.XPath(".//*[@value='Add']")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
           //close the pop up
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void Skill(IWebDriver driver)
        {

            //Skill Tab
            //wait untill Skill tab visible 
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='second']", 10);
            //click on a Skill Tab
            driver.FindElement(By.XPath(".//a[@data-tab='second']")).Click();
            //click on Add New Button
            driver.FindElement
                (By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"))
                .Click();
            //populate AddSellerProfile Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "AddSellerProfile");
            //give input in Add Skill TextField
            driver.FindElement(By.XPath(".//*[@placeholder='Add Skill']")).SendKeys(ExcelLibHelpers.ReadData(2, "Add Skill"));
            Sync.WaitForClickAuction(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 20);
            //choose Skill Level from drop-down Box
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).SendKeys(ExcelLibHelpers.ReadData(2, "Level of Skill"));
            Sync.WaitForClickAuction(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]", 10);
            //click on Add Button 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            //close the pop up
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void Education(IWebDriver driver)
        {

            //Education Tab
            Sync.WaitForClickAuction(driver, "XPath", "//a[@data-tab='third']", 10);
            //click on Education tab
            driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();
            //click on Add New button
            driver.FindElement
                (By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"))
                .Click();
            //populate AddSellerProfile Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "AddSellerProfile");
            //Give an input in Collage/University Name TextField
            driver.FindElement(By.XPath(".//*[@name='instituteName']")).SendKeys(ExcelLibHelpers.ReadData(2, "InstituteName"));
            //Select country from drop-Down list
            IWebElement DropdownCountryList = driver.FindElement(By.Name("country"));
            DropdownCountryList.SendKeys(ExcelLibHelpers.ReadData(2, "Country") + Keys.Enter);
            //Select title
            IWebElement DropdownTitleList = driver.FindElement(By.Name("title"));
            DropdownTitleList.SendKeys(ExcelLibHelpers.ReadData(2, "Title") + Keys.Enter);
            //Give an input for Degree
            driver.FindElement(By.XPath(".//*[@placeholder='Degree']")).SendKeys(ExcelLibHelpers.ReadData(2, "Degree"));
            //select year of Graduate from drop-Down Box
            IWebElement DropdownYearList = driver.FindElement(By.Name("yearOfGraduation"));
            DropdownYearList.SendKeys(ExcelLibHelpers.ReadData(2, "YearOfGraduation") + Keys.Enter);
            //Click on Add Button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            //close the pop up
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }


        public void Certificate(IWebDriver driver)
        {
            //Certificate Tab
            //wait untill driver click on Certificate Tab
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='fourth']", 10);
            //click on Certificate Tab
            driver.FindElement(By.XPath(".//a[@data-tab='fourth']")).Click();
            //Click on Add New Button
            driver.FindElement
                (By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"))
                .Click();
            //populate AddSellerProfile Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "AddSellerProfile");
            //Give an input in Certificates or Awards
            driver.FindElement(By.Name("certificationName")).SendKeys(ExcelLibHelpers.ReadData(2, "CertificationName"));
            //Certificate From
            driver.FindElement(By.Name("certificationFrom")).SendKeys(ExcelLibHelpers.ReadData(2, "CertificationFrom"));
            //Select Year from Drop-Down List
            IWebElement DropdownCertyYearList = driver.FindElement(By.Name("certificationYear"));
            DropdownCertyYearList.SendKeys(ExcelLibHelpers.ReadData(2, "CertificationYear") + Keys.Enter);
            //Click on Add button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            //close the pop up
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }
    }
}
