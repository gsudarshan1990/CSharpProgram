using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectSerialization.StepDefinitions
{
    [Binding]
    public class BrowserstackStepDefinitions
    {
        [Given(@"I am on the Browserstack website")]
        public void GivenIAmOnTheBrowserstackWebsite()
        {
            throw new PendingStepException();
        }

        [When(@"I click the SpecFlow with selenium c\# blog")]
        public void WhenIClickTheSpecFlowWithSeleniumCBlog()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the SpecFlow tutorial page")]
        public void ThenIShouldSeeTheSpecFlowTutorialPage()
        {
            throw new PendingStepException();
        }
    }
}
