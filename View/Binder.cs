using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace AsyncParrallelSample.View
{
    public static class Binder
    {
        public static void Bind<T>(Control controller, string propertyName, T bindObject, string bindPropertyName)
        {
            controller.DataBindings.Add(propertyName, bindObject, bindPropertyName, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void BindText<T>(this TextBox txtBox, T bindObject, string bindPropertyName)
        {
            Bind(txtBox, nameof(TextBox.Text), bindObject, bindPropertyName);       
        }
    }
}
