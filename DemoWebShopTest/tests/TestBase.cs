using DemoWebShopFramework;
using NUnit.Framework;

namespace DemoWebShopTest.tests
{
    [TestFixture]
    public class TestBase
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Browser.Init();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Browser.Close();
        }

    }
}
