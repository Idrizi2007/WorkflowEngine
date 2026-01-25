using System.Diagnostics;
using static WorkflowEngine.Program;

namespace WorkflowEngine
{
    public class WebServiceCall : IActivity
    {
        public ActivityResult Execute()
        {
            Console.WriteLine("Calling web Service...");
            return ActivityResult.Success( "Web Service called successfully");


        }
        
    }

}

