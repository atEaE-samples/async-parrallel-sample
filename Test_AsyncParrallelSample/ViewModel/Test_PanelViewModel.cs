using AsyncParrallelSample.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_AsyncParrallelSample.ViewModel
{
    [TestClass]
    public class Test_PanelViewModel
    {
        [TestMethod]
        public void TestNewInstance()
        {
            var testCases = new[]
            {
                new { PanelVM = new PanelViewModel(height: 7, width: 8), ExpectedHeight = 7, ExpectedWidth = 8, ExpectedLeft = 0, ExpectedTop = 0, ExpectedRight = 0, ExpectedBottom = 0 },
                new { PanelVM = new PanelViewModel(height: 7, width: 8).Padding(all: 1), ExpectedHeight = 7, ExpectedWidth = 8, ExpectedLeft = 1, ExpectedTop = 1, ExpectedRight = 1, ExpectedBottom = 1 },
                new { PanelVM = new PanelViewModel(height: 7, width: 8).Padding(left: 1, top: 2, right: 3, bottom: 4), ExpectedHeight = 7, ExpectedWidth = 8, ExpectedLeft = 1, ExpectedTop = 2, ExpectedRight = 3, ExpectedBottom = 4 }
            };

            foreach(var tc in testCases)
            {
                tc.PanelVM.Height.Is(tc.ExpectedHeight);
                tc.PanelVM.Width.Is(tc.ExpectedWidth);

                tc.PanelVM.PaddingLeft.Is(tc.ExpectedLeft);
                tc.PanelVM.PaddingTop.Is(tc.ExpectedTop);
                tc.PanelVM.PaddingRight.Is(tc.ExpectedRight);
                tc.PanelVM.PaddingBottom.Is(tc.ExpectedBottom);
            }
        }
    }
}
