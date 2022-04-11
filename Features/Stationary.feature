Feature: Stationary

A short summary of the feature

@StationaryPage
Scenario: To Validate whether user is able to redirect to greeting cards page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected greeting cards catagory to shop
	And user is on greeting cards page
	And user closed the browser

@StationaryPage
Scenario: To Validate whether user is able to redirect to Birthday cards page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected Birthday cards catagory to shop
	And user is on Birthday cards page
	And user closed the browser

@StationaryPage
Scenario: To Validate whether user is able to redirect to Congratulations cards page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected Congratulations cards catagory to shop
	And user is on Congratulations cards page
	And user closed the browser

@StationaryPage
Scenario: To Validate whether user is able to redirect to Thankyou cards page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected Thankyou cards catagory to shop
	And user is on Thankyou cards page
	And user closed the browser

@StationaryPage
Scenario: To Validate whether user is able to redirect to Wrapping paper page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected Wrapping paper catagory to shop
	And user is on Wrapping paper page
	And user closed the browser

@StationaryPage
Scenario: To Validate whether user is able to redirect to Notebooks page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected Notebooks catagory to shop
	And user is on Notebooks page
	And user closed the browser

@StationaryPage
Scenario: To Validate whether user is able to redirect to Enamel Pin Badges page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Stationary menu button
	Then user selected Enamel Pin Badges catagory to shop
	And user is on Enamel Pin Badges page
	And user closed the browser

@GreetingcardSPage
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

@GreetingcardSPage
Scenario: To Validate BestSelling filter sort items 24 per page
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Stationary menu button
	And user selected greeting cards catagory to shop
	And user is on greeting cards page
	When user selected BestSelling filter
	Then selected Alphabetically A-Z
	And page filtered with items  Alphabetically A-Z
	And user closed the browser