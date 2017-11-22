using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Threading;

namespace TestesAutomatizado {

    [TestFixture]
    class Program {
        [Test]
        public void DeveCadastrarUsuario() {
            IWebDriver firefox = new FirefoxDriver();

            firefox.Navigate().GoToUrl("https://www.scytl.com/pt-br/visao-geral-da-empresa/");

            Thread.Sleep(1000);

            IWebElement buttonLearn = firefox.FindElement(By.ClassName("logo"));

            Thread.Sleep(1000);

            buttonLearn.Click();

            bool achouNome = firefox.PageSource.Contains("As soluções eleitorais da Scytl ganharam a confiança de organizações eleitorais públicas e privadas em todo o mundo.");

            firefox.Close();
            Assert.IsTrue(achouNome);

        }
    }
}
