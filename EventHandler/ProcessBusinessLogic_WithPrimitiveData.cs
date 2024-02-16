namespace BuiltInEventHandler
{
    public class ProcessBusinessLogic_WithPrimitiveData
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Process Started!");

                // some code here..

                OnProcessCompleted(true);
            }
            catch (Exception ex)
            {
                OnProcessCompleted(false);
            }
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
}
