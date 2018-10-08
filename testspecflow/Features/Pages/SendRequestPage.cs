//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testspecflow.Utility;

namespace testspecflow.Features.Pages
{
    class SendRequestPage
    {

        public SendRequestPage() //constructor to initialise the webdriver.

        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }


        //textarea[@data-bind="value: Model.RequestMessage, valueUpdate:'afterkeydown'"]

        [FindsBy(How = How.XPath, Using = "//textarea[@data-bind=\"value: Model.RequestMessage, valueUpdate:'afterkeydown'\"]")]
        [CacheLookup]
        public IWebElement txtMessage { get; set; }


        [FindsBy(How = How.Id, Using = "jobRequestType")]
        [CacheLookup]
        public IWebElement jobRequestType { get; set; }


        //Locator for Submit Button

        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click: $root.SendRequest, enable : IsValid']")]
        public IWebElement btnSubmit;


        /*
                public void SelectElementFromDropDown(IWebElement element, string value)
                {
                    element.Click();

                    Select dropdown = new Select(jobRequestType);
                    var selecteElement = new SelectElement(element);

                    selecteElement.SelectByValue(value);
                }

          */

        public void select_Property(String ddw_sender_request)
        {
            //BrowserFactory.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            System.Threading.Thread.Sleep(1000);

         //   var select_prop_dropdown = BrowserFactory.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[2]/select"));
            // Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
         //   System.Threading.Thread.Sleep(1000);

            var select_prop_dropdown_value = new SelectElement(jobRequestType);

            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            System.Threading.Thread.Sleep(1000);
            select_prop_dropdown_value.SelectByText(ddw_sender_request);
        }




        //Enter the send request details
        public void EnterSendRequestDetails(String message)
        {
            txtMessage.SendKeys(message + Keys.Tab +  Keys.Tab);
        }


        public void clicksubmit()

        {
            btnSubmit.Click();
        }
    }

}