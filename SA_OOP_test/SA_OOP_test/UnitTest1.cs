using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class UntitledTestCase
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            var option = new ChromeOptions()
            {
                BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe"
            };

            //option.AddArgument("--headless");
            driver = new ChromeDriver(option);            
            //driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44393/");
            driver.FindElement(By.Id("navbarDropdown")).Click();
            driver.FindElement(By.LinkText("Cadastrar Paciente")).Click();
            driver.FindElement(By.LinkText("Cadastrar novo Paciente")).Click();
            driver.FindElement(By.Id("Nome")).Click();
            driver.FindElement(By.Id("Nome")).Clear();
            driver.FindElement(By.Id("Nome")).SendKeys("Pedr#$o Augusto");
            driver.FindElement(By.Id("CEP")).Clear();
            driver.FindElement(By.Id("CEP")).SendKeys("31030430");
            driver.FindElement(By.Id("Numero")).Clear();
            driver.FindElement(By.Id("Numero")).SendKeys("500");
            driver.FindElement(By.Id("Complemento")).Clear();
            driver.FindElement(By.Id("Complemento")).SendKeys("casa");
            driver.FindElement(By.Id("CPF")).Clear();
            driver.FindElement(By.Id("CPF")).SendKeys("123.900.432-90");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("gabirl@hotmail.com");
            driver.FindElement(By.Id("Telefone")).Clear();
            driver.FindElement(By.Id("Telefone")).SendKeys("(31) 96543-0976");
            driver.FindElement(By.XPath("//input[@value='Create']")).Click();

            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot screenshot = camera.GetScreenshot();
            screenshot.SaveAsFile($"{Guid.NewGuid()}.png");

            Assert.IsNotNull(driver.FindElement(By.XPath("//h1[contains(text(),'Pacientes Cadastrados')]")));      
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
