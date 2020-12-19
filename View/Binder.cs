using AsyncParrallelSample.ViewModel;
using System.Windows.Forms;

namespace AsyncParrallelSample.View
{
    /// <summary>
    /// Binder Utility class.(Base)
    /// </summary>
    public static partial class Binder
    {
        /// <summary>
        /// data binding.
        /// </summary>
        /// <typeparam name="T">biding object</typeparam>
        /// <param name="controller">Form controller</param>
        /// <param name="propertyName">Controller propertyName</param>
        /// <param name="bindObject">Binding object</param>
        /// <param name="bindPropertyName">Binding object propertyName</param>
        private static void bindModel<T>(Control controller, string propertyName, T bindObject, string bindPropertyName)
        {
            controller.DataBindings.Add(propertyName, bindObject, bindPropertyName, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }

    /// <summary>
    /// Binder Utility class.(TextBox)
    /// </summary>
    public static partial class Binder
    {
        /// <summary>
        /// data binding.
        /// </summary>
        /// <typeparam name="T">biding object</typeparam>
        /// <param name="txtBox">TextBox controller</param>
        /// <param name="propertyName">Controller propertyName</param>
        /// <param name="bindObject">Binding object</param>
        /// <param name="bindPropertyName">Binding object propertyName</param>
        public static void Bind<T>(this TextBox txtBox, string propertyName, T bindObject, string bindPropertyName)
        {
            bindModel(txtBox, propertyName, bindObject, bindPropertyName);
        }
    }

    /// <summary>
    /// Binder Utility class.(Panel)
    /// </summary>
    public static partial class Binder
    {
        /// <summary>
        /// data binding.
        /// </summary>
        /// <typeparam name="T">biding object</typeparam>
        /// <param name="panel">Panel</param>
        /// <param name="propertyName">Controller propertyName</param>
        /// <param name="bindObject">Binding object</param>
        /// <param name="bindPropertyName">Binding object propertyName</param>
        public static void Bind<T>(this Panel panel, string propertyName, T bindObject, string bindPropertyName)
        {
            bindModel(panel, propertyName, bindObject, bindPropertyName);
        }
    }

    /// <summary>
    /// Binder Utility class.
    /// </summary>
    public static partial class Binder
    {
        /// <summary>
        /// data binding.
        /// </summary>
        /// <param name="button">Button</param>
        /// <param name="command">bind command.</param>
        public static void Bind(this Button button, Command command)
        {
            button.Click += command.Execute;
        }
    }

    /// <summary>
    /// Binder Utility class.
    /// </summary>
    public static partial class Binder
    {
        /// <summary>
        /// data binding.
        /// </summary>
        /// <typeparam name="T">biding object</typeparam>
        /// <param name="cmbBox">ComboBox</param>
        /// <param name="propertyName">Controller propertyName</param>
        /// <param name="bindObject">Binding object</param>
        /// <param name="bindPropertyName">Binding object propertyName</param>
        public static void Bind<T>(this ComboBox cmbBox, string propertyName, T bindObject, string bindPropertyName)
        {
            bindModel(cmbBox, propertyName, bindObject, bindPropertyName);
        }
    }
}
