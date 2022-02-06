using OpenQA;
using OpenQA.Selenium;
using SpecFlowLastChance;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowLastChance
{
    [Binding]
    public class UsingAccountSteps : BaseTest
    {
      // Шаги Background.
        [Given(@"user on the homepage")]
        public void GivenUserOnTheHomepage()
        {
           StartDriverWithURL("http://dnepr.i-mne.com/");
        }

        [When(@"user click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            IWebElement enterBtn = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterBtn.Click();
        }
        
        // По сценарию регистрации нового пользователя. 
         [When(@"user click on registration button")]
        public void GivenUserClickOnRegistrationButton()
        {
            IWebElement registrationBtn = DriverHolder.driver.FindElement(By.LinkText("Регистрация"));
            registrationBtn.Click();
        }

        [When(@"user enter the '(.*)' in name field")]
        public void WhenUserEnterTheInNameField(string p0)
        {
            IWebElement nameElement = DriverHolder.driver.FindElement(By.Id("customer_firstname"));
            nameElement.SendKeys("Example");
        }

        [When(@"user enter the '(.*)' in surname field")]
        public void WhenUserEnterTheInSurnameField(string p0)
        {
            IWebElement surnameElement = DriverHolder.driver.FindElement(By.Id("customer_lastname"));
            surnameElement.SendKeys("ExampleSecond");
        }

        [When(@"user enter the '(.*)' in phonenumber field")]
        public void WhenUserEnterTheInPhonenumberField(string p0)
        {
            IWebElement phoneElement = DriverHolder.driver.FindElement(By.Id("phone_mobile"));
            phoneElement.SendKeys("+380931111112");
        }

        [When(@"user enter the '(.*)' in email field")]
        public void WhenUserEnterTheInEmailField(string p0)
        {
            IWebElement emailElement = DriverHolder.driver.FindElement(By.Id("email"));
            emailElement.SendKeys("exampletest9@ua.fm");
        }

        [When(@"user enter the '(.*)' in password field")]
        public void WhenUserEnterTheInPasswordField(string p0)
        {
            IWebElement passwordElement = DriverHolder.driver.FindElement(By.Id("passwd"));
            passwordElement.SendKeys("Example55&");
        }

        [When(@"user click on registration confirmation button")]
        public void WhenUserClickOnRegistrationConfirmationButton()
        {
            IWebElement submittBtn = DriverHolder.driver.FindElement(By.Id("submitAccount"));
            submittBtn.Click();
        }


        [When(@"user click on his name link in the upper right corner")]
        public void WhenUserClickOnHisNameLinkInTheUpperRightCorner()
        {
            IWebElement accountElement = DriverHolder.driver.FindElement(By.LinkText("Example ExampleSecond"));
            accountElement.Click();
        }

        [Then(@"user sees the account page")]
        public void ThenUserSeesTheAccountPage()
        {
            IWebElement accountTextElement = DriverHolder.driver.FindElement(By.XPath("//main/div/div/p"));
            string actual = accountTextElement.Text;
            Assert.Equal("Example, добро пожаловать в ваш профиль на сайте И-МНЕ Днепр!", actual);
        }

        // Отработка сценария авторизации.
        [When(@"user enter the '(.*)' in the email field")]
        public void WhenUserEnterTheInTheEmailField(string p0)
        {
            IWebElement emailFieldElement = DriverHolder.driver.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("exampletest@ua.fm");
        }


        [When(@"user enter the '(.*)' in the password field")]
        public void WhenUserEnterTheInThePasswordField(string p0)
        {
            IWebElement passwordFieldElement = DriverHolder.driver.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Example55&");
        }

        [When(@"user click on the confirmation button")]
        public void WhenUserClickOnTheConfirmationButton()
        {
            IWebElement submitBtn = DriverHolder.driver.FindElement(By.Id("SubmitLogin_ajax"));
            submitBtn.Click();
        }

        [Then(@"user see the account page")]
        public void ThenUserSeeTheAccountPage()
        {
            IWebElement accountTextElement = DriverHolder.driver.FindElement(By.XPath("//div/span[2]"));
            string actual = accountTextElement.Text;
            Assert.Equal("Мой аккаунт", actual);
        }
        
        // Сценарий добавления нового адреса в аккаунт
        [When(@"user click on '(.*)' element")]
        public void WhenUserClickOnElement(string p0)
        {
            IWebElement myAdressElement = DriverHolder.driver.FindElement(By.LinkText("Мои адреса"));
            myAdressElement.Click(); 
        }
        
        [When(@"user click on the '(.*)' element")]
        public void WhenUserClickOnTheElement(string p0)
        {
            IWebElement addNewAdressElement = DriverHolder.driver.FindElement(By.LinkText("Добавить адрес"));
            addNewAdressElement.Click();
        }

        [When(@"user input '(.*)' in phonenumber field")]
        public void WhenUserInputInPhonenumberField(string p0)
        {
            IWebElement phoneElement = DriverHolder.driver.FindElement(By.Id("phone_mobile"));
            phoneElement.SendKeys("+380931111112");
        }

        [When(@"user click on submition button")]
        public void WhenUserClickOnSubmitionButton()
        {
            IWebElement submittAdressElement = DriverHolder.driver.FindElement(By.Id("submitAddress"));
            submittAdressElement.Click();
        }

        [Then(@"user see new address")]
        public void ThenUserSeeNewAddress()
        {
            IWebElement addressTextElement = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/h4"));
            string actual = addressTextElement.Text;
            Assert.Equal("Адрес 1", actual);
        }

         // По сценарию выхода из аккаунта.
         [When(@"user click on '(.*)' linked text")]
        public void WhenUserClickOnLinkedText(string p0)
        {
            IWebElement submitBtn = DriverHolder.driver.FindElement(By.LinkText("Мои заказы"));
            submitBtn.Click();
        }

        [When(@"user click on thr '(.*)' linked text")]
        public void WhenUserClicksOnThrLinkedText(string p0)
        {
            IWebElement logoutElement = DriverHolder.driver.FindElement(By.LinkText("Выход"));
            logoutElement.Click(); 
        }
        
        [Then(@"user see '(.*)' linked text in upper right corner")]
        public void ThenUserSeeLinkedTextInUpperRightCorner(string p0)
        {
            IWebElement inputTextElement = DriverHolder.driver.FindElement(By.LinkText("Вход"));
            string actual = inputTextElement.Text;
            Assert.Equal("Вход", actual);
        }
    }
        
}  
