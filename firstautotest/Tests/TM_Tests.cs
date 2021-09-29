using System;
using System.Threading;
using firstautotest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace firstautotest
{
	class TM_Tests
	{
		static void Main(string[] args)
		{
			//open the browser and maximise
			IWebDriver driver = new ChromeDriver();

			//create login page
			LoginPage lpobj = new LoginPage();
			lpobj.gotoLoginPage(driver);

			//create home page
			HomePage Hpobj = new HomePage();
			Hpobj.gotoHomePage(driver);
			//tm page
			TMPage tmobj = new TMPage();
			tmobj.createTM(driver);
			tmobj.editTM(driver);
			tmobj.deleteTM(driver);
			
		}
	}
}
