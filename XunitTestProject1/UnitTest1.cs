using BPCalculator;
using System;
using Xunit;

namespace XunitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void LowTest()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic=40;
            BPCalculator.Systolic = 70;
            //Assert
            Assert.Equal(BPCategory.Low, BPCalculator.Category);
            //Act
            BPCalculator.Diastolic = 50;
            BPCalculator.Systolic = 80;
            //Assert
            Assert.Equal(BPCategory.Low, BPCalculator.Category);
        }
        public void Test1()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic = 1;
            BPCalculator.Systolic = 1;
            //Assert
            Assert.Equal(BPCategory.High, BPCalculator.Category);
        }
        public void Test2()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic = 1;
            BPCalculator.Systolic = 1;
            //Assert
            Assert.Equal(BPCategory.High, BPCalculator.Category);
        }
        public void Test3()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic = 1;
            BPCalculator.Systolic = 1;
            //Assert
            Assert.Equal(BPCategory.High, BPCalculator.Category);
        }
    }
}
