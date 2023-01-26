using Bimser_TestAutomation.Pages.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace Bimser_TestAutomation.Tests.TestComponents
{
    [TestFixture]
    [AllureNUnit]
    [AllureFeature("Buying The Cheapest Product From E-Commerce Website")]

    public class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage hp;
        protected LoginPage lp;
        protected ProductPage pp;
        protected CartPage cp;


        [OneTimeSetUp]
        public void Setup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();     // Testi her çalıştırmada, önceki testten kalan, allure-results klasörü içindeki raporları siler.

            new DriverManager().SetUpDriver(new ChromeConfig());     // WebDriverManager ile fiziksel olarak chrome driver eklemeden, driver ayağa kaldırıldı.
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);   // Sayfanın yüklenmesi için zaman tanındı.
            driver.Navigate().GoToUrl("https://www.trendyol.com/");

            hp = new HomePage(driver);
            lp = new LoginPage(driver);
            pp = new ProductPage(driver);
            cp = new CartPage(driver);

            hp.closePopUp();

        }
        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
