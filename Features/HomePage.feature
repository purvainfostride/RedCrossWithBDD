Feature: Checking functionality of HomePage of the Application

@HomePage
Scenario: To Verify whether the user is able to login to the application
	Given user is on Home page 
	#need to change
	And user managed the cookies 
	And user clicked on My Account button
	And Login dialogue box appears
	When user entered Valid EmailID
	And user entered Valid UserPassword
	Then user click on Login Button
	And user logged in successfully

Scenario: To Verify whether Shope Home menu button directing user to the home page 
	Given user is on Home page
	And user managed the cookies 
	When user clicked on Shope Home menu button
	Then user is on landing page of the application

Scenario: To Verify whether New In menu button directing user to the home page 
	Given user is on Home page
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page


