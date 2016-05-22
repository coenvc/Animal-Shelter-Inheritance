using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_Shelter.Animals;

namespace Unit_Test_Animal_Shelter.Animals
{
    [TestClass]
    public class CatTest
    {
        private Cat cat;

        [TestInitialize]
        public void TestInitialize()
        {
            this.cat = new Cat("Ms. Meow", Gender.Female, "Scratches couch");
        }

        [TestMethod]
        public void TestConstructor()
        {
            Assert.AreEqual("Ms. Meow", this.cat.Name);
            Assert.AreEqual(Gender.Female, this.cat.Gender);
            Assert.IsNull(this.cat.ReservedBy);
            Assert.AreEqual("Scratches couch", this.cat.BadHabits);
        }

        [TestMethod]
        public void TestReservation()
        {
            Assert.IsNull(this.cat.ReservedBy);
            Assert.IsTrue(this.cat.Reserve("John Doe"));
            Assert.IsNotNull(this.cat.ReservedBy);
            Assert.AreEqual("John Doe", this.cat.ReservedBy.Name);
            Assert.IsFalse(this.cat.Reserve("Jane Doe"));
        }


        [TestMethod]
        public void TestReservationTime()
        {
            // TODO: Implement this when interfaces have been explained.
            // We don't yet test the reserved time because it used the current
            // system clock to determine the result. Therefore we cannot check
            // if the values are the same, since two consecutive calls to
            // DateTime.Now are very likely to give different results. There is
            // a way to account for this, but the solution will use interfaces:
            // a concept that is not yet discussed in class. To be implemented.
            Assert.Inconclusive("Implement this when interfaces have been explained");
        }
    }
}
