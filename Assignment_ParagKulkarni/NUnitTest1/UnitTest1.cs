using NUnit.Framework;
using Assignment1;
namespace Tests
{
    public class Tests
    {
        Assignment1 obj1 =new Assignment1();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string output=obj1.toTitleCase();
            if(output.Equals("Csharp Corner Home"))
            Assert.Pass();
            else
            Assert.fail();
        }
    }
}