using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Interactions;

namespace SpecFlowLastChance
{

    [Binding]
    public class ProductsActionsSteps : BaseTest
    {
        // Шаги Background.
        [Given(@"user on the website homepage")]
        public void GivenUserOnTheWebsiteHomepage()
        {
           StartDriverWithURL("http://dnepr.i-mne.com/");
        }


        [When(@"user click on the login button")]
        public void WhenUserClickOnTheLoginButton()
        {
            IWebElement enterBtn = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterBtn.Click();
        }

        [When(@"user enter '(.*)' in the email field")]
        public void WhenUserEnterInTheEmailField(string p0)
        {
            IWebElement emailFieldElement = DriverHolder.driver.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("exampletest@ua.fm");
        }

        [When(@"user enter '(.*)' in the password field")]
        public void WhenUserEnterInThePasswordField(string p0)
        {
            IWebElement passwordFieldElement = DriverHolder.driver.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Example55&");
        }

        [When(@"user click the confirmation button")]
        public void WhenUserClickTheConfirmationButton()
        {
            IWebElement submitBtn = DriverHolder.driver.FindElement(By.Id("SubmitLogin_ajax"));
            submitBtn.Click();
        }

        // По сценарию чтения комментариев.
        [When(@"user click on '(.*)' link")]
        public void WhenUserClickOnLink(string p0)
        {
            {
                IWebElement product1Element =
                    DriverHolder.driver.FindElement(By.LinkText("Урбеч сырой из коричневого льна,"));
                product1Element.Click();
            }
        }

        [When(@"user scroll to the '(.*)' link")]
        public void WhenUserScrollToTheLink(string p0)
        {
            var element = DriverHolder.driver.FindElement(By.XPath("//p[7]"));
            Actions actions = new Actions(DriverHolder.driver);
            actions.MoveToElement(element).Perform();
        }

        [Then(@"user sees the comments")]
        public void ThenUserSeesTheComments()
        {
            IWebElement textElement = DriverHolder.driver.FindElement(By.XPath("//em"));
            string actual = textElement.Text;
            Assert.Equal("Отзывы", actual);
        }

        // По сценарию чтения интересной информации.
        [When(@"user type '(.*)' in the search box")]
        public void WhenUserTypeInTheSearchBox(string p0)
        {
            IWebElement searchProductElement = DriverHolder.driver.FindElement(By.Id("search_query"));
            searchProductElement.SendKeys("арахис жареный");
        }

        [When(@"user press Enter button")]
        public void WhenUserPressButton()
        {
            IWebElement searchProductElement = DriverHolder.driver.FindElement(By.Id("search_query"));
            searchProductElement.SendKeys(Keys.Enter);
        }

        [When(@"user click on the first product")]
        public void WhenUserClickOnTheFirstProduct()
        {
            IWebElement productElement = DriverHolder.driver.FindElement(By.XPath("//div[3]/div/div/a"));
            productElement.Click();
        }

        [Then(@"user see the '(.*)' text")]
        public void ThenUserSeeTheText(string p0)
        {
            IWebElement textElement = DriverHolder.driver.FindElement(By.XPath("//strong"));
            string actual = textElement.Text;
            Assert.Equal("Полезная тайна об арахисе", actual);
        }

        // По сценарию добавления в корзину.
        [When(@"user click '(.*)' linked text")]
        public void WhenUserClickLinkedText(string p0)
        {
            IWebElement categoryElement = DriverHolder.driver.FindElement(By.LinkText("Полезные сладости"));
            categoryElement.Click();
        }

        [When(@"user click on '(.*)' button under ginger jam")]
        public void WhenUserClickOnButtonUnderGingerJam(string p0)
        {
            IWebElement product1Element = DriverHolder.driver.FindElement(By.XPath("//span/a/span"));
            product1Element.Click();
        }

        [When(@"user click on '(.*)' button under artichoke jam")]
        public void WhenUserClickOnButtonUnderArtichokeJam(string p0)
        {
            IWebElement product2Element = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/span/a/span"));
            product2Element.Click();
        }

        [Then(@"user see the shopping cart popup")]
        public void ThenUserSeeTheShoppingCartPopup()
        {
            IWebElement popupElement = DriverHolder.driver.FindElement(By.XPath("//div[7]/div[2]/h4"));
            string actual = popupElement.Text;
            Assert.Equal("Моя корзина №78912", actual);
        }

        // По сценарию удаления из корзины.
        [When(@"user hover mouse over the first product in the cart")]
        public void WhenUserHoverMouseOverTheFirstProductInTheCart()
        {
            Actions act = new Actions(DriverHolder.driver);
            IWebElement element1 = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/div/div/a[2]"));
            act.MoveToElement(element1).Perform();
        }

        [When(@"user click the delete icon of the first product in the cart")]
        public void WhenUserClickTheDeleteIconOfTheFirstProductInTheCart()
        {
            IWebElement product1DeleteElement = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/div/div/a[2]"));
            product1DeleteElement.Click();
        }

        [When(@"user hover mouse over the second product in the cart")]
        public void WhenUserHoverMouseOverTheSecondProductInTheCart()
        {
            Actions act = new Actions(DriverHolder.driver);
            IWebElement element2 = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/div/div/a[2]"));
            act.MoveToElement(element2).Perform();
        }

        [When(@"user click the delete icon of the second product in the cart")]
        public void WhenUserClickTheDeleteIconOfTheSecondProductInTheCart()
        {
            IWebElement product2DeleteElement = DriverHolder.driver.FindElement(By.XPath("//div[2]/div/div/div/a[2]"));
            product2DeleteElement.Click();
        }

        [Then(@"user see the empty shopping cart")]
        public void ThenUserSeeTheEmptyShoppingCart()
        {
            IWebElement emptyCartPopup = DriverHolder.driver.FindElement(By.XPath("//div[2]/div[2]/div[2]/span/b"));
            string actual = emptyCartPopup.Text;
            Assert.Equal("0 кг", actual);
        }
    }
}  
    

