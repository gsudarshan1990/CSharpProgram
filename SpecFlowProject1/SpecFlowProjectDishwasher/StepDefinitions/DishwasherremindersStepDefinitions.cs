namespace SpecFlowProjectDishwasher.StepDefinitions
{
    [Binding]
    public class DishwasherremindersStepDefinitions
    {
        [Given(@"The dishwasher is complete")]
        public void GivenTheDishwasherIsComplete()
        {
            throw new PendingStepException();
        }

        [Given(@"I have not acknowledge unloading it")]
        public void GivenIHaveNotAcknowledgeUnloadingIt()
        {
            throw new PendingStepException();
        }

        [Given(@"The last reminder was more than (.*) minutes ago")]
        public void GivenTheLastReminderWasMoreThanMinutesAgo(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"it was after (.*) AM")]
        public void GivenItWasAfterAM(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"there is motion in the kitchen")]
        public void WhenThereIsMotionInTheKitchen()
        {
            throw new PendingStepException();
        }

        [Then(@"my smart speaker announces it's done and prompts me if it has been unloaded and stores the acknowledgement\.a")]
        public void ThenMySmartSpeakerAnnouncesItsDoneAndPromptsMeIfItHasBeenUnloadedAndStoresTheAcknowledgement_A()
        {
            throw new PendingStepException();
        }

        [Given(@"it is before (.*) AM")]
        public void GivenItIsBeforeAM(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"there is no annoucement")]
        public void ThenThereIsNoAnnoucement()
        {
            throw new PendingStepException();
        }

    }
}
