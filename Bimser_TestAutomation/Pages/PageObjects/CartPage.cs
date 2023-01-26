using Bimser_TestAutomation.Pages.PageComponents;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Bimser_TestAutomation.Pages.PageObjects
{
    public class CartPage : BasePage
    {

        Actions action;

        [FindsBy(How = How.CssSelector, Using = ".pb-basket-item-price")]
        public IWebElement price;
        [FindsBy(How = How.XPath, Using = "//p[text()='Hesabım']")]
        private IWebElement myAccountBtn;
        [FindsBy(How = How.XPath, Using = "//p[text()='Çıkış Yap']")]
        private IWebElement signOutBtn;
        [FindsBy(How = How.XPath, Using = "//p[text()='Giriş Yap']")]
        public IWebElement signInBtn;

        public CartPage(IWebDriver driver) : base(driver)
        {
            action = new Actions(driver);
        }

        public string getProductPrice()
        {
            return price.Text;
        }

        // Kullanıcı çıkışı yapılır.
        public void logOut()
        {
            Thread.Sleep(1000);
            action.MoveToElement(myAccountBtn);
            action.Perform();
            signOutBtn.Click();
            Thread.Sleep(1000);
        }
    }
}
