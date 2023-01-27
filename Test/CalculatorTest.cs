namespace Test
{
    public class CalculatorTest
    {
        double value;

        [SetUp]
        public void Setup()
        {
            value = 4;
        }

        [Test]
        public void TestFactorial()
        {
            double factor = new Edesoft.Business.CalculatorBusiness(value, out string message).Factorial(value);
            Assert.That(factor, Is.EqualTo(24));
        }
    }
}