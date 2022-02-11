using DemoWebShopFramework;
using NUnit.Framework;
using System.Threading;

namespace DemoWebShopTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [Test]
        public void Can_Go_To_—ategory_Page()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.Select—ategory("Books");
            Assert.IsTrue(Pages.HomePage.IsAt—ategoryPage("Books"));
        }

        [Test]
        public void Register_new_user()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.Register().NewRegister("Artem", "Verenko", "artem@gmail.com", "1234561", "1234561");
            Assert.IsTrue(Pages.HomePage.IsAtCurrentLogin("artem@gmail.com"));
        }

        [Test]
        public void LogIn_user()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.LogIn().NewLogIn("artem@gmail.com", "1234561");          
            Assert.IsTrue(Pages.HomePage.IsAtCurrentLogin("artem@gmail.com"));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Browser.Close();
        }
    }
}