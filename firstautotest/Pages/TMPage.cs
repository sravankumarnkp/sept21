using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace firstautotest.Pages
{
    class TMPage
    {
        public void createTM(IWebDriver driver)
        {
			//click on create new  button
			IWebElement createButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
			createButton.Click();
			Thread.Sleep(2000);
			//select the time from type code droplist
			IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
			typecodedropdown.Click();
			Thread.Sleep(5000);
			IWebElement timeselect = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
			timeselect.Click();


			//identify "code" textbox and input code
			IWebElement codeTBX = driver.FindElement(By.Id("Code"));
			codeTBX.SendKeys("sep2021");

			// identify the "descrtion" textbox and input description
			IWebElement desTextbox = driver.FindElement(By.Id("Description"));
			desTextbox.SendKeys("sept2021");
			//identify the "price" textbox and input the price
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
			IWebElement priceText = driver.FindElement(By.Id("Price"));
			priceText.SendKeys("25");
			//click on save button
			IWebElement saveBttn = driver.FindElement(By.Id("SaveButton"));
			saveBttn.Click();
			//check time and meterial cereated 
			Thread.Sleep(5000);
			IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
			lastpagebutton.Click();
			IWebElement chckelement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
			Console.WriteLine(chckelement.Text);
			if (chckelement.Text == "sep2021")
			{
				Console.WriteLine("data saved sucessfully test passed");
				

			}
			else { Console.WriteLine("data saved not sucessfully test failed"); }

		}
		public void editTM(IWebDriver driver)
        {
			IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
			lastpagebutton.Click();
			IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
			editbutton.Click();
			//edit description
			Thread.Sleep(5000);
			IWebElement nDs = driver.FindElement(By.Id("Description"));
			nDs.Clear();
			nDs.SendKeys("1newsept2023");
			//edit price
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
			//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
			//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
			IWebElement nPs = driver.FindElement(By.XPath("//*[@id='Price']"));
			nPs.Clear();
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

			nPs.SendKeys("54");
			//save
			driver.FindElement(By.Id("SaveButton")).Click();
			Console.WriteLine("data updated  sucessfully test passed");

		}
		public void deleteTM(IWebDriver driver)
        {
			//delete the data what is saved 


			Console.WriteLine("data deleted stated test ");


			Thread.Sleep(2000);
			//delete
			driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
			IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
			Thread.Sleep(2000);
			//*[@id="tmsGrid"]/div[3]/table/tbody/tr/td[5]/a[2]
			deletebutton.Click();
			driver.SwitchTo().Alert().Accept();
			Console.WriteLine("data deleted sucessfully ..... ");


		}
	}
}
