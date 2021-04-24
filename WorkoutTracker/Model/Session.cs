﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace WorkoutTracker.Model
{
    public class Session
    {
        public int SessionID { get; set; }
        public int MetricID { get; set; }
        public int EnvironmentID { get; set; }
        public SqlDateTime StartTime { get; set; }
        public SqlDateTime EndTime { get; set; }
        public int Rating { get; set; }        

        internal Session(int sID, int mID, int eID, SqlDateTime st, SqlDateTime et, int r)
        {
            SessionID = sID;
            MetricID = mID;
            EnvironmentID = eID;
            StartTime = st;
            EndTime = et;
            Rating = r;
        }
    }
}
