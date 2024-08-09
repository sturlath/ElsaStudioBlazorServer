using Elsa.Workflows.Activities;
using Elsa.Workflows.Contracts;
using ElsaStudioBlazorServer.Workflows.Activities;

namespace ElsaStudioBlazorServer.Workflows
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public ValueTask BuildAsync(IWorkflowBuilder builder, CancellationToken cancellationToken = default)
        {
            builder.Root = new Sequence
            {
                Activities =
                {
                    new HelloActivity(),
                    new WorldActivity(),
            }
            };

            return ValueTask.CompletedTask;
        }
    }
}
