using TechTalk.SpecFlow;   //SpecFlow
using FluentAssertions;  //Adds additional extentions like .Should() and .Be()

namespace SpecFlowCalculator.Specs.StepDefinitions
{
   [Binding]
   [Scope(Feature = "CalculatorStepDefinitions")]
   public sealed class CalculatorStepDefinitions
   {
      /// /////////// Calculator Feature
      
      // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
      private readonly Calculator _calculator = new Calculator();
      private int _result;

      [Given("the first number is (.*)")]
      public void GivenTheFirstNumberIs(int number)
      {
         _calculator.FirstNumber = number;   //Check that FirstNumber property equals parameter 'number'
      }

      ///The feature contains an 'and' between these two 'Given's, therefore they both must pass

      [Given("the second number is (.*)")]
      public void GivenTheSecondNumberIs(int number)
      {
         _calculator.SecondNumber = number;  //Check that SecondNumber property equals parameter 'number'
      }

      [When("the two numbers are added")]
      public void WhenTheTwoNumbersAreAdded()
      {
         _result = _calculator.Add();  //Check that .Add() method of Calculator class is called
      }

      [Then("the result should be (.*)")]
      public void ThenTheResultShouldBe(int result)
      {
         _result.Should().Be(result);  //Check that the _result1 set by .Add() method above equals the parameter 'result'
      }
   }
}