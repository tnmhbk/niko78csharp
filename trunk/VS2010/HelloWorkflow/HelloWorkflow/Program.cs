using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HelloWorkflow
{
    class Program
    {
        private static WorkflowApplication _application;

        private static AutoResetEvent idleEvent = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine(" --- Inicio de programa ---");

            _application = CreateNewWorkFlow();
            _application.Completed += OnCompleted;
            _application.InstanceStore = new XmlWorkflowInstanceStore();
            _application.Run();

            idleEvent.WaitOne();

            Console.WriteLine(" --- Fin de programa ---");
            Console.ReadLine();

        }

        private static WorkflowApplication CreateNewWorkFlow()
        {
            WorkflowApplication wfApp = new WorkflowApplication(new MainActivity());
            return wfApp;
        }

        public static void OnCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            idleEvent.Set();
        }
    }
}
