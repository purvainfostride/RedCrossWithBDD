Feature: CartPage

A short summary of the feature
Background: 
Given user is on Landing page of the application
And user managed the cookies 

#@CartPage
#Scenario: User is able to add products from different pages in cart
#	When user selected a page to shop
#	And user selected a product to add in cart
#	And user added that product to cart
#	Then user selected another page to shop
#	And user selected another product to add in cart
#	And user added that another product to cart

@CartPage
Scenario: Total price of newIn products are same as displayed in total of cart page
	When user clicked on New In menu button
	Then user is on New Arrivals page
	Then user Validate total price of cart products is same as displayed in total 

@CartPage
Scenario: To validate Quantity updation in cart page
	When user clicked on New In menu button
	And user is on New Arrivals page
	And user selected a product to add in cart
	And user added that product to cart
	Then user validate quantity updation in new arrival's cart page

@CartPage
Scenario: Whether new added products are above already added products in cart
	When user clicked on New In menu button
	And user is on New Arrivals page
	Then user validate new added products are above already added products in cart

@CartPage
Scenario: To Validate User is able to checkout the Virtual Gifts product from cart
	Given user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	And user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	And user added the gift to cart
	And user selected keeping in touch
	Then user checkout the product from cart

@CartPage
Scenario: To Validate User is able to add suggested gift and checkout from cart
	Given user clicked on Virtual Gifts menu button
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

@CartPage
Scenario: To Validate User is able to perform payment transaction 
	Given user clicked on Virtual Gifts menu button
	When user is on Virtual Gifts Page
	When user clicked on the gift to be selected
	And user haven't selected a card
	And user entered the Message which is optional
	Then user added the gift to cart
	And user selected keeping in touch
	And user checkout the product from cart
	And user entered personal details 
	And user continued the payment process

	