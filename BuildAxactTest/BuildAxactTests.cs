using System;
using System.Configuration;
using System.Threading;
using BuildAxactTest.Configuration;
using BuildAxactTest.Interface;
using BuildAxactTest.ObjectRepos;
using BuildAxactTest.WrapperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace BuildAxactTest
{
    [TestClass]
    public class BuildAxactTests
    {
        [TestMethod]
        public void TenantCreation()
        {
                     
            SeleniumHelper.NavigateToURL(ObjectRepository.Config.GetAccCreationEnv());
            SeleniumHelper.ClickLink(By.XPath("//*[@id='myModal']/div/span"));
            SeleniumHelper.ClickLink(By.XPath("//div[@id='top-bar']/div/div[3]/ul/li[4]/div/a/span"));
            SeleniumHelper.EnterText(By.Id("nf-field-1661"), "Fahad");
            SeleniumHelper.EnterText(By.Id("nf-field-1662"), "ABC");
            SeleniumHelper.EnterText(By.Id("nf-field-1663"), "fukhan389@hotmail.com");
            SeleniumHelper.EnterText(By.Id("nf-field-1664"), "0427268762");
            SeleniumHelper.SelectElement(By.Id("nf-field-1781"),1);
            SeleniumHelper.SelectElement(By.Id("nf-field-1782"), 13);
            SeleniumHelper.Clickbtn(By.Id("nf-field-1669"));
            SeleniumHelper.Clickbtn(By.Id("nf-field-1744-container"));
            SeleniumHelper.Clickbtn(By.Id("nf-field-1670"));
                    }
        [TestMethod]
        public void AccountActivation()
        {
            SeleniumHelper.NavigateToURL(ObjectRepository.Config.GetAccountActivationLink());
            Thread.Sleep(3000);
            SeleniumHelper.EnterText(By.XPath("//input[@id='pswd']"),"Australia198@");
            SeleniumHelper.EnterText(By.XPath("//input[@id='pswd-rpt']"), "Australia198@");
            //SeleniumHelper.EnterText(By.Id("pswd-rpt"), "Abcd1234");
            SeleniumHelper.Clickbtn(By.XPath("//button[@type='submit'][@class='btn btn-primary-bxt pull-right']"));

        }
        public void AccountLogin()
        {
            SeleniumHelper.NavigateToURL(ObjectRepository.Config.GetAccountLoginLink());
            Thread.Sleep(3000);
            SeleniumHelper.EnterText(By.XPath("//input[@id='username']"), "fukhan389@hotmail.com");
            SeleniumHelper.Clickbtn(By.XPath("//button[@id='bx-continue']"));

        }
    }
}
