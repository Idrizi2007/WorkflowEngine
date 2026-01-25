namespace WorkflowEngine
{
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

