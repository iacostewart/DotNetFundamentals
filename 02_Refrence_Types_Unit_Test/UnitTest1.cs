using System;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Refrence_Types;

namespace _02_Refrence_Types_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer Frank = new Customer();
            Frank.FirstName = "frank";
            Frank.Email = "dude@dude.com";
            Frank.PhoneNumber = "123";

            // Arraange 
            // this is where we set up things up 
             var   expected = "frank";
            // Act 
            // this is where we are doing sonmeting.. calling a method.. business logic.. 
             var actual = Frank.FirstName;
      
            // Assert 
            Assert.AreEqual(expected, actual);
            // Arrange 



        }
    }
}
