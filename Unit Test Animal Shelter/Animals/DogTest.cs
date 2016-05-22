using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_Shelter.Animals;

namespace Unit_Test_Animal_Shelter.Animals
{
    [TestClass]
    public class DogTest
    {
        private Dog dog;

        [TestInitialize]
        public void TestInitialize()
        {
            this.dog = new Dog("Sgt. Woof", Gender.Male);
        }

        [TestMethod]
        public void TestConstructor()
        {
            Assert.AreEqual("Sgt. Woof", this.dog.Name);
            Assert.AreEqual(Gender.Male, this.dog.Gender);
            Assert.IsNull(this.dog.ReservedBy);
            Assert.AreEqual(DateTime.Today, this.dog.LastWalk);
            Assert.IsFalse(this.dog.NeedsWalk);
        }

        [TestMethod]
        public void TestReservation()
        {
            Assert.IsNull(this.dog.ReservedBy);
            Assert.IsTrue(this.dog.Reserve("John Doe"));
            Assert.IsNotNull(this.dog.ReservedBy);
            Assert.AreEqual("John Doe", this.dog.ReservedBy.Name);
            Assert.IsFalse(this.dog.Reserve("Jane Doe"));
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
