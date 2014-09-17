using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;

namespace MathProblem.Tests
{
    [Binding]
    public class 數字組合Steps
    {
        private HumanCalculator target;
        [BeforeScenario]
        public void BeforeScenario()
        {
            this.target = new HumanCalculator();
        }

        [Given(@"總和為 (.*)")]
        public void Given總和為(int sum)
        {
            ScenarioContext.Current.Set<int>(sum);
        }

        [When(@"I 呼叫人體計算機時")]
        public void WhenI呼叫人體計算機時()
        {
            var sum = ScenarioContext.Current.Get<int>();
            this.target.ShowMeTheAnswer(sum);
        }

        [Then(@"結果應為")]
        public void Then結果應為(Table table)
        {
            var actual = this.target.GetResult().Select(x => new Result { First = x[0], Second = x[1], Third = x[2], Fourth = x[3] });

            table.CompareToSet<Result>(actual);
        }
    }

    public class HumanCalculator
    {       
        private List<List<int>> result = new List<List<int>>();

        internal void ShowMeTheAnswer(int sum)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<List<int>> GetResult()
        {
            return this.result;
        }
    }

    public class Result
    {
        public int First { get; set; }

        public int Second { get; set; }

        public int Third { get; set; }

        public int Fourth { get; set; }
    }
}
