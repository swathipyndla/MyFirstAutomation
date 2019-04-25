using NUnit.Framework;
using pageobjectmodelwithinputs.BrowserManagement;
using pageobjectmodelwithinputs.WebPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageobjectmodelwithinputs.TestController
{
    class testcases
    {

        [SetUp]
        public void SetupMethod()
        {
            browsermanagement.openbrowser();
        }
        [Test]
        public void TestCase001Login()
        {
            login.loginmethod();
            try
            {

                browsermanagement.test = browsermanagement.report.StartTest("Test Login");
                Assert.AreEqual("Dashboard - Dispatching System", login.localdriver.Title);
                //Console.WriteLine("Successful Login");
                browsermanagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Login is not successful" + ex.InnerException);
                browsermanagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Failure");
            }

        }


        [Test]
        //Adding new customer
        public void AddingNewCustomer()
        {
            login.loginmethod();
            customer.customeraction();
            
        }
        [TearDown]
        public void EndMyTest()
        {
           // browsermanagement.closingbrowser();
        }

    }

}