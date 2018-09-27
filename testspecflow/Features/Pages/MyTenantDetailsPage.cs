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
    class MyTenantDetailsPage
    {
        public MyTenantDetailsPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
            
        }
        
        //Locator for Back to Dashboard button
        [FindsBy(How = How.XPath, Using = "//a[@data-bind=\"attr: { href: '/Home/Dashboard' }\"]")]
        public IWebElement buttonback;


        public void click ()
        {
            buttonback.Click();
        }

    }
    
    

}



