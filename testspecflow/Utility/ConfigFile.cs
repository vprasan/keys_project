﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testspecflow.Utility
{
   public static class ConfigFile
    {
        
        public static IWebDriver driver { set; get; }

       public static String username { set; get; }

       public static String password { set; get; }

        public static String MyPropertyPageTitle { set; get; }

        public static String MyTenanatPageTitle { set; get; }

        public static String MyFinanacePageTitle { set; get; }

        public static class url
        {
            public static String app_url = "http://new-keys.azurewebsites.net/Account/Login";
            
        }

        public static class Browser
        {
            public static String browserName = "Chrome";
        }

    }
}
