Feature: Validate MyRental Landlord's Request page
Scenario Outline: Verfiy if the user who logged in as a Tenant, is able to view Landlord's Request page 
	Given user is in the rental properties page with tenant credential details, "<username>", "<password>"  
	When  user clicks on the menu option Landlord's Request
	Then the Landlord's Request page should be displayed 
Examples:
| testcase | username                       | password | 
| 1        | vincent.nguyen@mvpstudio.co.nz | ntmv2682 | 
