using com.keyswebsite_test.Pages;
using System;
using TechTalk.SpecFlow;
using testspecflow.Features.Pages;
using testspecflow.Utility;

namespace testspecflow.Steps
{
    [Binding]
    public class ValidateMyRentalsPageSteps
    {
        [Given(@"user is in dashboard page with tenant credentials ""(.*)"", ""(.*)""")]
        public void GivenUserIsInDashboardPageWithTenantCredentials(string username, string password)
        {
          
            //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.Login(username, password);
            System.Threading.Thread.Sleep(2000);
            page.clickLogin();


           
        }

        [When(@"user click on the Tenants Menu option")]
        public void WhenUserClickOnTheTenantsMenuOption()
        {

            //create the object of the CommonPage
            CommonPage pageTenants = new CommonPage();
            System.Threading.Thread.Sleep(2000);
            pageTenants.clickTenants();


        }

        [When(@"user click on My Rentals sub menu option")]
        public void WhenUserClickOnMyRentalsSubMenuOption()
        {
            //create the object of the CommonPage
            CommonPage pageTenants = new CommonPage();
            System.Threading.Thread.Sleep(2000);
            pageTenants.clickMyRentals();

        }

        [Then(@"the user should see My Rentals page with his rental property details")]
        public void ThenTheUserShouldSeeMyRentalsPageWithHisRentalPropertyDetails()
        {
            //Hooks.cs triggers the "after test" hooks to display the test result
        }
    }
}
