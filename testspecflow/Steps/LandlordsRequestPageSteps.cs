using com.keyswebsite_test.Pages;
using System;
using TechTalk.SpecFlow;
using testspecflow.Features.Pages;

namespace testspecflow.Steps
{
    [Binding]
    public class LandlordsRequestPageSteps
    {
        [Given(@"user is in the rental properties page with tenant credential details, ""(.*)"", ""(.*)""")]
        public void GivenUserIsInTheRentalPropertiesPageWithTenantCredentialDetails(string username, string password)
        {
            //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.Login(username, password);
            System.Threading.Thread.Sleep(2000);
            page.clickLogin();

            //create the object of the CommonPage
            CommonPage pageTenants = new CommonPage();
            System.Threading.Thread.Sleep(2000);
            pageTenants.clickTenants();

            System.Threading.Thread.Sleep(2000);
            pageTenants.clickMyRentals();

        }

        [When(@"user clicks on the menu option Landlord's Request")]
        public void WhenUserClicksOnTheMenuOptionLandlordSRequest()
        {

            //create the object of the MyRentalsPage
            MyRentalsPage pageMyRentals = new MyRentalsPage();
            System.Threading.Thread.Sleep(2000);
            pageMyRentals.LandlordRequestsClick();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Then(@"the Landlord's Request page should be displayed")]
        public void ThenTheLandlordSRequestPageShouldBeDisplayed()
        {
            
        }
    }
}
