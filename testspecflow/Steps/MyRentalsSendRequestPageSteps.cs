using com.keyswebsite_test.Pages;
using System;
using TechTalk.SpecFlow;
using testspecflow.Features.Pages;



namespace testspecflow.Steps
{
    [Binding]
    public class MyRentalsSendRequestPageSteps
    {

        [Given(@"user is in the rental properties page with tenant credentials, ""(.*)"", ""(.*)""")]
        public void GivenUserIsInTheRentalPropertiesPageWithTenantCredentials(string username, string password)
        {
            //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.Login(username, password);
            System.Threading.Thread.Sleep(2000);
            page.clickLogin();

        }

    
        [When(@"user clicks on the menu option send a request")]
        public void WhenUserClicksOnTheMenuOptionSendARequest()
        {
            //create the object of the CommonPage
            CommonPage pageTenants = new CommonPage();
            System.Threading.Thread.Sleep(2000);
            pageTenants.clickTenants();
            System.Threading.Thread.Sleep(1000);
            pageTenants.clickMyRentals();


            //create the object of the MyRental Page
            MyRentalsPage pageMyRentals = new MyRentalsPage();
            System.Threading.Thread.Sleep(2000);
            pageMyRentals.click();
        }




        [When(@"enters the required request details in the rental request page, ""(.*)"",""(.*)""")]
        public void WhenEntersTheRequiredRequestDetailsInTheRentalRequestPage(string message, string ddw_request_type)
        {
            SendRequestPage pagesendrequest = new SendRequestPage();
            pagesendrequest.EnterSendRequestDetails(message);
            pagesendrequest.select_Property(ddw_request_type);


        }



        [When(@"clicks on the submit button")]
        public void WhenClicksOnTheSubmitButton()
        {

            SendRequestPage pagesendrequest = new SendRequestPage();
            System.Threading.Thread.Sleep(3000);
            pagesendrequest.clicksubmit();
            System.Threading.Thread.Sleep(2000);

        }
        
        [Then(@"the rental properties page should be displayed after saving the send request details")]
        public void ThenTheRentalPropertiesPageShouldBeDisplayedAfterSavingTheSendRequestDetails()
        {
           
        }
    }
}
