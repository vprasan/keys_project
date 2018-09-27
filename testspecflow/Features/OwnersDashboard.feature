Feature: Validate the OwnersDashboard page

Background: 
Given user navigate to keys web application 
	And user  type  "vvpveed@gmail.com", "harii@123" 
	When user click login button
	Then user should be able to login successfully and Dasboard page should be displayed
	

@mytag
Scenario: Verfiy if the owners dashboard shows the Properties, financials and tenant details
	Given user is in dashboard page 
	When  user clicks on the properties link 
	And user clicks on tenants link
	And user clicks on finance details link
	Then the user should see the respective pages i.e properties, finance and tenant details on clicking the links
