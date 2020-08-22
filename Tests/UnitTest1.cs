using System;
using ConsoleApp.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Classes;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person();
            person.Age = 19;
            Console.WriteLine("Person is 21: " + person.IsAtLeast21);
        }

    }
}
