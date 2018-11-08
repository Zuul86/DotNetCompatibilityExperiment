using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountryFlag.Tests
{
    [TestClass]
    public class FlagLoaderTests
    {
        [TestMethod]
        public void GetFlagUrlByCountryNameReturnsUSFlagUrl()
        {
            var flagLoader = new FlagLoader();

            var result = flagLoader.GetFlagUrlByCountryName("USA");

            Assert.AreEqual("https://www.countryflags.io/us/flat/64.png", result);
        }
    }
}
