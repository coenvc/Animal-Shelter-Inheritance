using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Animals
{
    public abstract class Animal:IAnimal
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Reservor ReservedBy { get; set;}

        public Animal(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
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
    }
}
