using BPCalculator;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class BPCalculatorStepDefinitions
    {
        BloodPressure BPCalculator = new BloodPressure();

        [Given(@"the diastolic value is (.*)")]
        public void GivenTheDiastolicValueIs(int p0)
        {
            BPCalculator.Diastolic = p0;
        }

        [Given(@"the systolic value is (.*)")]
        public void GivenTheSystolicValueIs(int p1)
        {
            BPCalculator.Systolic = p1;
            Console.WriteLine("systolic: ", p1);
        }

        [When(@"the blood pressure catagory is calculated")]
        public void WhenTheBloodPressureCatagoryIsCalculated()
        {
            Console.WriteLine("99input");
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string str)
        {
            Assert.Equal(str, BPCalculator.Category.ToString());
        }
    }
}
