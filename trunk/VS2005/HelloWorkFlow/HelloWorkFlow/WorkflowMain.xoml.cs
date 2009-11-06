using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace HelloWorkFlow
{
	public partial class WorkflowMain : SequentialWorkflowActivity
	{
        private bool _isFixed=false;
        public static DependencyProperty whileActivity1_Condition1Event = DependencyProperty.Register("whileActivity1_Condition1", typeof(System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>), typeof(HelloWorkFlow.WorkflowMain));
        public EventHandler<ConditionalEventArgs> whileActivity1_Condition2 = default(System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>);

	    public bool IsFixed
	    {
	        get { return _isFixed; }
	        set { _isFixed = value; }
	    }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("Is the bug fixed?");
            if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
            {
                _isFixed = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Get back to work!");
                Console.WriteLine();
                Console.Clear();
            }
        }

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Handlers")]
        public event EventHandler<ConditionalEventArgs> whileActivity1_Condition1
        {
            add
            {
                base.AddHandler(whileActivity1_Condition1Event, value);
            }
            remove
            {
                base.RemoveHandler(whileActivity1_Condition1Event, value);
            }
        }

        private void WorkflowMain_Initialized(object sender, EventArgs e)
        {
            whileActivity1_Condition1 += delegate(object sender1, ConditionalEventArgs e1) { e1.Result = !_isFixed; };
        }
	}
}
