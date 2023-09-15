
using _7Uzduotis_Debug;
namespace TestRef1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSwap()
        {
            int x = 1;
            int y = 2;
            int expectedx = 2;
            int expectedy = 1;

            Program.Swap(ref x, ref y);

            Assert.AreEqual(expectedx, x);
            Assert.AreEqual(expectedy, y);

        }
    }
}