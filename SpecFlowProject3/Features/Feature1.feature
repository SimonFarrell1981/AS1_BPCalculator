Feature: BPCalculator

A short summary of the feature

@tag1
Scenario: Check for low blood pressure
	Given the diastolic value is <diastolic_value>
	And the systolic value is <systolic_value>
	When the blood pressure catagory is calculated
	Then the result should be <blood_pressure_catagory>
	Examples: 
	| diastolic_value | systolic_value | blood_pressure_catagory |
	| 50              | 80             | "low"                   |


