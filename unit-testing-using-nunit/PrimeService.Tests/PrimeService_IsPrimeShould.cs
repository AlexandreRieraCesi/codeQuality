using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService? _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
#pragma warning disable CS8602 // D�r�f�rencement d'une �ventuelle r�f�rence null.
            var result = _primeService.IsPrime(1);
#pragma warning restore CS8602 // D�r�f�rencement d'une �ventuelle r�f�rence null.

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}