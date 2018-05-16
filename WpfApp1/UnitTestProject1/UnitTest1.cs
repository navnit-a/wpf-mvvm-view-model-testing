using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.ViewModel;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CoolViewModel coolView = new CoolViewModel();
            coolView.ClickCommand.Execute(null);

            Assert.AreEqual("asdsa", coolView.CoolModel.Message);
        }
    }
}
