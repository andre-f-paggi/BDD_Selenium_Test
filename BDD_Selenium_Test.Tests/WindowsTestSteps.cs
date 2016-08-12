using System;
using TechTalk.SpecFlow;

namespace BDD_Selenium_Test.Tests
{
    [Binding]
    public class WindowsTestSteps
    {
        [Given(@"que estou num computador com Windows(.*)")]
        public void DadoQueEstouNumComputadorComWindows(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
