Feature: Add Monkey Rule Transformation
	As a bad maths student, 
	I need to obtain a specified list of sequence numbers where any number divisible by 5 use "Monkey", 
	so that I can continue to avoid embarrassment in front of the whole class.

Background: 
	Given I have Transformation Rule of "Monkey"

Scenario Outline: Input valid sequence numbers
	Given I prompted to enter the total number of sequence numbers
	When I have entered in "<input>"
	Then I should display "<output>"
	And I should prompted to enter another sequence number
Examples:
	| input | output                        |
	| 5     | 1,2,3,4,Monkey                |
	| 10    | 1,2,3,4,Monkey,6,7,8,9,Monkey |