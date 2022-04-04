Feature: Checking functionality of SignUp Dialogue Box of the Application

A short summary of the feature

@SignupwithValidCredentials
Scenario:To Verify whether user is able to signup to the Application with Valid details
	Given user is on Home page
	And user managed the cookies 
	And user clicked on My Account button
	And Login dialogue box appears
	And user clicked on Create New Account Button
	And Signup dialogue box appears
	When user entered Valid FirstName
	And user entered Valid LastName
	And user entered Valid Email
	And user entered Valid Password
	Then user clicked on Create My Account button
	And user is able to signup successfully
