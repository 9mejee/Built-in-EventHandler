namespace BuiltInEventHandler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProcessBusinessLogic_WithoutData obj = new ProcessBusinessLogic_WithoutData();
            obj.ProcessCompleted += Process_Complete; // register with an event
            obj.StartProcess();

            ProcessBusinessLogic_WithPrimitiveData objPrimitiveData = new ProcessBusinessLogic_WithPrimitiveData();
            objPrimitiveData.ProcessCompleted += Process_Completed; // register with an event
            objPrimitiveData.StartProcess();


            ProcessBusinessLogic_WithData objData = new ProcessBusinessLogic_WithData();
            objData.ProcessCompleted += Process_Completed; // register with an event
            objData.StartProcess();
        }

        // event handler without data
        public static void Process_Complete(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }

        // event handler passing primitive data
        public static void Process_Completed(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }

        // event handler passing object
        public static void Process_Completed(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
        }
    }
}
