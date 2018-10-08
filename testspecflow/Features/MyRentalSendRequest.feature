Feature: Validate MyRental SendRequest page
	

Scenario Outline: Verfiy if the user who logged in as a Tenant, is able to send a request 
	Given user is in the rental properties page with tenant credentials, "<username>", "<password>"  
	When  user clicks on the menu option send a request 
	And  enters the required request details in the rental request page, "<message>","<ddw_request_type>"
	And  clicks on the submit button
	Then the rental properties page should be displayed after saving the send request details 
Examples:
| testcase | username                       | password | message										| ddw_request_type	|
| 1        | vincent.nguyen@mvpstudio.co.nz | ntmv2682 | This month the rent will be late by a week		| General Request	|    
