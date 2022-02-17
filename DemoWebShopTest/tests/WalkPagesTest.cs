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
        public void Can_Go_To_Ñategory_Page_Books()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectÑategory("Books");
            Assert.IsTrue(Pages.HomePage.IsAtÑategoryPage("Books"));
        }

        [Test]
        public void Can_Go_To_Ñategory_Page_Jewelry()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectÑategory("Jewelry");
            Assert.IsTrue(Pages.HomePage.IsAtÑategoryPage("Jewelry"));
        }

    }
}