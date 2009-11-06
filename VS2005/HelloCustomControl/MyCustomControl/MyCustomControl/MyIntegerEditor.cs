using System;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace MyCustomControl
{
    class MyIntegerEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService frmsvr =(IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            frmsvr.ShowDialog(new FrmEditor());
            return 1213;
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

    }
}
