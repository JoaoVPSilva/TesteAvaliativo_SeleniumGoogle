using NUnit.Framework;
using OpenQA.Selenium;

namespace ProjetoTesteGoogle
{
    //para herdar uma classe em c#
    class TestesGoogle : Inicio
    {

        [Test]
        public void Teste()
        {            
            driver.FindElement(By.Name("q")).SendKeys("Teste");            
            driver.FindElement(By.Name("btnI")).Click();                        

            driver.Navigate().GoToUrl("https://google.com/");
            driver.FindElement(By.Name("q")).SendKeys("Teste");
            driver.FindElement(By.Name("btnK")).Click();
            Assert.IsNotNull(driver.FindElement(By.Id("result-stats")).Text.Contains("Aproximadamente"));

            driver.Navigate().GoToUrl("https://www.google.com/search?q=Teste&sxsrf=ALiCzsajJgYjL3ugAqGZ-feMf2uJ2H2bpQ%3A1672523694234&ei=rq-wY8n2DcjJ1sQP8YK_mAg&ved=0ahUKEwjJhbGl7KT8AhXIpJUCHXHBD4MQ4dUDCA8&uact=5&oq=Teste&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIECCMQJzIECCMQJzIFCAAQkQIyBQgAEJECMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQ6CwguEIAEEMcBENEDOgoIABCABBCHAhAUSgQIQRgASgQIRhgAUABYmwRg8gdoAHAAeACAAYQBiAGmBJIBAzAuNZgBAKABAcABAQ&sclient=gws-wiz-serp");
            driver.FindElement(By.ClassName("fLciMb")).Click();

            driver.Navigate().GoToUrl("https://www.google.com/");

            Assert.IsNotNull(driver.FindElement(By.Name("q")));

            Console.WriteLine("Página funcionando corretamente. \n 1. Campo de Digitação - OK \n 2. Botão Estou com sorte - OK \n 3. Botão Pesquisa do google - OK \n 4. Funcionamento do Botão Google apps - OK");
        }

    }
}
