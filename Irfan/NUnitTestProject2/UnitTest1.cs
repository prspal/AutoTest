using NUnit.Framework;

namespace NUnitTestProject2
{
    [TestFixture]
    public class Tests
    {
        Calc c = null;
        [SetUp]
        public void Setup()
        {
            c = new Calc();
        }

        [TestCase(6, 3, TestName = "Divide1", Description = "Test divide1")]
        [TestCase(6, 0, TestName = "Divide2", Description = "Test divide2")]
        public void Divide(int x,int y)
        {
           // int x = 6;
           // int y = 3;
            if (y == 0)
            {
                Assert.False(y==0,"Number cannot divide by zero");
            }else
            {
                float res = c.Div(x, y);
                Assert.AreEqual((x / y), res, "Fail");
            }
        }
    }
}