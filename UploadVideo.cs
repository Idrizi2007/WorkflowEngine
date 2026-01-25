namespace WorkflowEngine
{
    public class UploadVideo : IActivity
    {
        public ActivityResult Execute()
        {
            Console.WriteLine("Video Uploading...");
            return ActivityResult.Success("Video uploaded successfully");
        }
    }



}

