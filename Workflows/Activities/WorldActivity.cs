using Elsa.Workflows;
using Elsa.Workflows.Activities;

namespace ElsaStudioBlazorServer.Workflows.Activities
{
    public class WorldActivity : CodeActivity
    {
        protected override async ValueTask ExecuteAsync(ActivityExecutionContext context)
        {
            new WriteLine("World!");
        }

    }
}
