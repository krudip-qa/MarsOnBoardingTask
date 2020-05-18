using InternProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternProject.Pages
{
    class EditSellerProfile
    {
        //Creating functions are Description,Language,Skill,Education,Certificate Tab
        public void EditDescription(IWebDriver driver)
        {
            // Description Tab
            //wait untill driver click on Description Tab
            Sync.WaitForClickAuction(driver, "XPath", ".//*[@class='ui fluid card']/div/div[1]/h3/span/i", 10);
            //click on a pen sign to write text in Description 
            driver.FindElement(By.XPath(".//*[@class='ui fluid card']/div/div[1]/h3/span/i")).Click();
            //clear the text 
            driver.FindElement(By.XPath(".//textarea[@name='value']")).Clear();
            //populate Login Page Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "EditSellerProfile");
            //write into textbox
            driver.FindElement(By.XPath(".//textarea[@name='value']")).SendKeys(ExcelLibHelpers.ReadData(2, "EditedDescription"));
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
        public void EditLanguage(IWebDriver driver)
        {
            //wait untill Language tab clickable
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='first']", 10);
            //click on Language tab
            driver.FindElement(By.XPath(".//a[@data-tab='first']")).Click();
            //Click on pen button to edit details 
            driver.FindElement(By.XPath(".//td[@class='right aligned']/span[1]/i[1]")).Click();
           //click on Add Language textField and clear textbox
            driver.FindElement(By.XPath(".//td[@colspan='3']/div/div/input")).Clear();
            //populate Login Page Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "EditSellerProfile");
            driver.FindElement(By.XPath(".//td[@colspan='3']/div/div/input")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit Language"));
            IWebElement DropdownEditLangList = driver.FindElement(By.Name("level"));
            DropdownEditLangList.SendKeys(ExcelLibHelpers.ReadData(2, "Level of Language") + Keys.Enter);
            driver.FindElement(By.XPath(".//input[@value='Update']")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }
        public void EditSkill(IWebDriver driver)
        {
            //Skill Tab
            //wait for Skill tab clickable
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='second']", 10);
            //click on a Skill Tab to Edit Skill
            driver.FindElement(By.XPath(".//a[@data-tab='second']")).Click();
            //click on pen button to edit Skill textbox and droupdown box
            driver.FindElement
                (By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
            //update the skill into text feild
            driver.FindElement(By.XPath(".//input[@placeholder='Add Skill']")).Clear();
            //populate Login Page Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "EditSellerProfile");
            //write updated skill in here
            driver.FindElement(By.XPath(".//input[@placeholder='Add Skill']")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit Skill"));
            //select level from droupdown 
            //choose Skill Level from drop-down Box
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select")).SendKeys(ExcelLibHelpers.ReadData(2, "Level of Skill"));
            //click on Update button 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }
        public void EditEducation(IWebDriver driver)
        {
            //Education Tab
            //wait untill driver click on Education Tab
            Sync.WaitForClickAuction(driver, "XPath", "//a[@data-tab='third']", 10);
            //click on Education tab
            driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();
            //click on pen button to Edit details 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();
            //Go to Uni mane and update the details
            driver.FindElement(By.XPath(".//*[@placeholder='College/University Name']")).Clear();
            //populate Login Page Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "EditSellerProfile");
            //passing new name inti TextField
            driver.FindElement(By.XPath(".//*[@placeholder='College/University Name']")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit University Name"));
            //Update detail on Country Drop down 
            driver.FindElement(By.Name("country")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit Country"));
            //Update title
            driver.FindElement(By.Name("title")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit Title"));
            //update Degree name 
            driver.FindElement(By.Name("degree")).Clear();
            driver.FindElement(By.Name("degree")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit Degree"));
            //Update a year from drop down boxbox
            driver.FindElement(By.Name("yearOfGraduation")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit yearOfGraduation"));
            //click on Update button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }

       
        public void EditCertificate(IWebDriver driver)
        {

            //Certificate Tab
            //wait untill drive click on certificate Tab
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='fourth']", 10);
            //click on Certificate Tab
            driver.FindElement(By.XPath(".//a[@data-tab='fourth']")).Click();
            //click on pen to edit details 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td[4]/span[1]")).Click();
           //populate Login Page Test data collection
            ExcelLibHelpers.PopulateInCollection(@"D:\InternPro\InternProject\TestData\TestData.xls", "EditSellerProfile");
            //Change the Crtificate name 
            driver.FindElement(By.Name("certificationName")).Clear();
            driver.FindElement(By.Name("certificationName")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit certificationName"));
            //Change the name for Crtificate From TextField
            driver.FindElement(By.Name("certificationFrom")).Clear();
            driver.FindElement(By.Name("certificationFrom")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit certificationFrom"));
            //Change the year 
            driver.FindElement(By.Name("certificationYear")).SendKeys(ExcelLibHelpers.ReadData(2, "Edit certificationYear"));
            //click on Update button
            driver.FindElement
                (By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"))
                .Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }

    }
}
