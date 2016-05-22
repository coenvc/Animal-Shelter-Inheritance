using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Animals
{
    public  interface IAnimal
    {
         string Name { get; set; }
         Gender Gender { get; set; }
         Reservor ReservedBy { get; set; }


        bool Reserve(string reservedBy);
    }
}
