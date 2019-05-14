using NUnit.Framework;
using Scripts1;
using System.Collections.Generic;
namespace Tests
{
    public class Tests
    {
        
        Assignment1 obj1 =new Assignment1();
        Assignment2 obj2 = new Assignment2();
        Assignment3 obj3= new Assignment3();
        Assignment4 obj4 = new Assignment4();
        Assignment5 obj5 = new Assignment5();
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
        [Test]
        public void Test5()
        {
            List<int> lst = new List<int>();
            lst.Add(2);
            lst.Add(1);
            lst.Add(3);
            lst.Add(7);
            lst.Add(5);
            lst.Add(4);
            int output = obj3.findSecondMaxInt(lst);
            Assert.AreEqual(5,output);
        }
        [Test]
        public void Test6()
        {
            int input = 5;
            obj4.UsingDelegate(input);
        }
        [Test]
        public void Test7()
        {
            int principal=3000,interestRate=12,tenure=12;
            int interest=obj5.CalculateInterest(principal,interestRate,tenure);
            Assert.AreEqual(4320,interest);

        }
    }
}