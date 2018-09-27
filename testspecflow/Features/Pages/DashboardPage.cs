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
    public class DashboardPage
    {
       
        public  DashboardPage()
        {

            PageFactory.InitElements(BrowserFactory.driver, this);

        }
       
        //sub heading to verifiy the landing page is dashboard
        //Locator for preoperty name
        [FindsBy(How = How.XPath, Using = "//div[@class='sub header']")]
        public IWebElement txtsubheading;

        ////Locator for preoperty type
        //[FindsBy(How = How.XPath, Using = "//h4[@class = 'ui header' and contains(text(),'Properties')]")]
        //public  IWebElement txtPropertyType;

        //Locator for preoperty link
        [FindsBy(How = How.XPath, Using = "//h4[@class = 'ui header' and contains(text(),'Properties')]")]
        public IWebElement lnkforProperty;

        
        //Locator for tenant link
        [FindsBy(How = How.XPath, Using = "//h4[@class = 'ui header' and contains(text(),'Tenants')]")]
        public  IWebElement lnkforTenant;

        
        //Locator for finance link
        [FindsBy(How = How.XPath, Using = "//h4[@class = 'ui header' and contains(text(),'Finance')]")]
        public IWebElement lnkforFinance;

        public  void verifytitle()
        {

            //string expected;
            //expected = "Your properties at a glance";

            //txtsubheading.Text
                
        }

        public void Propertyclick()

        {

            lnkforProperty.Click();

        }

        public void Tenantclick()
        {
            lnkforTenant.Click();

        }

        public  void Financeclick()
        {
            lnkforFinance.Click();

        }



    }
}
