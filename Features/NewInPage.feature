Feature: NewInPage

A short summary of the feature

@NewInPage
Scenario: To validate if New Arrival's Page Products are equal in total as displayed
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And New Arrival's Product count is same as displayed
	And user closed the browser

@NewInPage
Scenario: To validate if New Arrival's Products are clickable
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And New Arrival's Products are clickable
	And user closed the browser

@NewInPage
Scenario: To validate user is able to redirect to next pages of NewInPage by digit buttons
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And user is able to redirect to next pages with numbers
	And user closed the browser

@NewInPage
Scenario: To validate user is able to redirect to next pages by next button
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And user is able to redirect to next pages
	And user closed the browser

@NewInPage
Scenario: To validate user is able to redirect to previous pages by previous button
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on New In menu button
	Then user is redirected to New Arrivals page
	And user is able to redirect to next pages
	And user is able to redirect to previous pages
	And user closed the browser

@NewInPage
Scenario: To validate whether Display Filter is Sorting the products by range
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on New In menu button
	And user is redirected to New Arrivals page
	Then user validate whether Display Filter is Sorting the products by range
	And user closed the browser

@NewInPage
Scenario:  To validate whether Sort by Filter is Sorting the products by range
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on New In menu button
	And user is redirected to New Arrivals page
	Then user validate whether Sort by Filter is Sorting the products by range
	And user closed the browser

@NewInPage
Scenario: To Validate total price of cart products is same as displayed in total 
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on New In menu button
	And user is redirected to New Arrivals page
	#And user clicked on the product to be selected
	#When user added the gift to cart
	Then user Validate total price of cart products is same as displayed in total 
	And user closed the browser

@NewInPage
Scenario: To validate quantity updation in new arrival's cart page
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on New In menu button
	And user is redirected to New Arrivals page
	#And user clicked on the product to be selected
	Then user validate quantity updation in new arrival's cart page
	And user closed the browser