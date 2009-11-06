using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MyCustomControl
{
    [TypeConverter(typeof(MyClassTypeConverter))]
    public class MyClassType
    {
        private int _valueInt;

        public int ValueInt
        {
            get { return _valueInt; }
            set { _valueInt = value; }
        }

        private string _valueString;

        public string ValueString
        {
            get { return _valueString; }
            set { _valueString = value; }
        }
    }
}
