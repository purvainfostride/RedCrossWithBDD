Feature: CartPage


@checkoutVirtualPageProduct
Scenario: To Verify User is able to checkout the gift from cart
	Given user is on Home page
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	Then user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user closed the browser

@checkoutVirtualPageProduct
Scenario: To Verify User is able to add suggested gift and checkout from cart
	Given user is on Home page
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	Then user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user added another gift from suggestion to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user closed the browser

@checkoutVirtualPageProduct
Scenario: To Verify User is able to perform payment transaction for gift
	Given user is on Home page
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	Then user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user added another gift from suggestion to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user entered personal details
	
@test
Scenario: To Verify User is able to perform payment transaction 
	Given user is on Home page
	And user managed the cookies 
	And user clicked on Virtual Gifts menu button
	When user is redirected to Virtual Gifts page
	Then user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user added another gift from suggestion to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user entered personal details 
	And user continued the payment process

