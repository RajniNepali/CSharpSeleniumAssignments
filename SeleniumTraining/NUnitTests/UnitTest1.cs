using NUnit.Framework;
using Scripts;
namespace Tests
{
    public class Tests
    {
        private const bool Obj = true;
        Class1 c1 = new Class1();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var ret=c1.testCond();
            if(ret.Equals(Obj))
            Assert.Pass();
            else
            Assert.Fail();
        }
    }
}