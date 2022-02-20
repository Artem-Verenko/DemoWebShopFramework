using DemoWebShopFramework;
using NUnit.Framework;

namespace DemoWebShopTest.tests
{
    [TestFixture]   
    internal class UserLifeCycleTest:TestBase
    {
        [Test]
        [Ignore("user already exists")]
        public void Register_new_user()
        {
            Pages.HomePage.Goto();
            //Pages.HomePage.Register().NewRegister("Artem", "Verenko", "artem@gmail.com", "1234561", "1234561");
            Pages.HomePage.Register().setFirstName("Artem").setLastName("Verenko")
                .setEmail("artem@gmail.com").setPassword("123456").setConfirmPassword("123456").finishRegistration();
            Assert.AreEqual("artem@gmail.com", Pages.HomePage.GetCurrentLogin());
        }

        [Test]
        public void LogIn_user()
        {
            Pages.LogInPage.Goto();
            Pages.LogInPage.NewLogIn("artem@gmail.com", "1234561");
            Assert.AreEqual("artem@gmail.com", Pages.HomePage.GetCurrentLogin());
        }
    }
}
//Assert.AreEqual()