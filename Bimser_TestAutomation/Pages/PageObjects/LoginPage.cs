using Bimser_TestAutomation.Pages.PageComponents;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Bimser_TestAutomation.Pages.PageObjects
{
    public class LoginPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//p[text()='Giriş Yap']")]
        private IWebElement signInTo;
        [FindsBy(How = How.Id, Using = "login-email")]
        private IWebElement email;
        [FindsBy(How = How.Id, Using = "login-password-input")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement loginBtn;


        public LoginPage(IWebDriver driver) : base(driver) { }

        // Kullanıcı girişi yapılır.
        public void login(string mail, string pass)
        {
            signInTo.Click();
            Thread.Sleep(1000);
            email.SendKeys(mail);
            password.SendKeys(pass);
            loginBtn.Click();

        }


    }
}
