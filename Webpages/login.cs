using OpenQA.Selenium;
using pageobjectmodelwithinputs.BrowserManagement;
using pageobjectmodelwithinputs.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageobjectmodelwithinputs.WebPages
{
    class login
    {
        public static IWebDriver localdriver;
        public static void loginmethod()
        {
            localdriver = browsermanagement.localdriver;
            extensionmethods.UserInput(localdriver, "id", "UserName", logininputs.username);
            extensionmethods.UserInput(localdriver, "id", "Password", logininputs.password);
            extensionmethods.ButtonClick(localdriver, "Xpath", "//*[@id='loginForm']/form/div[3]/input[1]");

        }
    }
}