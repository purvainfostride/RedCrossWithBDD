Feature: BeautyPage

Background: 
Given user is on Landing page of the application
And user managed the cookies 
When user clicked on Beauty menu button 

@BeautyPage @MenuBar
Scenario: To Validate BeautyPage drop down options
	Then user is redirecting to sub pages of BeautyPage page

@BeautyPage @NavigationBar
Scenario: To Validate BeautyPage side Navigation bar options
	Then user is redirecting to sub pages of BeautyPage by side Navigation bar

@BeautyPage @ViewAll
Scenario: user is able to redirect to view all subpage of BeautyPage
	Then user is able to redirect to view all subpage of beauty page

@BeautyPage @ViewAll
Scenario: Whether the products of view all subpage of BeautyPage are equal in total as displayed
	When user is able to redirect to view all subpage of beauty page 
	Then products of view all subpage of BeautyPage are equal in total as displayed

@BeautyPage @Face
Scenario: Whether the products of Face subpage of BeautyPage are equal in total as displayed
	When user is able to redirect to Face subpage of beauty page 
	Then products of Face subpage of BeautyPage are equal in total as displayed

@BeautyPage @Body
Scenario: Whether the products of Body subpage of BeautyPage are equal in total as displayed
	When user is able to redirect to Body subpage of beauty page 
	Then products of Body subpage of BeautyPage are equal in total as displayed

@BeautyPage @Emolyne
Scenario: Whether the products of Emolyne subpage of BeautyPage are equal in total as displayed
	When user is able to redirect to Emolyne subpage of beauty page 
	Then products of Emolyne subpage of BeautyPage are equal in total as displayed