using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageobjectmodelwithinputs.BrowserManagement
{
    class extensionmethods

    {
        public static void UserInput(IWebDriver driver, string locatorType, string locatorValue,string textValue)
        {
            if(locatorType=="id")
            {
                driver.FindElement(By.Id(locatorValue)).SendKeys(textValue);

            }
            else if(locatorType=="Xpath")
                {

                driver.FindElement(By.XPath(locatorValue)).SendKeys(textValue);
            }
               
            }

        

        public static void ButtonClick(IWebDriver driver, string locatorType, string locatorValue)
        {
            if (locatorType == "id")
            {
                driver.FindElement(By.Id(locatorValue)).Click();

            }
            else if(locatorType == "Xpath")
                {

                driver.FindElement(By.XPath(locatorValue)).Click();
            }

        }

    }




}
