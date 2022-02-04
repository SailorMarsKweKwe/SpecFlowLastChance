Feature: Using the account
   As a customer
   I want to have opportunity to filter the products
   In order to select the most suitable product for me
    
   Background:
        Given user on the homepage
        When user click on login button
        
    @mytag
    Scenario: Registration new user
        When user click on registration button
        And user enter the 'Example' in name field
        And user enter the 'ExampleSecond' in surname field
        And user enter the '+380931111112' in phonenumber field
        And user enter the 'exampletest9@ua.fm' in email field
        And user enter the 'Example55&' in password field
        And user click on registration confirmation button
        And user click on his name link in the upper right corner
        Then user sees the account page
        
    Scenario: Autorization existing user
        When user enter the 'exampletest@ua.fm' in the email field
        And user enter the 'Example55&' in the password field
        And user click on the confirmation button
        And user click on his name link in the upper right corner
        Then user see the account page
        
    Scenario: Adding new address in account
        When user enter the 'exampletest@ua.fm' in the email field
        And user enter the 'Example55&' in the password field
        And user click on the confirmation button
        And user click on his name link in the upper right corner
        And user click on 'Мои адреса' element
        And user click on the 'Добавить адрес' element
        And user input '+380931111112' in phonenumber field
        And user click on submition button
        Then user see new address
        
    Scenario: Logout
        When user enter the 'exampletest@ua.fm' in the email field
        And user enter the 'Example55&' in the password field
        And user click on the confirmation button
        And user click on his name link in the upper right corner
        And user click on 'Мои заказы' linked text
        And user click on his name link in the upper right corner
        And user click on thr 'Выход' linked text
        Then user see 'Вход' linked text in upper right corner
        


   
