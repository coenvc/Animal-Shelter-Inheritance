using System;

namespace Animal_Shelter.Animals
{
    public class Dog
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Reservor ReservedBy { get; private set; }
        public DateTime LastWalk { get; private set; }
        public bool NeedsWalk
        {
            get
            {
                return (DateTime.Today - this.LastWalk).Days > 0;
            }
        }

        public Dog(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.LastWalk = DateTime.Today;
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
            return $"{this.Name}, {this.Gender}, {reserved}, " +
                $"last walk: {this.LastWalk.ToShortDateString()}";
        }
    }
}
