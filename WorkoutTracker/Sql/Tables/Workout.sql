IF OBJECT_ID(N'Project.Workout') IS NULL
BEGIN
    CREATE TABLE Project.Workout
    (   
        WorkoutID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        SessionID INT NOT NULL FOREIGN KEY REFERENCES Project.Session(SessionID),   
       -- GroupNameID INT NOT NULL FOREIGN KEY REFERENCES Project.MuscleGroup(GroupNameID),--
        Duration FLOAT NOT NULL, --Out of mins, hours?-- 
        --MuscleGroup NVARCHAR(32) NOT NULL,--
        AvgHeartRate FLOAT NOT NULL
    );
END;