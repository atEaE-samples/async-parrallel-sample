using AsyncParrallelSample.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_AsyncParrallelSample.ViewModel
{
    [TestClass]
    public class Test_MainViewModel
    {
        [TestMethod]
        public void TestNewInstance()
        {
            // setup
            var mainVM = new MainViewModel();

            // expected
            var expectedDefaultRunTasks = "608";
            var expectedDefaultTaskTime = "300";
            var expectedDefaultErrorRate = "5";

            mainVM.RunTasks.Is(expectedDefaultRunTasks);
            mainVM.TaskTime.Is(expectedDefaultTaskTime);
            mainVM.ErrorRate.Is(expectedDefaultErrorRate);
        }
    }
}
