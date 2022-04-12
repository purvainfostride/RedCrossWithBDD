Feature: Checking functionality of HomePage of the Application

@HomePage
Scenario: To validate whether user is on Landing page of the application of the application
	Given user initialized the browser
	When user navigated to the Application
	Then user is on Landing page of the application
	And user closed the browser

@HomePage
@UserSignup
Scenario:To validate whether user is able to signup to the Application with Valid details
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on My Account button
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
Scenario: To validate whether the user is able to login with valid credentials
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on My Account button
	And Login dialogue box appears
	When user entered Valid EmailID
	And user entered Valid UserPassword
	Then user click on Login Button
	And user logged in successfully
	And user closed the browser

@HomePage
Scenario: To validate the menu bar buttons functionality
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Shope Home menu button
	Then user is on Shope Home page of the application
	And user clicked on New In menu button
	And user is redirected to New Arrivals page
	And user clicked on Clothing menu button
	And user clicked on Stationary menu button
	And user clicked on Homeware menu button
	And user clicked on Beauty menu button
	And user clicked on Virtual Gifts menu button
	And user is on Virtual Gifts Page
	And user clicked on Sale menu button
	And user is redirected to Sale page
	And user closed the browser
