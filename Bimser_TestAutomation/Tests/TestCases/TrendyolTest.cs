using Bimser_TestAutomation.Tests.TestComponents;

namespace Bimser_TestAutomation.Tests.TestCases
{
    
    public class TrendyolTest : BaseTest
    {

        [Test(Description ="This method verifies that the main logo appears."), Order(1)]
        public void verifyLogo()
        {
            Assert.True(hp.mainLogo.Displayed); 
        }

        [Test(Description = "This method verifies successful login."), Order(2)]
        public void verifySuccessfulLogin()
        {
            lp.login("apiitestt@gmail.com", "1234567890x");
            hp.moveToAccount();
            Assert.That(hp.emailName.Text.ToLower, Is.EqualTo("apiitestt@gmail.com"));
        }

        [Test(Description = "This method verifies that the correct product has been purchased."), Order(3)]
        public void verifyProduct()
        {
            hp.searchProduct("laptop");
            pp.selectProduct();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string priceInProductPage = pp.getProductPrice();
            pp.goToCart();
            string priceInCart = cp.getProductPrice();
            Assert.That(priceInCart, Is.EqualTo(priceInProductPage));
        }

        [Test(Description = "This method verifies successful logout."), Order(4)]
        public void verifySuccessfulLogOut()
        {
            cp.logOut();
            Assert.IsTrue(cp.signInBtn.Displayed);
        }
    }
}
