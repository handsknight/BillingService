using Billing.Core;
using NUnit.Framework;

namespace Billing.Test
{
    public class Tests
    {
        private BillingService _billingService;
        private IBillingRepository _billingRepository;

        [SetUp]
        public void Setup()
        {
            _billingService = new BillingService(_billingRepository);
        }

        /// <summary>
        /// first band 
        /// </summary>
        /// <param name="value"></param>
        [TestCase(4999)]
        public void Test1(int value)
        {
            var expectedResult = 25;

            var result = _billingService.CountBand(value);

            Assert.AreEqual(result, expectedResult);
            //Assert.Pass();
        }

        /// <summary>
        /// first band 
        /// </summary>
        /// <param name="value"></param>
        [TestCase(500)]
        public void Test2(int value)
        {
            var expectedResult = 5;

            var result = _billingService.CountBand(value);

            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Second band 
        /// </summary>
        /// <param name="value"></param>
        [TestCase(1000001)]
        public void Test3(int value)
        {
            var expectedResult = 4204.2;

            var result = _billingService.CountBand(value);

            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Second band 
        /// </summary>
        /// <param name="value"></param>
        [TestCase(10000000)]
        public void Test4(int value)
        {
            var expectedResult = 42000;

            var result = _billingService.CountBand(value);

            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Third band 
        /// </summary>
        /// <param name="value"></param>
        [TestCase(10000001)]
        public void Test5(int value)
        {
            var expectedResult = 35003.5;

            var result = _billingService.CountBand(value);

            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Third band 
        /// </summary>
        /// <param name="value"></param>
        [TestCase(100000000)]
        public void Test6(int value)
        {
            var expectedResult = 350000;

            var result = _billingService.CountBand(value);

            Assert.AreEqual(result, expectedResult);
        }
    }
}