Feature: VirtaulGifts

@VirtualPage
Scenario: To Validate whether Virtual Gifts menu button directing user to virtual gifts page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Virtual Gifts menu button
	Then user is redirected to Virtual Gifts page
	And user closed the browser

@VirtualPage
Scenario: To Validate whether user is able to select virtual gifts to send
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	Then user clicked on the gift to be selected
	And user closed the browser

@AddVirtualPageProductToCart
Scenario: To Validate User Added Virtual gift to cart with Greeting Card
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	And user clicked on the gift to be selected
	Then user selected a greeting card
	And user entered the Message
	And user added the gift to cart
	And user closed the browser

@AddVirtualPageProductToCart
Scenario: To Validate User Added Virtual gift to cart with Ecard
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	And user clicked on the gift to be selected
	Then user selected an Ecard
	And user entered Recipient's Name
	And user entered his/her Name
	And user entered the Message with word limit
	And user entered the Message Recipient's Email
	And user added the gift to cart
	And user closed the browser

@AddVirtualPageProductToCart
Scenario: To Validate User Added Virtual gift to cart without any card
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	And user clicked on the gift to be selected
	Then user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user closed the browser




