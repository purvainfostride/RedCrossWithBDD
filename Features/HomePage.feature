Feature: HomePage
To Validate functionality of HomePage

Background: 
Given user is on Landing page of the application
And user managed the cookies 

@HomePage
@UserSignup
Scenario: User is able to signup to the Application with Valid details
	Given user clicked on My Account button
	And Login dialogue box appears
	And user clicked on Create your account Button
	And Signup dialogue box appears
	When user entered Valid FirstName
	And user entered Valid LastName
	And user entered Valid Email
	And user entered Valid Password
	Then user clicked on Create My Account button
	And user is able to signup successfully
	And user closed the browser

@HomePage
@UserLogin
Scenario: User is able to login with valid credentials
	Given user clicked on My Account button
	And Login dialogue box appears
	When user entered Valid EmailID
	And user entered Valid UserPassword
	Then user click on Login Button
	And user logged in successfully
	And user closed the browser

@HomePage
Scenario: To validate the menu bar buttons functionality
	When user clicked on menu buttons
	Then user closed the browser
	