using Addition;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Sum sum;
        [TestMethod]
        public void TestMethod1()
        {
            //A-> Arrangement A->Act A->Assert
            //Arrangement
            sum = new Sum();
            //ACt
            var result = sum.Add(5, 10);
            Assert.AreEqual(15, result);
        }
    }
}