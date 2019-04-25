using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pageobjectmodelwithinputs.BrowserManagement;
using pageobjectmodelwithinputs.Inputs;

namespace pageobjectmodelwithinputs.WebPages
{
    class customer
    {
        public static IWebDriver localdriver = login.localdriver;
        public static void customeraction()
        {
           
           extensionmethods.ButtonClick(localdriver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/a");
            extensionmethods.ButtonClick(localdriver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a");
            extensionmethods.ButtonClick(localdriver, "Xpath", "//*[@id='container']/p/a");
            extensionmethods.UserInput(localdriver, "id", "Name", customerinputs.Name);
            extensionmethods.ButtonClick(localdriver, "id", "EditContactButton");
            localdriver.SwitchTo().Frame(0);
            extensionmethods.UserInput(localdriver, "id", "FirstName", customerinputs.Firstname);
            extensionmethods.UserInput(localdriver, "id", "LastName", customerinputs.Lastname);
            extensionmethods.UserInput(localdriver, "id", "Phone", customerinputs.Phone);
            extensionmethods.UserInput(localdriver, "id", "email", customerinputs.Email);
            extensionmethods.ButtonClick(localdriver, "id", "submitButton");
            localdriver.SwitchTo().DefaultContent();
            extensionmethods.UserInput(localdriver, "id", "GST", customerinputs.GST);
           // extensionmethods.ButtonClick(localdriver, "id", "submitButton");
            // localdriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            // localdriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();
            //localdriver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            // localdriver.FindElement(By.Id("EditContactButton")).Click();
            // localdriver.SwitchTo().Frame(0);
            //localdriver.FindElement(By.Id("FirstName")).SendKeys("nani");
            //localdriver.FindElement(By.Id("LastName")).SendKeys("saa");
            //localdriver.FindElement(By.Id("Phone")).SendKeys("123123");
            //localdriver.FindElement(By.Id("email")).SendKeys("saa@mail.com");
            //ocaldriver.FindElement(By.Id("autocomplete")).SendKeys("Melbourne");
            //localdriver.FindElement(By.Id("submitButton")).Click();
            // localdriver.SwitchTo().DefaultContent();
            //ocaldriver.FindElement(By.Name("IsSameContact")).Click();
            // localdriver.FindElement(By.Id("GST")).SendKeys("10");

            //ocaldriver.FindElement(By.Id("submitButton")).Click();
            //ocaldriver.FindElement(By.XPath("/html/body/div[3]/div/a")).Click();
            //localdriver.SwitchTo().DefaultContent();
        }
    }

}