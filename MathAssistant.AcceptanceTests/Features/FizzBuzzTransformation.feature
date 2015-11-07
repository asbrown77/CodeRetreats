@PBI12345
Feature: Fizz Buzz Transformation
	As a bad maths student, 
	I need to obtain a specified list of sequence numbers where any number divisible by 3 use 
	"Fizz" and any number divisible by 5 use "Buzz", 
	so that I can avoid embarrassment in front of the whole class.

Scenario Outline: Quit Application on empty input or zero
	Given I prompted to enter the total number of sequence numbers
	When I have entered in "<input>"
	Then should exit application
Examples:
	| input | 
	| 0		|
	|		| 

Scenario: Input a non numeric value
	Given I prompted to enter the total number of sequence numbers
	When I have entered in "xy"
	Then I should display "Need to enter numeric value!"
	And I should prompted to enter another sequence number

Scenario Outline: Input sequence number greater than zero
	Given I prompted to enter the total number of sequence numbers
	When I have entered in "<input>"
	Then I should display "<output>"
	And I should prompted to enter another sequence number
Examples:
	| input | output 													|
	| 1		| 1															|
	| 5		| 1,2,Fizz,4,Buzz											|
	| 15	| 1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz	|

Scenario: Continue entering sequence number greater than zero and then exit
	Given I prompted to enter the total number of sequence numbers
	And I have entered in "1"
	When I have entered in "5"
	Then I should display "1,2,Fizz,4,Buzz"
