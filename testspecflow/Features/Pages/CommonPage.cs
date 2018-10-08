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
    public class CommonPage
    {
       // public CommonPage(IWebDriver driver) //constructor to initialise the webdriver.
        public  CommonPage()

        {
            PageFactory.InitElements(BrowserFactory.driver, this);       

        }

               
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skip')]")]
        public IWebElement btnSkip;
        

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Owners')]")]
        public IWebElement btnOwner;

        [FindsBy(How = How.LinkText, Using = "Properties")]
        public IWebElement btnProperties;


        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'item-link item selected')]")]
        public IWebElement btnDashboard;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Tenants')]")]
        public IWebElement btnTenants;

        [FindsBy(How = How.XPath, Using = "//a[@href ='/Tenants/Home/MyRentals']")]
        public IWebElement btnMyRentals;

        public void clickOwners()
        {
            if (btnSkip.Displayed)
            {
                btnSkip.Click();
            }
            
           
            System.Threading.Thread.Sleep(5000);
            btnOwner.Click();
            System.Threading.Thread.Sleep(5000);
            btnProperties.Click();
         

        }



        public void clickDasbhoard()
        {
            if (btnSkip.Displayed)
            {
                btnSkip.Click();
            }


            System.Threading.Thread.Sleep(5000);
            btnDashboard.Click();
            System.Threading.Thread.Sleep(5000);
            //btnDashboard.Click();


        }


        public void clickTenants()
        {

            if (btnSkip.Displayed)
            {
                btnSkip.Click();
            }


            System.Threading.Thread.Sleep(5000);
            btnTenants.Click();
           

        }

        public void clickMyRentals()
        {

            System.Threading.Thread.Sleep(5000);
            btnMyRentals.Click();


        }




    }



}

