using System;
using System.Diagnostics.Contracts;

namespace Animal_Shelter.Animals
{
    public class Cat
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Reservor ReservedBy { get; private set; }
        public string BadHabits { get; private set; }

        public Cat(string name, Gender gender, string badHabits)
        {
            this.Name = name;
            this.Gender = gender;
            this.BadHabits = badHabits;
        }

        public bool Reserve(string reservedBy)
        {
            if (this.ReservedBy == null)
            {
                this.ReservedBy = new Reservor(reservedBy, DateTime.Now);
                return true;
            }
            return false;
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
