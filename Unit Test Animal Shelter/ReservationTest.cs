using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_Shelter;
using Animal_Shelter.Animals;

namespace Unit_Test_Animal_Shelter
{
    [TestClass]
    public class ReservationTest
    {
        private Reservation reservation;

        [TestInitialize]
        public void TestInitialize()
        {
            this.reservation = new Reservation();
        }

        [TestMethod]
        public void TestNewCat()
        {
            Assert.IsNull(this.reservation.Cat);
            Assert.IsNull(this.reservation.Dog);

            this.reservation.NewCat("Ms. Meow", Gender.Female, "Scratches couch");
            Assert.IsNotNull(this.reservation.Cat);
            Assert.IsNull(this.reservation.Dog);
        }

        [TestMethod]
        public void TestNewDog()
        {
            Assert.IsNull(this.reservation.Cat);
            Assert.IsNull(this.reservation.Dog);

            this.reservation.NewDog("Sgt. Woof", Gender.Male);
            Assert.IsNull(this.reservation.Cat);
            Assert.IsNotNull(this.reservation.Dog);
        }
    }
}
