using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject4.StepDefinitions
{
    [Binding]
    public class BPCalculatorStepDefinitions
    {
        [Given(@"the diastolic value is (.*)")]
        public void GivenTheDiastolicValueIs(int p0)
        {
            Console.WriteLine("test");
        }

        [Given(@"the systolic value is (.*)")]
        public void GivenTheSystolicValueIs(int p0)
        {
           // throw new PendingStepException();
        }

        [When(@"the blood pressure catagory is calculated")]
        public void WhenTheBloodPressureCatagoryIsCalculated()
        {
            //throw new PendingStepException();
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string low)
        {
            //throw new PendingStepException();
            Console.WriteLine("Result", low);
        }
    }
}
