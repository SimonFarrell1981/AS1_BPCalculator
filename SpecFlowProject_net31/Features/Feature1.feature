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
	| 40              | 70             | "Low"                   |
	| 50              | 80             | "Low"                   |
	| 60              | 90             | "Ideal"                 |
	| 70              | 110            | "Ideal"                 |
	| 80              | 120            | "PreHigh"               |
	| 85              | 130            | "PreHigh"               |
	| 90              | 140            | "High"                  |
	| 100             | 190            | "High"                  |