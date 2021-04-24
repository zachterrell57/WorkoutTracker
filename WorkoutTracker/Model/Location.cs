﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Model
{
    public class Location
    {
        public int LocationID { get; }

        public int Name { get; }

        internal Location(int l, int n)
        {
            LocationID = l;
            Name = n;
        }


    }
}
