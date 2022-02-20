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
        public void Can_Go_To_�ategory_Page_Books()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.Select�ategory("Books");
            Assert.AreEqual("Demo Web Shop. Books", Pages.HomePage.GetTitlePage());           
        }

        [Test]
        public void Can_Go_To_�ategory_Page_Jewelry()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.Select�ategory("Jewelry");
            Assert.AreEqual("Demo Web Shop. Jewelry", Pages.HomePage.GetTitlePage());            
        }

    }
}