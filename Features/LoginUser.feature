Feature: Checking functionality of Login Dialogue Box of the Application

@LoginwithValidCredentials
Scenario: To Verify whether the user is able to login to the application
	Given user is on Home page
	And user managed the cookies 
	And user clicked on My Account button
	And Login dialogue box appears
	When user entered Valid EmailID
	And user entered Valid UserPassword
	Then user click on Login Button
	And user logged in successfully
	