#region Using directives

using System;
using System.Threading;
using System.Workflow.Runtime;

#endregion

namespace HelloWorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowRuntime workflowRuntime = new WorkflowRuntime();
            workflowRuntime.WorkflowCompleted += workflowRuntime_WorkflowCompleted;
            workflowRuntime.WorkflowTerminated += workflowRuntime_WorkflowTerminated;
            WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(WorkflowMain));
            instance.Start();
            waitHandle.WaitOne();
        }

        static void workflowRuntime_WorkflowTerminated(object sender, WorkflowTerminatedEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
            waitHandle.Set();
        }
        static void workflowRuntime_WorkflowCompleted(object sender, WorkflowCompletedEventArgs e)
        {
            waitHandle.Set();
        }

        static readonly AutoResetEvent waitHandle = new AutoResetEvent(false);
    }
}
