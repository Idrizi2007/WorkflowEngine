using System.Diagnostics;
using static WorkflowEngine.Program;

namespace WorkflowEngine
{
    public class WorkflowRunner
    {
        private readonly INotificationService _notificationService;
        
        private readonly ILogger _logger;

        public WorkflowRunner(INotificationService notificationService, ILogger logger)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        
        public void Runner(Workflow workflow)
        {
            int tries;

            foreach (var activity in workflow.Expose())
            {
                bool success = false;

                for (tries = 0; tries < 3; tries++)
                {
                  
                    ActivityResult result = activity.Execute();
                    if (result.isSuccess)
                    {
                        _logger.Log($"Activity succeeded: {result.message}");
                        success = true;
                        break;
                    }
                    else
                    {
                        success = false;
                    }
                   

                }
                if (!success)
                    _notificationService.Notify($"Activity failed after {tries} attempts.");
                


            }



        }
    }


}

