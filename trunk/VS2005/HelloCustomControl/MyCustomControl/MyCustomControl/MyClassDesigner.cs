using System;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Windows.Forms.Design;


namespace MyCustomControl
{
    class MyClassDesigner : ControlDesigner
    {
        private DesignerVerbCollection actions;

        public override DesignerVerbCollection Verbs
        {
			get
			{
				if(actions == null)
				{
					actions = new DesignerVerbCollection();
					actions.Add(new DesignerVerb("Look and Feel", new EventHandler(ChangeDisplay)));
				}
				return actions;
			}
        }

        void ChangeDisplay(object sender, EventArgs e)
        {
            //Control.BackColor = Color.Chocolate;
            FrmEditor formt = new FrmEditor();
            formt.ShowDialog();
            //Control.Parent.BackColor = Color.Black;
        }

    }
}
