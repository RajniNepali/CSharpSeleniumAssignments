using NUnit.Framework;
using Scripts1;
namespace Tests
{
    public class Tests
    {
        
        Assignment1 obj1 =new Assignment1();
        Assignment2 obj2 = new Assignment2();
        [SetUp]
        public void Setup()
        {
        }

        [Test]////Assignment1.cs
        public void Test1()
        {
            string input = "csharp Corner Home";
            string output=obj1.toTitleCase(input);
            Assert.AreEqual(output,"Csharp Corner Home");
        }
        [Test]//Assignment1.cs
        public void Test2()
        {
            string input = "csharp Corner Home";
            string output = obj1.ToCamelCaseFunc(input);
            Assert.AreEqual(output,"csharpCornerHome");
        }
        [Test]
        public void Test3()
        {
            string input = "csharp Corner Home";
            int wordcount=obj2.CountWords(input);
            Assert.AreEqual(wordcount,3);
        }
        [Test]
        public void Test4()
        {
            string input = "csharp Corner Home dehfsd Corner csharp";
            int count=obj2.CountDistinctWords(input);
            Assert.AreEqual(4,count);                                                                                                                                           
        }
    }
}