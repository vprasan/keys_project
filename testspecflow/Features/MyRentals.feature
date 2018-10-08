Feature: Validate My Rentals page

@mytag
Scenario: Verfiy if the user who logged in as Tenant, is able to see his rentals 
	Given user is in dashboard page with tenant credentials "vincent.nguyen@mvpstudio.co.nz", "ntmv2682"  
	When  user click on the Tenants Menu option 
	And user click on My Rentals sub menu option
	Then the user should see My Rentals page with his rental property details

