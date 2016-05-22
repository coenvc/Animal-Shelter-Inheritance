using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Animals
{
    public class Reservor
    {
        public string Name { get; private set; }
        public DateTime ReservedAt { get; private set; }

        public Reservor(string name, DateTime reservedAt)
        {
            this.Name = name;
            this.ReservedAt = reservedAt;
        }
    }
}
