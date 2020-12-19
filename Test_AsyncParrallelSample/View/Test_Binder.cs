using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsyncParrallelSample.View;
using System.Windows.Forms;
using Test_AsyncParrallelSample.Test;

namespace Test_AsyncParrallelSample.View
{
    /// <summary>
    /// Test_Binder
    /// </summary>
    [TestClass]
    public class Test_Binder
    {
        [TestMethod]
        public void TestTextBoxBind()
        {
            // setup
            var txtBox = new TextBox();
            var bindingObj = new TestObject();

            txtBox.Bind(nameof(TextBox.Text), bindingObj, nameof(TestObject.Text));
            txtBox.Text.Is(string.Empty);
        }

        [TestMethod]
        public void TestPanelBind()
        {
            // setup
            var panel = new Panel();
            var bindingObj = new TestObject();

            panel.Bind(nameof(Panel.Name), bindingObj, nameof(TestObject.Text));
            panel.Name.Is(string.Empty);
        }
    }
}
