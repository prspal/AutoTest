using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Start of class");
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            var st = "Compare of two strings";
            Assert.Multiple(() => 
            {
                Assert.That("Compare of two strings", Is.EqualTo(st), "Strings are equal");
                Assert.AreEqual("compare of two strings", st, "Strings are not equal");
            });
        }
        [TestCase(23, TestName = "Test2", Description = "Test case2")]
        [TestCase(23, TestName = "Test3", Description = "Test case3")]
        public void Test(int ans)
        { 
            //Assert.Pass();
            //int ans = 23;
            //Assert.Multiple(() =>
            //{
                Assert.That(ans, Is.EqualTo(23), "Numbers are equal");
               // Assert.AreEqual(ans, 43, "Numbers are not equal");
            //});
        }
        public void Teardown()
        {
            Console.WriteLine("End of class");;
        }
    }
}