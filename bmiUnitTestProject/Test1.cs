using BMICalculator;
namespace bmiUnitTestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(BMICategory.Normal, bmi.BMICategory);
        }


        [TestMethod]
        public void TestMethod2()
        {
            BMI bmi = new BMI() { WeightStones = 15, WeightPounds = 2, HeightFeet = 6, HeightInches = 0 };
            Assert.AreEqual(BMICategory.Overweight, bmi.BMICategory);
        }

        [TestMethod]
        public void TestMethod3()
        {
            BMI bmi = new BMI() { WeightStones = 16, WeightPounds = 2, HeightFeet = 6, HeightInches = 0 };
            Assert.AreEqual(BMICategory.Obese, bmi.BMICategory);
        }
    }
}
