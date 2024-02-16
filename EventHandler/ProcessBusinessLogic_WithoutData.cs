namespace BuiltInEventHandler
{
    internal class ProcessBusinessLogic_WithoutData
    {
        // declaring an event using built-in EventHandler
        public event EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted(EventArgs.Empty); //No event data
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
