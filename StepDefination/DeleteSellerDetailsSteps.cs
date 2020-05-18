using InternProject.Pages;
using InternProject.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace InternProject.StepDefination
{
    [Binding]
    class DeleteSellerDetailsSteps : CommonDriver
    {
        [Given(@"I will be log in turn up portal")]
        public void GivenIWillBeLogInTurnUpPortal()
        {
            // Define Driver
            CommonDriver.driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");

            // Page Object for LoginPage
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(CommonDriver.driver);
        }

        [Then(@"I should be able to Delete Description in profile page")]
        public void ThenIShouldBeAbleToDeleteDescriptionInProfilePage()
        {
            // Page object for DeleteSellerProfile
            DeleteSellerProfile deleteProfileObje = new DeleteSellerProfile();
            deleteProfileObje.DeleteDescription(CommonDriver.driver);
        }

        [Then(@"I should be able to Delete Language in profile page")]
        public void ThenIShouldBeAbleToDeleteLanguageInProfilePage()
        {

            // Page object for DeleteSellerProfile
            DeleteSellerProfile deleteProfileObje = new DeleteSellerProfile();
            deleteProfileObje.DeleteLanguage(CommonDriver.driver);
        }
        
        [Then(@"I should be able to Delete Skill in profile page")]
        public void ThenIShouldBeAbleToDeleteSkillInProfilePage()
        {

            // Page object for DeleteSellerProfile
            DeleteSellerProfile deleteProfileObje = new DeleteSellerProfile();
            deleteProfileObje.DeleteSkill(CommonDriver.driver);
        }
        
        [Then(@"I should be able to Delete Education in profile page")]
        public void ThenIShouldBeAbleToDeleteEducationInProfilePage()
        {

            // Page object for DeleteSellerProfile
            DeleteSellerProfile deleteProfileObje = new DeleteSellerProfile();
            deleteProfileObje.DeleteEducation(CommonDriver.driver);
        }
        
        [Then(@"I should be able to Delete Certificate in profile page")]
        public void ThenIShouldBeAbleToDeleteCertificateInProfilePage()
        {

            // Page object for DeleteSellerProfile
            DeleteSellerProfile deleteProfileObje = new DeleteSellerProfile();
            deleteProfileObje.DeleteCertificate(CommonDriver.driver);
        }
    }
}
