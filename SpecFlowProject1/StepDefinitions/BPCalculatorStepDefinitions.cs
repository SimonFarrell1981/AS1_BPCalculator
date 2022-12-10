using BPCalculator;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BPCalculatorStepDefinitions
    {
        BloodPressure BPCalculator = new BloodPressure();
        [Given(@"the diastolic value is (.*)")]
        public void GivenTheDiastolicValueIs(int p0)
        {
            BPCalculator.Systolic = p0;
            Console.WriteLine("systolic: ", p0);
        }

        [Given(@"the systolic value is (.*)")]
        public void GivenTheSystolicValueIs(int p1)
        {
           
        }

        [When(@"the blood pressure catagory is calculated")]
        public void WhenTheBloodPressureCatagoryIsCalculated()
        {
            
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string input)
        {
            Console.WriteLine("tt");
        }
    }
}
