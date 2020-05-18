using InternProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternProject.Pages
{
    class DeleteSellerProfile
    {
        // //Creating Delete functions are Description,Language,Skill,Education,Certificate Tab

        public void DeleteDescription(IWebDriver driver)
        {

            // Description Tab
            //wait untill Description Tab clickable
            Sync.WaitForClickAuction(driver, "XPath", ".//*[@class='ui fluid card']/div/div[1]/h3/span/i", 10);
            //click on a pen sign to write text in Description 
            driver.FindElement(By.XPath(".//*[@class='ui fluid card']/div/div[1]/h3/span/i")).Click();
            //clear the text 
            driver.FindElement(By.XPath(".//textarea[@name='value']")).Clear();
            //click on save button 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void DeleteLanguage(IWebDriver driver)
        {
            //wait untill driver click on Language tab
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='first']", 10);
            //click on Language tab
            driver.FindElement(By.XPath(".//a[@data-tab='first']")).Click();
            //click on X button to delete
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i[last()]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void DeleteSkill(IWebDriver driver)
        {
            //Skill Tab
            //wait untill drive click on Skill Tab
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='second']", 10);
            //click on a Skill Tab
            driver.FindElement(By.XPath(".//a[@data-tab='second']")).Click();
            //click on X button to deletre skill
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i[last()]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();

        }

        public void DeleteEducation(IWebDriver driver)
        {
            //Education Tab
            //wait untill Education Tab to be click
            Sync.WaitForClickAuction(driver, "XPath", "//a[@data-tab='third']", 10);
            //click on Education tab
            driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();
            //click on X button to delete Education
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i[last()]")).Click();
            //wait untill pop up window findout 
            Sync.WaitForVisibility(driver, "ClassName", "ns-box-inner", 20);
            //Get the text from pop up window 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string msglang = driver.FindElement(By.ClassName("ns-box-inner")).Text;
            Console.WriteLine(msglang);
            driver.FindElement(By.ClassName("ns-close")).Click();
            driver.SwitchTo().DefaultContent();

        }

        public void DeleteCertificate(IWebDriver driver)
        {
            //Certificate Tab
            //wait untill Certificate Tab to be click
            Sync.WaitForClickAuction(driver, "XPath", ".//a[@data-tab='fourth']", 10);
            //click on Certificate Tab
            driver.FindElement(By.XPath(".//a[@data-tab='fourth']")).Click();
            //click on X button to delete Education
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i[last()]")).Click();
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
