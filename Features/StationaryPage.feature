Feature: StationaryPage

Background: 
Given user is on Landing page of the application
And user managed the cookies 
When user clicked on Stationary menu button

@StationaryPage @MenuBar
Scenario: To Validate Stationary drop down options
	Then user is redirecting to sub pages of stationary page

@StationaryPage @NavigationBar
Scenario: To Validate Stationary side Navigation bar options
	Then user is redirecting to sub pages of stationary page by side Navigation bar

@GreetingcardsPage
Scenario: To validate if greeting cards Page Products are equal in total as displayed 
	And user selected greeting cards catagory to shop
	Then greeting cards page Products count is same as displayed


@GreetingcardsPage
Scenario: To validate user is able to redirect to next pages of GreetingcardsPage by digit buttons 
	And user selected greeting cards catagory to shop
	Then user is able to redirect to next pages of GreetingcardsPage with numbers


@GreetingcardsPage
Scenario: To validate user is able to redirect to next pages by next button
	Then user selected greeting cards catagory to shop
	And user is able to redirect to next pages of GreetingcardsPage


@GreetingcardsPage
Scenario: To validate user is able to redirect to previous pages by previous button
	And user selected greeting cards catagory to shop
	Then user is able to redirect to next pages of GreetingcardsPage
	And user is able to redirect to previous pages of GreetingcardsPage


@GreetingcardsPage
Scenario: To validate whether Display Filter is Sorting the products by range
	And user selected greeting cards catagory to shop
	Then user validate whether Display Filter of greetingsPage is Sorting the products by range

@GreetingcardsPage
Scenario:  To validate whether Sort by Filter is Sorting the products by range 
	And user selected greeting cards catagory to shop
	Then user validate whether Sort by Filter of greetingsPage is Sorting the products by range

	
@birthdaycardsPage
Scenario: To validate if birthday cards Page Products are equal in total as displayed 
	When user selected birthday cards catagory to shop
	Then birthday cards page Products count is same as displayed


@CongratulationscardsPage
Scenario: To validate if Congratulations cards Page Products are equal in total as displayed 
	When user selected Congratulations cards catagory to shop
	Then Congratulations cards page Products count is same as displayed


@ThankyoucardsPage
Scenario: To validate if Thankyou cards Page Products are equal in total as displayed
	When user selected Thankyou cards catagory to shop
	Then Thankyou cards page Products count is same as displayed


@WrappingcardsPage
Scenario: To validate if Wrapping cards Page Products are equal in total as displayed
	When user selected Wrapping cards catagory to shop
	Then Wrapping cards page Products count is same as displayed


@NotebookscardsPage
Scenario: To validate if Notebooks cards Page Products are equal in total as displayed
	When user selected Notebooks cards catagory to shop
	Then Notebooks cards page Products count is same as displayed
	

@EnamelPinBadgesPage
Scenario: To validate if EnamelPinBadges Page Products are equal in total as displayed
	When user selected Enamel Pin Badges catagory to shop
	Then Enamel Pin Badges page Products count is same as displayed
	