using com.keyswebsite_test.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testspecflow.Features.Pages;
using testspecflow.Utility;

namespace testspecflow.Features
{
    [Binding]
    public class ValidateTheOwnersDashboardPageSteps
    {
        [Given(@"user navigate to keys web application")]
        public void GivenUserNavigateToKeysWebApplication()
        {
           //Initialization of the browser and the user navigation to dashboard will happen in GivenUserType method below 
        }
        
        [Given(@"user  type  ""(.*)"", ""(.*)""")]
        public void GivenUserType(string username, string password)
        {

            ConfigFile.username = username;
            ConfigFile.password = password;

        }

        [Given(@"user is in dashboard page")]
        public void GivenUserIsInDashboardPage()
        {
         //User is in the dashboard page when login is successfull and no actions requred here  
        }
        
        [When(@"user click login button")]
        public void WhenUserClickLoginButton()
        {
            //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.Login(ConfigFile.username, ConfigFile.password);
            System.Threading.Thread.Sleep(2000);
            page.clickLogin();

            //create the object of the CommonPage
            CommonPage pageproperties = new CommonPage();
            System.Threading.Thread.Sleep(2000);
            pageproperties.clickDasbhoard();

        }

        [When(@"user clicks on the properties link")]
        public void WhenUserClicksOnThePropertiesLink()
        {
            //create the object of the LoginPage
            DashboardPage page = new DashboardPage();
            System.Threading.Thread.Sleep(2000);
            page.Propertyclick();
            ConfigFile.MyPropertyPageTitle = BrowserFactory.Title();
            

            //create the object of the OwnersPage
            OwnersPage PageOwners = new OwnersPage();
            System.Threading.Thread.Sleep(2000);
            PageOwners.clickbackbutton();

        }
        
        [When(@"user clicks on tenants link")]
        public void WhenUserClicksOnTenantsLink()
        {
            //create the object of the LoginPage
            DashboardPage page = new DashboardPage();
            System.Threading.Thread.Sleep(2000);
            page.Tenantclick();

            ConfigFile.MyTenanatPageTitle = BrowserFactory.Title();

            //create the object of the MyTenantDetails Page
            MyTenantDetailsPage PageTenants = new MyTenantDetailsPage();
            System.Threading.Thread.Sleep(3000);
            PageTenants.click();              
            
           
        }

        [When(@"user clicks on finance details link")]
        public void WhenUserClicksOnFinanceDetailsLink()
        {
            //create the object of the LoginPage
            DashboardPage page = new DashboardPage();
            System.Threading.Thread.Sleep(2000);
            page.Financeclick();
            ConfigFile.MyFinanacePageTitle = BrowserFactory.Title();

            //create the object of the MyFinancetDetails Page
            MyFinanceDetailsPage PageFinance = new MyFinanceDetailsPage();
            System.Threading.Thread.Sleep(3000);
            PageFinance.click();
        }
        
        [Then(@"user should be able to login successfully and Dasboard page should be displayed")]
        public void ThenUserShouldBeAbleToLoginSuccessfullyAndDasboardPageShouldBeDisplayed()
        {


            string actual_value = BrowserFactory.Title();

            string expected_value = "Dashboard";


        //  	var actualItem= PageMaterial.CanCreateTimeandMaterial(expectedcode);

            Assert.AreEqual(expected_value, actual_value, "Landing page is not as expected");
           

          //  Assert.Multiple(() =>
           // {
//
 //               Assert.That(test, Is.Null, "Actual and expected is different");
  //              Assert.That(test, Is.Not.Null, "Actual and expected is different");

    //        });*/


        }

        [Then(@"the user should see the respective pages i\.e properties, finance and tenant details on clicking the links")]
        public void ThenTheUserShouldSeeTheRespectivePagesI_EPropertiesFinanceAndTenantDetailsOnClickingTheLinks()
        {
            string actual_propertytitle = ConfigFile.MyPropertyPageTitle;

            string actual_tenanttitle = ConfigFile.MyTenanatPageTitle;

            string actual_financetitle = ConfigFile.MyFinanacePageTitle;

            if (actual_propertytitle != "")
            {
                //Properties | Property Community
                //Property Tenants

                Assert.IsTrue(actual_propertytitle.Contains("Community"), actual_propertytitle + " doesn't contains 'Community'");


               // string expected_value = "Community";
                // Assert.AreEqual(expected_value, actual_propertytitle, "Landing page is not as expected");
               // Assert.IsTrue(Contains(cted_value, actual_propertytitle);

            }
            else if (actual_tenanttitle != "")
            {
              
              //  Assert.AreEqual(expected_value, actual_tenanttitle, "Landing page is not as expected");

                Assert.IsTrue(actual_tenanttitle.Contains("Tenants"), actual_tenanttitle + " doesn't contains 'Tenants'");
            }
            else
            {
               
                Assert.IsTrue(actual_financetitle.Contains("Community"), actual_financetitle + " doesn't contains 'Community'");

            }

        }
    }
}
