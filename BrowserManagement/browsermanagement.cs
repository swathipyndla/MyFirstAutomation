using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pageobjectmodelwithinputs.Global;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;


namespace pageobjectmodelwithinputs.BrowserManagement
{
    class browsermanagement
    {
        public static IWebDriver localdriver = Driver.driver;
        public static ExtentReports report;
        public static ExtentTest test;
        

        public static void openbrowser()
        {
            localdriver = new ChromeDriver();

            localdriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");


            //report initialization
            report = new ExtentReports("C:/Users/srikanth/source/repos/pageobjectmodelwithinputs/pageobjectmodelwithinputs/Report/reportpage.html", false, DisplayOrder.OldestFirst);
            report.LoadConfig("C:/Users/srikanth/source/repos/pageobjectmodelwithinputs/pageobjectmoelframeworkwithinputs/Report/Reportconfig.xml");

        }
        public static void closingbrowser()
        {
            report.EndTest(test);
            report.Flush();
            localdriver.Close();
        }
    }
}
