using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_Shelter.Animals;

namespace Unit_Test_Animal_Shelter.Animals
{
    [TestClass]
    public class ReservorTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            DateTime reservedAt = DateTime.Now;
            Reservor reservor = new Reservor("John Doe", reservedAt);
            Assert.AreEqual("John Doe", reservor.Name);
            Assert.AreEqual(reservedAt, reservor.ReservedAt);
        }
    }
}
