using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary.Computer;

namespace TestLibraryTests.QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void Method1()
        {
            CustomQueue cq = new CustomQueue();
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);

            Assert.AreEqual(3, cq.Count, 0);

            var tmp = cq.GetItem();
            Assert.AreEqual(3, tmp.Length);

        }
    }
}
