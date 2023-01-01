using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjetoTesteGoogle
{
    public class Inicio
    {
        //instanciar o IWebDriver
        public IWebDriver driver;
        public bool driverQuit = true;

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            //para deixar em full screen
            driver.Manage().Window.Maximize();
            //Definir um tempo para dar timeout
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverQuit = false;
        }

        


        [TearDown]
        public void FimDoTeste()
        {

        }

    }
}
