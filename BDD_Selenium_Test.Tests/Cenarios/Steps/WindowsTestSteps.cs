using System;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;
using Xunit;

namespace BDD_Selenium_Test.Tests.Cenarios.Steps
{
    [Binding]
    public class WindowsTestSteps
    {
        [Given(@"estou num computador com Windows")]
        public void DadoEstouNumComputadorComWindows()
        {
            var os = Environment.OSVersion.Platform.ToString();
            Assert.StartsWith(os.Substring(0, 3).ToLower(), "win");
        }
        
        [When(@"for um horário múltiplo de (.*)")]
        public void QuandoForUmHorarioMultiploDe(int p0)
        {
            Assert.True(DateTime.Now.Minute % 5 == 0);
        }
        
        [Then(@"abrir o notepad")]
        public void EntaoAbrirONotepad()
        {
            var notepadPath = Environment.SystemDirectory + "\\notepad.exe";
            Application application = Application.Launch(notepadPath);
            Window window = application.GetWindow("bar", InitializeOption.NoCache);
        }
        
        [Then(@"Digitar")]
        public void EntaoDigitar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"salvar arquivo na área de trabalho")]
        public void EntaoSalvarArquivoNaAreaDeTrabalho()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
