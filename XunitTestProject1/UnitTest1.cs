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
        [Fact]
        public void IdealTest()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic = 60;
            BPCalculator.Systolic = 90;
            //Assert
            Assert.Equal(BPCategory.Ideal, BPCalculator.Category);
            //Act
            BPCalculator.Diastolic = 70;
            BPCalculator.Systolic = 110;
            //Assert
            Assert.Equal(BPCategory.Ideal, BPCalculator.Category);
        }
        [Fact]
        public void PreHighTest()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic = 80;
            BPCalculator.Systolic = 120;
            //Assert
            Assert.Equal(BPCategory.PreHigh, BPCalculator.Category);
            //Act
            BPCalculator.Diastolic = 85;
            BPCalculator.Systolic = 130;
            //Assert
            Assert.Equal(BPCategory.PreHigh, BPCalculator.Category);
        }
        [Fact]
        public void HighTest()
        {
            //Arrange
            var BPCalculator = new BloodPressure();
            //Act
            BPCalculator.Diastolic = 90;
            BPCalculator.Systolic = 140;
            //Assert
            Assert.Equal(BPCategory.High, BPCalculator.Category);
            BPCalculator.Diastolic = 100;
            BPCalculator.Systolic = 190;
            //Assert
            Assert.Equal(BPCategory.High, BPCalculator.Category);
        }
    }
}
