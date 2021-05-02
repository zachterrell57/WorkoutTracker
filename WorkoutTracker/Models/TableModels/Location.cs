using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class Location
    {
        public int LocationID { get; }
        public string Name { get; }

        internal Location(int l, string n)
        {
            LocationID = l;
            Name = n;
        }
    }
}
