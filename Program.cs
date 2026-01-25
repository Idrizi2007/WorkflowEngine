namespace WorkflowEngine
{
    partial class Program 
    
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            INotificationService notificationService = new NotificationService();
            WorkflowRunner workflowrunner = new WorkflowRunner(notificationService, logger);
            Workflow workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflowrunner.Runner(workflow);
            
        }
    }

}

