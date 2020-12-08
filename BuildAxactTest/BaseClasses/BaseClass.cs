using BuildAxactTest.Configuration;
using BuildAxactTest.ObjectRepos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAxactTest.BaseClasses
{
  [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetFirefoxDriver()

        {

            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeDriver()

        {

            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetIEDriver()

        {

            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }
        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())

            {   case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;
                

            }
        }
        [AssemblyCleanup]
        public static void TearDown()
        { if (ObjectRepository.Driver != null)
                ObjectRepository.Driver.Close();
            ObjectRepository.Driver.Quit();


        }


    }
}
