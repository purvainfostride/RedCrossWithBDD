Feature: BeautyPage

Background: 
Given user is on Landing page of the application
And user managed the cookies 
When user clicked on Beauty menu button 

@BeautyPage @MenuBar
Scenario: To Validate BeautyPage drop down options
	Then user is redirecting to sub pages of BeautyPage page

@BeautyPage @NavigationBar
Scenario: To Validate Stationary side Navigation bar options
	Then user is redirecting to sub pages of BeautyPage by side Navigation bar
