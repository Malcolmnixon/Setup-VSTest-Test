using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary.Test
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var res = Example.Add(1, 2);
            Assert.AreEqual(3, res);
        }
    }
}
