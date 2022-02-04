Feature: Using the account
In order to surprise friends with interesting facts
As a user
I want to have opportunity to read some information about the products

    Background:
        Given user on the website homepage
        When user click on the login button
        And user enter 'exampletest@ua.fm' in the email field
        And user enter 'Example55&' in the password field
        And user click the confirmation button
        
    @mytag
    Scenario: Reading comments about linen urbech
        When user click on 'Урбеч сырой из коричневого льна' link
        And user scroll to the 'Отзывы клиентов московского магазина:' link
        Then user sees the comments
        
    Scenario: Reading the interesting information about roasted peanuts
        When user type 'арахис жареный' in the search box
        And user press Enter button
        And user click on the first product
        Then user see the 'Полезная тайна об арахисе' text
        
    Scenario: Adding products to the shopping cart
        When user click 'Полезные сладости' linked text
        And user click on 'Купить' button under ginger jam
        And user click on 'Купить' button under artichoke jam
        Then user see the shopping cart popup
        
        
    Scenario: Removing products from the shopping cart
        When user click 'Полезные сладости' linked text
        And user click on 'Купить' button under ginger jam
        And user click on 'Купить' button under artichoke jam
        And user hover mouse over the first product in the cart
        And user click the delete icon of the first product in the cart
        And user hover mouse over the second product in the cart
        And user click the delete icon of the second product in the cart
        Then user see the empty shopping cart