using AsyncParrallelSample.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_AsyncParrallelSample.ViewModel
{
    /// <summary>
    /// Test_Command
    /// </summary>
    [TestClass]
    public class Test_Command
    {
        [TestMethod]
        public void TestNewInstance()
        {
            void localFunc()
            {
                Console.WriteLine("Called.");
            }

            var testCases = new[]
            {
                new { Cmd = new Command(localFunc), ExpectedName = nameof(Command), ExpectedDesc = string.Empty },
                new { Cmd = new Command("Sample", localFunc), ExpectedName = "Sample", ExpectedDesc = string.Empty },
            };

            foreach(var tc in testCases)
            {
                tc.Cmd.Name.Is(tc.ExpectedName);
                tc.Cmd.Description.Is(tc.ExpectedDesc);
                tc.Cmd.ToString().Is(tc.ExpectedName);
                tc.Cmd.Execute();
            }
        }
    }
}
