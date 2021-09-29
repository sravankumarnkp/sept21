using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace firstautotest.Pages
{
    class HomePage
    {
        public void gotoHomePage(IWebDriver driver)
        {
            IWebElement adminstration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstration.Click();

            //select the  ""Time and meterial drop downlist
            IWebElement timeAndMetDropbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMetDropbox.Click();

        }
    }
}
