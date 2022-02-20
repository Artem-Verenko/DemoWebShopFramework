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
            Assert.AreEqual("Demo Web Shop", Pages.HomePage.GetTitlePage());
        }

        [Test]
        public void Can_Go_To_Ñategory_Page_Books()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectÑategory("Books");
            Assert.AreEqual("Demo Web Shop. Books", Pages.HomePage.GetTitlePage());           
        }

        [Test]
        public void Can_Go_To_Ñategory_Page_Jewelry()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectÑategory("Jewelry");
            Assert.AreEqual("Demo Web Shop. Jewelry", Pages.HomePage.GetTitlePage());            
        }

    }
}