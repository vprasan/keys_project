using com.keyswebsite_test.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using testspecflow.Features.Pages;
using testspecflow.Utility;
using NUnit.Framework;


namespace testspecflow.Steps
{
    [Binding]
    public class DeletePropertySteps

    {
               
        [Given(@"user is logged in the application with credentials ""(.*)"", ""(.*)""")]
        public void GivenUserIsLoggedInTheApplicationWithCredentials(string username, string password)
        {
            //Launch the browser and navigate to the keys website
          //  IWebDriver driver = BrowserFactory.BrowserInit();

           //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.Login(username, password);
            page.clickLogin();

            //create the object of the CommonPage
            CommonPage pageproperties = new CommonPage();
            pageproperties.clickOwners();
        }

        [When(@"user clicks on the delete property button in the property page")]
        public void WhenUserClicksOnTheDeletePropertyButtonInThePropertyPage()
        {
            //create the object of the OwnersPage
            OwnersPage PageOwners = new OwnersPage();
            PageOwners.clickDeleteProperty();
            System.Threading.Thread.Sleep(3000);

        }

        [Then(@"the selected property will be deleted from the owners property\.")]
        public void ThenTheSelectedPropertyWillBeDeletedFromTheOwnersProperty_()
        {

            //BrowserFactory.Close();
        }
    }
}
