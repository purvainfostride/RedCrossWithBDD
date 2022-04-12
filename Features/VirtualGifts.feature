Feature: VirtaulGifts

@VirtualPage
Scenario: To Validate whether Virtual Gifts menu button directing user to virtual gifts page
	Given user is on Landing page of the application
	And user managed the cookies 
	When user clicked on Virtual Gifts menu button
	Then user is on Virtual Gifts Page
	And user closed the browser

@VirtualPage
Scenario: To Validate whether user is able to select virtual gifts to send
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	Then user clicked on the gift to be selected
	And user closed the browser

@AddVirtualPageProductToCart
Scenario: To Validate whether user is able to Add Virtual gift to cart with Greeting Card
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	And user clicked on the gift to be selected
	Then user selected a greeting card
	And user entered the Message
	And user added the gift to cart
	And user closed the browser

@AddVirtualPageProductToCart
Scenario: To Validate whether user is able to Add Virtual gift to cart with Ecard
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	And user clicked on the gift to be selected
	Then user selected an Ecard
	And user entered Recipient's Name
	And user entered his/her Name
	And user entered the Message with word limit
	And user entered the Message Recipient's Email
	And user added the gift to cart
	And user closed the browser

@AddVirtualPageProductToCart
Scenario: To Validate whether user is able to Add Virtual gift to cart without any card
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	And user clicked on the gift to be selected
	Then user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user closed the browser

@checkoutVirtualPageProduct
Scenario: To Validate User is able to checkout the gift from cart
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	And user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user selected keeping in touch
	Then user checkout the product from cart
	And user closed the browser

@checkoutVirtualPageProduct
Scenario: To Validate User is able to add suggested gift and checkout from cart
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	And user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	Then user selected another gift from suggestions
	And user haven't selected a card
	And user added the gift to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user closed the browser
	
@checkoutVirtualPageProduct
Scenario: To Validate User is able to perform payment transaction 
	Given user is on Landing page of the application
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	When user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	Then user added the gift to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user entered personal details 
	And user continued the payment process




