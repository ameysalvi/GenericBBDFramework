﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Silverbear.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverbear.Utilities
{
    public class Objects
    {
        IWebDriver driver = null;
        IWait<IWebDriver> iWait = null;

        public Objects(IWebDriver driver, BrowserInit browser)
        {
            this.driver = driver;
            this.iWait = browser.iWait;
        }

        public static Configuration.Config objConfig { get; set; }        
        
        public static PageObject.LoginPO objLogin_PO { get; set; }

        
        public void ObjectInitialization()
        {
            Logger.log.Info("Object Initialization is started.");

            objConfig = new Configuration.Config();
            
            objLogin_PO = new LoginPO(driver, iWait);

        }

    }
}
