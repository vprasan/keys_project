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
    class AddPropertiesSteps
    {


       // IWebDriver driver = null;
        //Launch the browser and navigate to the keys website
        [Given(@"I navigate to keys web application")]
        public void GivenINavigateToKeysWebApplication()
        {
        //    IWebDriver driver = BrowserFactory.BrowserInit();

          //  this.driver = driver;
        }

        [Given(@"I  type  ""(.*)"", ""(.*)""")]
        public void GivenIType(string username, string password)
        {
            //create the object of the LoginPage
            // LoginPage page = new LoginPage(driver);

            LoginPage page = new LoginPage();
            page.Login(username, password);

        }


        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.clickLogin();
        }


        [Then(@"I should be able to login successfully and Dasboard page should be displayed")]
        public void ThenIShouldBeAbleToLoginSuccessfullyAndDasboardPageShouldBeDisplayed()
        {


        }

        [When(@"I click on Owners and click on the Properties button")]
        public void WhenIClickOnOwnersAndClickOnThePropertiesButton()
        {

        }


        [Then(@"I should navigate to My properties Page")]
        public void ThenIShouldNavigateToMyPropertiesPage()
        {
            //create the object of the CommonPage
            CommonPage pageproperties = new CommonPage();
            pageproperties.clickOwners();
        }


        [When(@"I click on the Add New Property Button")]
        public void WhenIClickOnTheAddNewPropertyButton()
        {
            //create the object of the OwnersPage
            OwnersPage PageOwners = new OwnersPage();
            PageOwners.clickAddProperty();

        }

        [Then(@"I should be on the Add New Properties Details Page")]
        public void ThenIShouldBeOnTheAddNewPropertiesDetailsPage()
        {



        }

        [When(@"I enter all the mandatory fields ""(.*)"", ""(.*)"", ""(.*)"",""(.*)"", ""(.*)"", ""(.*)"",""(.*)"",""(.*)"",""(.*)"", ""(.*)"", ""(.*)"",""(.*)"" and click on Next button")]
        public void WhenIEnterAllTheMandatoryFieldsAndClickOnNextButton(string property, int streetNumber, string route, string City, int post, string region, string desc, int rent, int bedroom, int bath, int car, int built)
        {
            //create the object of the AddPropertiesPage and enter the mandatory fields
            AddPropertiesPage PropertiesPage = new AddPropertiesPage();
            PropertiesPage.dataentry(property, streetNumber, route, City, post, region, desc, rent, bedroom, bath, car, built);

            System.Threading.Thread.Sleep(1000);
            //Click the next button by calling the click function
            PropertiesPage.click(true, false);
            System.Threading.Thread.Sleep(1000);
        }


        [Then(@"I should Navigate to Financial Details Page")]
        public void ThenIShouldNavigateToFinancialDetailsPage()
        {

        }

        [When(@"i enter all the required fields for Financial Details ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"",""(.*)"", ""(.*)"", ""(.*)"" and click on Next Button")]
        public void WhenIEnterAllTheRequiredFieldsForFinancialDetailsAndClickOnNextButton(int pprice, int mprice, int hvalue, int repayment, string repaystart, int expenseamt, string expensedesc, string expensedate)
        {
            //create the object of the Financial Details Page and enter the mandatory fields
            FinancialDetailsPage FinancialPage = new FinancialDetailsPage();

            FinancialPage.EnterFinancials(pprice, mprice, hvalue);

            System.Threading.Thread.Sleep(1000);
            //Click the repayment button
            FinancialPage.click(true, false, false);
            System.Threading.Thread.Sleep(1000);

            //Add the repayment details

            FinancialPage.EnterRepayments(repayment, repaystart);

            //Click the expense button
            FinancialPage.click(false, true, false);
            System.Threading.Thread.Sleep(1000);

            //Add the expense details


            FinancialPage.EnterExpense(expenseamt, expensedesc, expensedate);

            //  Click on the next button

            FinancialPage.click(false, false, true);
            System.Threading.Thread.Sleep(3000);

        }


        [Then(@"I should navigate to Add Tenant Details Page")]
        public void ThenIShouldNavigateToAddTenantDetailsPage()
        {

        }

        [When(@"I entered all the mandatory fields in the Tenant Details Page ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and click Save button")]
        public void WhenIEnteredAllTheMandatoryFieldsInTheTenantDetailsPageAndClickSaveButton(string email, string fname, string lname, string sdate, string edate, int ramt, string psdate)
        {
            //create the object of the Tenant Details Page and enter the mandatory fields
            TenantDetailsPage TenantPage = new TenantDetailsPage();

            TenantPage.EnterTenantDetails(email, fname, lname, sdate, edate, Convert.ToString(ramt), psdate);

            System.Threading.Thread.Sleep(3000);

            //  Click on the save button

            TenantPage.click(false, false, true);
            System.Threading.Thread.Sleep(3000);

        }


        [Then(@"I should see all the entered values saved\.")]
        public void ThenIShouldSeeAllTheEnteredValuesSaved_()
        {

            // assertion sample
            /*
            string test = "There is a value";

          //  string expectedcode = "Prasanna";
		//	var actualItem= PageMaterial.CanCreateTimeandMaterial(expectedcode);

		//	Assert.AreEqual(expectedcode, actualItem, "Code Didnt Match");

            Assert.Multiple(() =>
            {

                Assert.That(test, Is.Null, "Actual and expected is different");
                Assert.That(test, Is.Not.Null, "Actual and expected is different");

            });*/
            // BrowserFactory.Close();
        }



    }
}
