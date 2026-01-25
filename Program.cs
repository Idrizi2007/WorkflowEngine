namespace WorkflowEngine
{
    partial class Program 
    
    {
        static void Main(string[] args)
        {
            WorkflowRunner workflowrunner = new WorkflowRunner();
           Workflow workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflowrunner.Runner(workflow);
            
        }
    }

}

