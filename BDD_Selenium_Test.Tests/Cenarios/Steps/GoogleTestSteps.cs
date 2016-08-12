using BDD_Selenium_Test.Tests.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD_Selenium_Test.Tests
{
    [Binding]
    public class GoogleTestSteps
    {
        IWebDriver driver;
        string url = "http://www.google.com.br";

        [Given(@"que tenho conexão com a Internet")]
        public void DadoQueTenhoConexaoComAInternet()
        {
            Assert.True(CheckInternetConnection.Check());
        }
        
        [Then(@"acessar o site do Google")]
        public void EntaoAcessarOSiteDoGoogle()
        {
            driver = new ChromeDriver(@"D:\Andre\dev\etc");
            driver.Navigate().GoToUrl(url);
        }
        
        [Then(@"pesquisar")]
        public void EntaoPesquisar(Table table)
        {
            string valorPesquisa = table.Rows[0][0];
            IWebElement inputPesquisa = driver.FindElement(By.Name("q"));
            inputPesquisa.SendKeys(valorPesquisa);
            inputPesquisa.SendKeys(Keys.Enter);
            //IWebElement btnPesquisa = driver.FindElement(By.Name("btnK"));
            //btnPesquisa.Click();
        }
        
        [Then(@"acessar o primeiro resultado")]
        public void EntaoAcessarOPrimeiroResultado()
        {
            IWebElement primeiroItem = driver.FindElement(By.CssSelector(".g .r a"));
            primeiroItem.Click();
        }
    }
}
