Feature: Checking functionality of HomePage of the Application

@HomePage
Scenario: To Verify whether Signup Dialogue box is appearing
	Given user is on Home page
	And user managed the cookies 
	When user clicked on My Account button
	And Login dialogue box appears
	And user clicked on Create New Account Button
	Then Signup dialogue box appears

