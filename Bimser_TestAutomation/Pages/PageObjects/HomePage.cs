using Bimser_TestAutomation.Pages.PageComponents;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Bimser_TestAutomation.Pages.PageObjects
{
    public class HomePage : BasePage
    {

        Actions action;

        [FindsBy(How = How.Id, Using = "Group-38")]
        private IWebElement popUp;
        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement mainLogo;
        [FindsBy(How = How.XPath, Using = "//p[text()='Hesabım']")]
        private IWebElement myAccount;
        [FindsBy(How = How.CssSelector, Using = ".user-name")]
        public IWebElement emailName;
        [FindsBy(How = How.XPath, Using = "//input[@data-testid='suggestion']")]
        private IWebElement writeProductName;
        [FindsBy(How = How.XPath, Using = "//i[@data-testid='search-icon']")]
        private IWebElement searchBtn;


        public HomePage(IWebDriver driver) : base(driver)
        {
            action = new Actions(driver);
        }

        // Sayfanın ilk açılışında çıkan bilgilendirme ekranını kapatır.
        public void closePopUp()
        {
            popUp.Click();
        }

        // 'Hesabım' sekmesinin üzerine gider, tıklamadan bekler.
        public void moveToAccount()
        {
            Thread.Sleep(1000);
            action.MoveToElement(myAccount);
            action.Perform();
        }

        // Ürün arama.
        public void searchProduct(string product)
        {
            Thread.Sleep(1000);
            writeProductName.SendKeys(product);
            searchBtn.Click();
        }

    }
}
