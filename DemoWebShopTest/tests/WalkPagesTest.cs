using DemoWebShopFramework;
using DemoWebShopTest.tests;
using NUnit.Framework;

namespace DemoWebShopTest
{
    [TestFixture]
    public class WalkPagesTest : TestBase
    {   

        [Test]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [Test]
        public void Can_Go_To_�ategory_Page_Books()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.Select�ategory("Books");
            Assert.IsTrue(Pages.HomePage.IsAt�ategoryPage("Books"));
        }

        [Test]
        public void Can_Go_To_�ategory_Page_Jewelry()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.Select�ategory("Jewelry");
            Assert.IsTrue(Pages.HomePage.IsAt�ategoryPage("Jewelry"));
        }

    }
}