Feature: This test suite contains test scenarios for Time and Material Page

Scenario: A. Create a new Time and Material record alpha code
	Given I log into Turnup portal
	When I navigate to Time and Material page
	And I create a new Time and Material record 
	Then the record should be saved 


Scenario: B. Edit an existing Time and Material record
Given  I log into Turnup portal
When  I navigate to Time and Material page
And I edit a new Time and Material record
Then the record should be saved 


Scenario: C. Delete an existing Time and Material record
Given  I log into Turnup portal
When I navigate to Time and Material page
And I delete an existing Time and Material record
Then the record should be deleted