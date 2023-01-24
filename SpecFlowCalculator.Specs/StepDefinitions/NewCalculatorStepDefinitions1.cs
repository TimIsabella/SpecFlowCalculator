using TechTalk.SpecFlow;
using FluentAssertions;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
   [Binding]
   [Scope(Feature = "NewCalculatorStepDefinitions1")]
   public sealed class NewCalculatorStepDefinitions1
   {
      private readonly Calculator _calculator = new Calculator();
      private int _result;

      //Called before the feature
      [BeforeFeature]
      public static void BeforeTheFeatureHasBegun()
      {
         Console.WriteLine("The 'NewCalculatorStepDefinitions1' feature test has begun.");
      }

      //Called before each scenario
      [BeforeScenario]
      public void BeforeEachScenarioHasBegun()
      {
         Console.WriteLine("A 'NewCalculatorStepDefinitions1' scenario test has begun.");
      }

      //Called before every step
      [BeforeStep]
      public void BeforeEachStepHasBegun()
      {
         Console.WriteLine("'NewCalculatorStepDefinitions1' has begun a step");
      }

      /// //////////////////////////////////////////////////////////////////

      [Given("the first property is (.*)")]
      public void GivenTheFirstPropertyIs(int number)
      {
         _calculator.FirstNumber = number;
      }

      [Given("the second property is (.*)")]
      public void GivenTheSecondPropertyIs(int number)
      {
         _calculator.SecondNumber = number;
      }

      [When("the two numbers are multiplied")]
      public void WhenTheTwoNumbersAreMultiplied()
      {
         _result = _calculator.Multiply();
      }

      [Then("the result should be (.*)")]
      public void ThenTheResultShouldBe(int result)
      {
         _result.Should().Be(result);
      }

      [When("(.*) is added to the result")]
      public void WhenAddToTheResult(int result)
      {
         _result += result;
      }

      [Then("the new result should be (.*)")]
      public void ThenTheNewResultShouldBe(int result)
      {
         _result.Should().Be(result);
      }

      /// //////////////////////////////////////////////////////////////////

      //Called after every step
      [AfterStep]
      public void AfterEachStepHasCompleted()
      {
         Console.WriteLine("'NewCalculatorStepDefinitions1' has completed a step");
      }

      //Called after each scenario
      [AfterScenario]
      public void AfterEachScenarioHasCompleted()
      {
         Console.WriteLine("A 'NewCalculatorStepDefinitions1' scenario has completed.");
      }

      //Called after each feature
      [AfterFeature]
      public static void AfterTheFeatureHasCompleted()
      {
         Console.WriteLine("The 'NewCalculatorStepDefinitions1' feature has completed.");
      }
   }
}