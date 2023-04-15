using NUnit.Framework;

namespace Prime.Services.Tests
{
    public class PrimeService_IsPrimeTest
    {
        private PrimeServices _primeServices;

        [SetUp]
        public void Setup()
        {
            _primeServices = new PrimeServices();
        }

        [Test]
        public void Test1()
        {
            var result = _primeServices.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }



        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void test2(int number)
        {
            var result = _primeServices.IsPrime(number);
            Assert.IsFalse(result, number + "should not be prime");
        }
    }
}