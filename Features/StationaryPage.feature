Feature: StationaryPage

@StationaryPage
Scenario: To Validate Stationary drop down options
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected greeting cards catagory to shop
	And user is on greeting cards page
	And user selected Birthday cards catagory to shop
	And user is on Birthday cards page
	And user selected Congratulations cards catagory to shop
	And user is on Congratulations cards page
	And user selected Thankyou cards catagory to shop
	And user is on Thankyou cards page
	And user selected Wrapping paper catagory to shop
	And user is on Wrapping paper page
	And user selected Notebooks catagory to shop
	And user is on Notebooks page
	And user selected Enamel Pin Badges catagory to shop
	And user is on Enamel Pin Badges page
	And user closed the browser

@GreetingcardsPage
Scenario: To validate if greeting cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	Then greeting cards page Products count is same as displayed
	And user closed the browser

@GreetingcardsPage
Scenario: To validate user is able to redirect to next pages of GreetingcardsPage by digit buttons
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	Then user is able to redirect to next pages of GreetingcardsPage with numbers
	And user closed the browser

@GreetingcardsPage
Scenario: To validate user is able to redirect to next pages by next button
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected greeting cards catagory to shop
	And user is able to redirect to next pages of GreetingcardsPage
	And user closed the browser

@GreetingcardsPage
Scenario: To validate user is able to redirect to previous pages by previous button
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	Then user is able to redirect to next pages of GreetingcardsPage
	And user is able to redirect to previous pages of GreetingcardsPage
	And user closed the browser

@GreetingcardsPage
Scenario: To validate whether Display Filter is Sorting the products by range
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	Then user validate whether Display Filter of greetingsPage is Sorting the products by range
	And user closed the browser


@GreetingcardsPage
Scenario:  To validate whether Sort by Filter is Sorting the products by range
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	Then user validate whether Sort by Filter of greetingsPage is Sorting the products by range
	And user closed the browser
	
@birthdaycardsPage
Scenario: To validate if birthday cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected birthday cards catagory to shop
	Then birthday cards page Products count is same as displayed
	And user closed the browser

@CongratulationscardsPage
Scenario: To validate if Congratulations cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected Congratulations cards catagory to shop
	Then Congratulations cards page Products count is same as displayed
	And user closed the browser

@ThankyoucardsPage
Scenario: To validate if Thankyou cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected Thankyou cards catagory to shop
	Then Thankyou cards page Products count is same as displayed
	And user closed the browser

@WrappingcardsPage
Scenario: To validate if Wrapping cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected Wrapping cards catagory to shop
	Then Wrapping cards page Products count is same as displayed
	And user closed the browser

@NotebookscardsPage
Scenario: To validate if Notebooks cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected Notebooks cards catagory to shop
	Then Notebooks cards page Products count is same as displayed
	And user closed the browser	

@EnamelPinBadgesPage
Scenario: To validate if EnamelPinBadges Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected Enamel Pin Badges catagory to shop
	Then Enamel Pin Badges page Products count is same as displayed
	And user closed the browser	