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
    class MyFinanceDetailsPage
    {
        public MyFinanceDetailsPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class=' ui button']")]
        public IWebElement btnback;

        public void click ()
        {
            btnback.Click();

        }


    }
}
