using System;

namespace Animal_Shelter.Animals
{
    public class Dog:Animal
    {
        public DateTime LastWalk { get; private set; }
        public bool NeedsWalk
        {
            get
            {
                return (DateTime.Today - this.LastWalk).Days > 0;
            }
        }

        public Dog(string name, Gender gender):base(name, gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.LastWalk = DateTime.Today;
        }

 

        public override string ToString()
        {
            string reserved = "not reserved";
            if (this.ReservedBy != null)
            {
                reserved = $"reserved by {this.ReservedBy.Name}";
            }
            return $"{this.Name}, {this.Gender}, {reserved}, " +
                $"last walk: {this.LastWalk.ToShortDateString()}";
        }
    }
}
