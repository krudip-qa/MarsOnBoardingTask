using InternProject.Pages;
using InternProject.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace InternProject.StepDefination
{
    [Binding]
   class AddSellerDetailsSteps : CommonDriver 
     {
        [Given(@"I have loged in turn up portal")]
        public void GivenIHaveLogedInTurnUpPortal()
        {
            // Define Driver
            CommonDriver.driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");

            // Page Object for LoginPage
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(CommonDriver.driver);
        }
        
        [Then(@"I should be able to Add Description in profile page")]
        public void ThenIShouldBeAbleToAddDescriptionInProfilePage()
        {
            //Page Object for AddSellerProfile
            AddSellerProfile addProfileObj = new AddSellerProfile();
            addProfileObj.Description(CommonDriver.driver);
        }
        [Then(@"I should be able to Add Language in profile page")]
        public void ThenIShouldBeAbleToAddLanguageInProfilePage()
        {
            //Page Object for AddSellerProfile
            AddSellerProfile addProfileObj = new AddSellerProfile();
            addProfileObj.Language(CommonDriver.driver);
        }

        [Then(@"I should be able to Add Skill in profile page")]
        public void ThenIShouldBeAbleToAddSkillInProfilePage()
        {
            //Page Object for AddSellerProfile
            AddSellerProfile addProfileObj = new AddSellerProfile();
            addProfileObj.Skill(CommonDriver.driver);
        }

        [Then(@"I should be able to Add Education in profile page")]
        public void ThenIShouldBeAbleToAddEducationInProfilePage()
        {
            //Page Object for AddSellerProfile
            AddSellerProfile addProfileObj = new AddSellerProfile();
            addProfileObj.Education(CommonDriver.driver);
        }

        [Then(@"I should be able to Add Certificate in profile page")]
        public void ThenIShouldBeAbleToAddCertificateInProfilePage()
        {
            //Page Object for AddSellerProfile
            AddSellerProfile addProfileObj = new AddSellerProfile();
            addProfileObj.Certificate(CommonDriver.driver);
        }
   }
}
