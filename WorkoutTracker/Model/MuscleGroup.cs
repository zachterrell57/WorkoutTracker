using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Model
{

    public class MuscleGroup
    {
        public int GroupNameID { get; set; }

        public MuscleType GroupName { get; set; }

        internal MuscleGroup(int gnID, MuscleType gn)
        {
            GroupNameID = gnID;
            GroupName = gn;
        }
    }
}
