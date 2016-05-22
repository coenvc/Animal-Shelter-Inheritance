using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_Shelter.Animals;

namespace Animal_Shelter
{
    public class Reservation
    {
        public Cat Cat { get; private set; }
        public Dog Dog { get; private set; }
        
        public void NewCat(string name, Gender gender, string badHabits)
        {
            this.Cat = new Cat(name, gender, badHabits);
        }
        
        public void NewDog(string name, Gender gender)
        {
            this.Dog = new Dog(name, gender);
        }
    }
}
