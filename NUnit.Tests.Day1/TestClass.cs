// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Apr28
{
    [TestFixture]
    public class TestClass
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Fin()
        {

        }

        [Test]
        public void TestMethod0()
        {
            // TODO: Add your test code here
            var answer = 53;

            Assert.Multiple(() =>
            {
                Assert.That(answer, Is.EqualTo(53), "Some useful error message");
                Console.WriteLine("######################################################333");
            Assert.AreEqual(answer, 53, "NUmbers are not equeal");
            });
        }  



        [TestCase (43, TestName = "TestMethod1", Description = "Test Descr for Method1")]
        [TestCase (63, TestName = "TestMethod2", Description = "Test Descr for Method2")]
        public void TestMethod(int answer )
        {
            // TODO: Add your test code here
            //var answer = 43;

            //Assert.Multiple(() =>
            //{
                Assert.That(answer, Is.EqualTo(43), "Some useful error message");
                Assert.AreEqual(answer, 43, "NUmbers are not equeal");
            //});
        }
    }
}
