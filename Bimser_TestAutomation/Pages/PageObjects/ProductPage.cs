using Bimser_TestAutomation.Pages.PageComponents;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Bimser_TestAutomation.Pages.PageObjects
{
    public class ProductPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='sort-fltr-cntnr']/select")]
        private IWebElement filterOptions;
        [FindsBy(How = How.XPath, Using = "//select/option[2]")]
        private IWebElement fromCheapToExpensive;
        [FindsBy(How = How.XPath, Using = "//div[@class='p-card-wrppr with-campaign-view'][1]")]
        private IWebElement firstProduct;
        [FindsBy(How = How.CssSelector, Using = ".product-price-container span")]
        public IWebElement price;
        [FindsBy(How = How.CssSelector, Using = ".add-to-basket")]
        private IWebElement addToCartBtn;
        [FindsBy(How = How.XPath, Using = "(//*[text()='Sepetim'])[1]")]
        private IWebElement goToCartBtn;


        public ProductPage(IWebDriver driver) : base(driver) { }

        // Ucuzdan pahalıya olarak filtreleme işlemi yapar.
        public void useFilter()
        {
            Thread.Sleep(1000);
            filterOptions.Click();
            fromCheapToExpensive.Click();
        }

        // Çıkan sonuçlardan ilk ürünü seçer.
        public void chooseProduct()
        {
            Thread.Sleep(1000);
            firstProduct.Click();
        }

        public void selectProduct()
        {
            useFilter();
            chooseProduct();
        }

        // Ürünü sepete ekler ve sepetim sayfasına gider.
        public void goToCart()
        {
            addToCartBtn.Click();
            Thread.Sleep(1000);
            goToCartBtn.Click();
        }

        public string getProductPrice()
        {
            return price.Text;
        }
    }
}
