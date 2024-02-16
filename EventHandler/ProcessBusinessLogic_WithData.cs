namespace BuiltInEventHandler
{
    internal class ProcessBusinessLogic_WithData
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public void StartProcess()
        {
            var data = new ProcessEventArgs();
            try
            {
                Console.WriteLine("Process Started!");

                data.IsSuccessful = true;
                data.CompletionTime = DateTime.Now;
                OnProcessCompleted(data);
            }
            catch (Exception ex)
            {
                data.IsSuccessful = false;
                data.CompletionTime = DateTime.Now;
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
