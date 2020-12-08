using BuildAxactTest.ObjectRepos;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAxactTest.WrapperClasses
{
    public class SeleniumHelper
    {
        private static IWebElement element;
        private static SelectElement select;

        public static void NavigateToURL(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);

        }

        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element not found:" + Locator.ToString());

        }

        

        public static void ClickLink(By Locator)
        {
            element = GetElement(Locator);
            element.Click();

        }
        public static void EnterText(By Locator, string text)
        {
            element = GetElement(Locator);
        element.SendKeys(text);

        }
        public static void SelectElement(By Locator, int index)
        {
            select = new SelectElement(SeleniumHelper.GetElement(Locator));
            select.SelectByIndex(index);
        }

        public static void Clickbtn(By Locator)
        {
            element = GetElement(Locator);
            element.Click();

        }
    }
}
