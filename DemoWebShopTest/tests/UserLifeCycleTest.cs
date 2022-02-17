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
                .setEmail("artem@gmail.com").setPassword("1234561").setConfirmPassword("1234561").finishRegistration();
            Assert.IsTrue(Pages.HomePage.IsAtCurrentLogin("artem@gmail.com"));
        }

        [Test]
        public void LogIn_user()
        {
            Pages.LogInPage.Goto();
            Pages.LogInPage.NewLogIn("artem@gmail.com", "1234561");
            Assert.IsTrue(Pages.HomePage.IsAtCurrentLogin("artem@gmail.com"));
        }
    }
}
