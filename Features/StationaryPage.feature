Feature: StationaryPage

@StationaryPage
Scenario: To Validate Stationary drop down options
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Stationary menu button
	When user selected greeting cards catagory to shop
	Then user is on greeting cards page
	When user selected Birthday cards catagory to shop
	Then user is on Birthday cards page
	When user selected Congratulations cards catagory to shop
	Then user is on Congratulations cards page
	When user selected Thankyou cards catagory to shop
	Then user is on Thankyou cards page
	When user selected Wrapping paper catagory to shop
	Then user is on Wrapping paper page
	When user selected Notebooks catagory to shop
	Then user is on Notebooks page
	When user selected Enamel Pin Badges catagory to shop
	Then user is on Enamel Pin Badges page
	And user closed the browser

@StationaryPage
Scenario: To validate if greeting cards Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	Then greeting cards page Products count is same as displayed
	And user closed the browser

@GreetingcardsPage
Scenario: To Validate Display filter sort items 24 per page
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	And user is on greeting cards page
	When user selected display filter
	Then selected 24 per page
	And page filtered with items 24 per page
	And user closed the browser

#@GreetingcardSPage
#Scenario: To Validate Display filter 36 per page
#	Given user is on Landing page of the application
#	And user managed the cookies 
#	And user clicked on Stationary menu button
#	And user selected greeting cards catagory to shop
#	And user is on greeting cards page
#	When user selected display filter
#	Then selected 36 per page
#	And page filtered with items 36 per page
#	And user closed the browser
#
#@GreetingcardSPage
#Scenario: To Validate Display filter 48 per page
#	Given user is on Landing page of the application
#	And user managed the cookies 
#	And user clicked on Stationary menu button
#	And user selected greeting cards catagory to shop
#	And user is on greeting cards page
#	When user selected display filter
#	Then selected 48 per page
#	And page filtered with items 48 per page
#	And user closed the browser

@GreetingcardsPage
Scenario: To Validate BestSelling filter sort items Alphabetically A-Z
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	And user is on greeting cards page
	When user selected BestSelling filter
	Then selected Alphabetically A-Z
	And page filtered with items Alphabetically A-Z
	And user closed the browser

#@GreetingcardsPage
#Scenario: To Validate whether user is able to select greeting cards from greeting card page
#	Given user is on Landing page of the application
#	And user managed the cookies 
#	And user clicked on Stationary menu button
#	And user selected greeting cards catagory to shop
#	When user is on greeting cards page
#	Then user select greeting card to send
	