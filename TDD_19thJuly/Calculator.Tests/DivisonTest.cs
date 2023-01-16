using NUnit.Framework;
using TDD_19thJuly;

namespace Calculator.Tests
{
    public class AdditionTest
    {
        public int Divide(int number1,int number2)
        {
            throw new NotImplememtedCustomException("Operation still has not done");
        }
        TDD_19thJuly.Calculator calculator = new TDD_19thJuly.Calculator();
        
        [Test]
        public void NotImplementedExceptionCheck()
        {
            var exception = Assert.Throws<NotImplememtedCustomException>(() => Divide(10,5), "Message: Operation Not Started");
            Assert.AreEqual(2, exception.Message);
        }
        
        [Test]
        [TestCase(15, -3, 5)]
        [TestCase(-15,5,3)]
        public void TestForNegativeValue(int number1, int number2, int expectedResult)
        {

            int actualResult = calculator.Divide(number1, number2);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        [TestCase(10, 0, 5)]
        public void TestForZeroDivisor(int number1, int number2, int expectedResult)
        {
            int actualResult = calculator.Divide(number1, number2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(10,2, 5)]
        public void BothValuesCorrect(int number1, int number2, int expectedResult)
        {
            int actualResult = calculator.Divide(number1, number2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}