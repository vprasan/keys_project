//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testspecflow.Utility;

namespace testspecflow.Features.Pages
{
    class MyRentalsPage
    {
        public MyRentalsPage ()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }


        //Locator for Menu option in My Rentals page
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[6]/div/i")]
        public IWebElement buttonmenu;

        //Locator for sub menu option "Send a request" in My Rentals page
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[6]/div/div/div[1]")]
        public IWebElement buttonsendarequest;

        //Locator for sub menu option "My Requests" in My Rentals page
        [FindsBy(How = How.XPath, Using = "//a[@href='/Tenants/Home/MyRequests?returnUrl=%2FTenants%2FHome%2FMyRentals&propId=10560']")]
        public IWebElement buttonMyRequests;


        //Locator for sub menu option "Landlords Requests" in My Rentals page
        //[FindsBy(How = How.XPath, Using = "//a[@href='/Tenants/Home/LandLordRequests?returnUrl=%2FTenants%2FHome%2FMyRentals&propId=4642']")]
        //public IWebElement buttonLandlordRequests;

        //Locator for sub menu option "Landlords Requests" in My Rentals page
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[6]/div/div/div[3]/a")]
        public IWebElement buttonLandlordRequests;


        public void click()
        {
            System.Threading.Thread.Sleep(1000);
            buttonmenu.Click();
            System.Threading.Thread.Sleep(1000);
            buttonsendarequest.Click();
        }

        public void MyRequestsclick()
        {
            System.Threading.Thread.Sleep(1000);
            buttonmenu.Click();
            System.Threading.Thread.Sleep(1000);
            buttonMyRequests.Click();
        }


        public void LandlordRequestsClick()
        {
            System.Threading.Thread.Sleep(1000);
            buttonmenu.Click();
            System.Threading.Thread.Sleep(2000);
            buttonLandlordRequests.Click();
        }

    }
}
