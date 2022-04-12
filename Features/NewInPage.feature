Feature: NewInPage

A short summary of the feature

@NewInPage
Scenario: To validate if New Arrival's Product count is same as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And New Arrival's Product count is same as displayed
	And user closed the browser

@NewInPageProducts
Scenario: To validate if New Arrival's Products are clickable
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And New Arrival's Products are clickable
	And user closed the browser

@NewInPage
Scenario: To validate user is able to redirect to next pages with numbers
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And user is able to redirect to next pages with numbers
	And user closed the browser

@NewInPage
Scenario: To validate user is able to redirect to next pages
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And user is able to redirect to next pages
	And user closed the browser
