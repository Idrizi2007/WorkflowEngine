namespace WorkflowEngine
{
    public class WorkflowRunner
    {
        public void Runner(Workflow workflow)
        {
            foreach (var activity in workflow.Expose())
            {
               activity.Execute();
            }
        }
    }


    public class Workflow() 
    {
        private IList<IActivity> _activities = new List<IActivity>();

        public void Add(IActivity activies)
        {
            _activities.Add(activies);
        }

        public  IList<IActivity> Expose()
       
        {
            return _activities;
        }

       
        
    }


}

