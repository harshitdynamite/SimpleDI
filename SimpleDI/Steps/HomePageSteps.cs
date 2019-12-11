using BoDi;
using TechTalk.SpecFlow;

namespace SimpleDI.Steps
{
    [Binding]
    public sealed class HomePageSteps:BaseStep
    {
        public HomePageSteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
        
        
        [Given(@"I entered to ""(.*)""")]
        public void GivenIEnteredTo(string url)
        {
            //throw new System.Exception();
            WebDriver.Navigate().GoToUrl(url);
        }
    }
}
