
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TestProjectAdiquirirUmLivro.Helpers;
using Xunit;

namespace TestProjectAdiquirirUmLivro
{
    public class AoNavegarParaHomer
    {
        CriaPDF pdf = new CriaPDF();



        [Fact]
        public void DadoChromeAbertoDeveMostrarToolsQA()
        {
            //arrange
            IWebDriver driver = new ChromeDriver
                (TestHelper.PastaDoExecutavel);

            //ast
            driver.Navigate().GoToUrl("https://demoqa.com/books");

            //assert
            Assert.Contains("ToolsQA", driver.Title);
        }


        [Fact]
        public void DadoChomeAbertoDeveMostrarRegister()
        {
            //arrange
            IWebDriver driver = new ChromeDriver
              (TestHelper.PastaDoExecutavel);

            //act
            driver.Navigate().GoToUrl("https://demoqa.com/register");


           // pdf.GerarPdf;

            // ITakesScreenshot selenium C# como fazer

            driver.FindElement(By.XPath("//input[@id='firstname']")).SendKeys("Miguel");
            driver.FindElement(By.XPath("//input[@id='lastname']")).SendKeys("Sales");
            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("MiguelSales");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("@Rs564125");

            IWebElement frame = driver.FindElement(By.XPath("//iframe[@title='reCAPTCHA']"));
            driver.SwitchTo().Frame(frame);

            IJavaScriptExecutor descerTela = (IJavaScriptExecutor)driver;

            IWebElement confirmarCaptcha = driver.FindElement(By.XPath("//div[@class='recaptcha-checkbox-border']"));
            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", confirmarCaptcha);
            descerTela.ExecuteScript("arguments[0].click();", confirmarCaptcha);

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(30 * 1000);
            driver.FindElement(By.XPath("//button[@id='register']")).Click();

            //assert
            //Assert.Contains("ToolQA", driver.Title);


            driver.Quit();
        }

        private ITakesScreenshot getDriver()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void DadoChromeAbertoDeveMostrarBookStoreNaPagina()
        {
            //arrange
            IWebDriver driver = new ChromeDriver
                (TestHelper.PastaDoExecutavel);

            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Teste01");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("@Rs564125");

            IJavaScriptExecutor descerTela = (IJavaScriptExecutor)driver;

            IWebElement botaoLogin = driver.FindElement(By.XPath("//button[@id='login']"));
            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", botaoLogin);
            botaoLogin.Click();

            Thread.Sleep(5000);

            //ast
            driver.Navigate().GoToUrl("https://demoqa.com/books");
            driver.FindElement(By.XPath("//input[@autocomplete='off']")).SendKeys("Git Pocket Guide");
            driver.FindElement(By.XPath("//a[@href='/books?book=9781449325862']")).Click();
            IWebElement botaoAdicionar = driver.FindElement(By.XPath("//button[@id='addNewRecordButton']"));

            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", botaoAdicionar);
            descerTela.ExecuteScript("arguments[0].click();", botaoAdicionar);


            //assert
            Assert.Contains("Book Store", driver.PageSource);


            driver.Quit();
        }

        [Fact]
        public void DadoChromeAbertoDeveEscolherUmLivro()
        {

            //arrange
            IWebDriver driver = new ChromeDriver
              (TestHelper.PastaDoExecutavel);

            //act
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Teste01");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("@Rs564125");

            IJavaScriptExecutor descerTela = (IJavaScriptExecutor)driver;

            IWebElement botaoLogin = driver.FindElement(By.XPath("//button[@id='login']"));
            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", botaoLogin);
            botaoLogin.Click();

            Thread.Sleep(5000);

            IWebElement GoToBookStore = driver.FindElement(By.XPath("//button[@id='gotoStore']"));
            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", GoToBookStore);
            GoToBookStore.Click();

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Git Pocket Guide");
            driver.FindElement(By.XPath("//a[contains(text(),'Git Pocket Guide')]")).Click();


            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            IWebElement AddNewRecordButton = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'Add To Your Collection')]")));

            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", AddNewRecordButton);

            AddNewRecordButton.Click();

            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.XPath("//span[contains(text(),'Profile')]")).Click();

            Thread.Sleep(3000);

            //logica para remover

            IWebElement botaoDeleteAllBooks = driver.FindElement(By.XPath("//button[contains(text(),'Delete All Books')]"));
            descerTela.ExecuteScript("arguments[0].scrollIntoView(true);", botaoDeleteAllBooks);
            botaoDeleteAllBooks.Click();

            IWebElement botaoOK = driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']"));
            botaoOK.Click();

            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();

            //assert
            Assert.Contains("No rows found", driver.PageSource);


            //driver.Quit();




        }



    }

    //private class 
}
