using InternProject.Pages;
using InternProject.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace InternProject.StepDefination  
{
    [Binding]
    class EditSellerDetailsSteps : CommonDriver
    {
        [Given(@"I am log in turn up portal")]
        public void GivenIAmLogInTurnUpPortal()
        {
            //Define Driver
             CommonDriver.driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");

            // Page Object for LoginPage
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(CommonDriver.driver);
        }

        [Then(@"I should be able to update Description in profile page")]
        public void ThenIShouldBeAbleToUpdateDescriptionInProfilePage()
        {
            //Page Object for EditSellerProfile
            EditSellerProfile editProfileObj = new EditSellerProfile();
            editProfileObj.EditDescription(CommonDriver.driver);
        }

        [Then(@"I should be able to update Language in profile page")]
        public void ThenIShouldBeAbleToUpdateLanguageInProfilePage()
        {
            //Page Object for EditSellerProfile
            EditSellerProfile editProfileObj = new EditSellerProfile();
            editProfileObj.EditLanguage(CommonDriver.driver);
        }
        
        [Then(@"I should be able to update Skill in profile page")]
        public void ThenIShouldBeAbleToUpdateSkillInProfilePage()
        {
            //Page Object for EditSellerProfile
            EditSellerProfile editProfileObj = new EditSellerProfile();
            editProfileObj.EditSkill(CommonDriver.driver);
        }
        
        [Then(@"I should be able to update Education in profile page")]
        public void ThenIShouldBeAbleToUpdateEducationInProfilePage()
        {
            //Page Object for EditSellerProfile
            EditSellerProfile editProfileObj = new EditSellerProfile();
            editProfileObj.EditEducation(CommonDriver.driver);
        }
        
        [Then(@"I should be able to update Certificate in profile page")]
        public void ThenIShouldBeAbleToUpdateCertificateInProfilePage()
        {
            //Page Object for EditSellerProfile
            EditSellerProfile editProfileObj = new EditSellerProfile();
            editProfileObj.EditCertificate(CommonDriver.driver);
        }
    }
}
