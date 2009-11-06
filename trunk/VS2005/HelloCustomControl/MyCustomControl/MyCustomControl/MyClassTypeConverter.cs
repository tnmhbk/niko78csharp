using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MyCustomControl
{
    class MyClassTypeConverter : System.ComponentModel.TypeConverter
    {
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context,object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(MyClassType));
        }
    }
}
