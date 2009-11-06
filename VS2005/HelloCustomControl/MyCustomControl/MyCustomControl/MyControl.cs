using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Design;
using System.Text;

namespace MyCustomControl
{
    //[Designer(typeof(MyClassDesigner))]
    public partial class MyControl : Component
    {
        private int _myInteger;
        private MyClassType _myData= new MyClassType();

        public MyControl()
        {
            InitializeComponent();
        }

        public MyControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Description("Mi editor de entero"),Editor(typeof(MyIntegerEditor),typeof(UITypeEditor))]
        public int MyInteger
        {
            get { return _myInteger; }
            set { _myInteger = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MyClassType MyData
        {
            get { return _myData; }
            set { _myData = value; }
            
        }


    }
}
