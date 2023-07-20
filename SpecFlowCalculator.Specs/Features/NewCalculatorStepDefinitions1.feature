Feature: NewCalculatorStepDefinitions1

A short summary of the feature

@SomeScenarioTag @SomeOtherTag @WhateverTag
Scenario: Multiply the numbers then add 123
   Given the first property is 2
   Given the second property is 4
   And the combined properties equal 6
   When the two numbers are multiplied
   Then the result should be 8
   When 123 is added to the result
   Then the new result should be 131
   Then print the comment "Hello!"

Scenario: Multiply the numbers then add 456
   Given the first property is 2
   Given the second property is 4
   And the combined properties equal 6
   When the two numbers are multiplied
   Then the result should be 8
   When 456 is added to the result
   Then the new result should be 131
   Then print the comment "Hello!"
   But 