Feature: NewCalculatorStepDefinitions1

A short summary of the feature

@SomeScenarioTag
Scenario: Multiply the numbers then add 123
   Given the first property is 2
   Given the second property is 4
   When the two numbers are multiplied
   Then the result should be 8
   When 123 is added to the result
   Then the new result should be 131