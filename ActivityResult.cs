namespace WorkflowEngine
{
        public class ActivityResult
        {
            public bool isSuccess;
            public string message;

            public  ActivityResult(bool IsSuccess, string Message)
            {
                isSuccess = IsSuccess;
                message = Message;
            }


            public static ActivityResult Success(string message)
            {
                return new  ActivityResult(true, message);
            }


            public static ActivityResult Failure(string message)
            {
            if (string.IsNullOrEmpty(message))
            {
                throw new System.ArgumentException("Failure: message cannot be null or empty");
            }
            else 
            {
                return new ActivityResult(false, message);
            }

                
            }
        }
    

}

