Feature: NewInPage
To Validate functionality of NewInPage

Background: 
Given user is on Landing page of the application
And user managed the cookies 
When user clicked on New In menu button
Then user is on New Arrivals page

@NewInPage
Scenario: Whether the New Arrival's Page Products are equal in total as displayed
	Then New Arrival's Product count is same as displayed

@NewInPage
Scenario: Whether the New Arrival's Products are clickable
	Then New Arrival's Products are clickable

@NewInPage
Scenario: User is able to redirect to next pages of NewInPage by digit buttons
	Then user is able to redirect to next pages with numbers

@NewInPage
Scenario: User is able to redirect to next pages by next button
	Then user is able to redirect to next pages

@NewInPage
Scenario: User is able to redirect to previous pages by previous button
	Then user is able to redirect to next pages
	And user is able to redirect to previous pages

@NewInPage
Scenario: Display Filter is Sorting the products by range
	Then user validate whether Display Filter is Sorting the products by range

@NewInPage
Scenario: Sort by Filter is Sorting the products by range
	Then user validate whether Sort by Filter is Sorting the products by range

