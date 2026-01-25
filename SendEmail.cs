namespace WorkflowEngine
{
    public class SendEmail : IActivity
    {
        public ActivityResult Execute()
        {
            Console.WriteLine("Sending Email...");
            return ActivityResult.Success("Email sent successfully");
        }
    }



}

