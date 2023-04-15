using Assignment;
using NUnit.Framework;
using System;

namespace ClassLib_project.Tests
{
    public class Tests
    {
        SUV_TESTS suv;
        [SetUp]
        public void Setup()
        {
            suv = new SUV_TESTS();
        }

        [Test]
        public void Test1()
        {
            var res = suv.IsLeap(2004);
            //Assert.IsInstanceOf(typeof(int),res);
            bool res2;
            if (res == -1)
            {
                res2 = false;
            }
            else
            {s
                res2 = true;
            }
            Assert.That(res2, Is.True);
        }

        [Test]
        public void Test2()
        {
            var res = suv.IsLeap(100);

            Assert.That(res, Is.True);

        }


    }
}