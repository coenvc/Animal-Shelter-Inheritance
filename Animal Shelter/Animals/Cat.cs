using System;
using System.Diagnostics.Contracts;

namespace Animal_Shelter.Animals
{
    public class Cat:Animal
    {
        public string BadHabits { get; private set; }

        public Cat(string name, Gender gender, string badHabits):base(name,gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.BadHabits = badHabits;
        }


        public override string ToString()
        {
            string reserved = "not reserved";
            if (this.ReservedBy != null)
            {
                reserved = $"reserved by {this.ReservedBy.Name}";
            }
            return $"{this.Name}, {this.Gender}, " +
                $"{reserved}, bad habits: {this.BadHabits.ToLower()}";
        }
    }
}
