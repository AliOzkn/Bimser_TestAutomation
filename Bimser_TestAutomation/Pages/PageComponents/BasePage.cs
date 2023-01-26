using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Bimser_TestAutomation.Pages.PageComponents
{
    // PageFactory ve webDriver'ı başlatan sınıf.
    public class BasePage
    {
        public static IWebDriver webDriver;

        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
