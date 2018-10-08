Feature: Validate MyRental My Requests page
Scenario Outline: Verfiy if the user who logged in as a Tenant, is able to view My Requests page 
	Given user is in the rental properties page with tenant credential, "<username>", "<password>"  
	When  user clicks on the menu option My Requests 
	Then the My Requests page should be displayed 
Examples:
| testcase | username                       | password | 
| 1        | vincent.nguyen@mvpstudio.co.nz | ntmv2682 | 