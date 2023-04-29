using Microsoft.AspNetCore.Components;

namespace BlazorAppPRACTICE.Pages
{
    public class CounterBase : ComponentBase
    {

        protected int currentCount = 0;

        [Inject]
        public ILogger<CounterBase>? Logger { get; set; }

        protected void IncrementCount()
        {
            currentCount += 2;
            Logger.LogInformation("CounterBase.IncrementCount() method called.");
        }

    }
}
