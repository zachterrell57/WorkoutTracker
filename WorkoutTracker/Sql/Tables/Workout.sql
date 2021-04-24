IF OBJECT_ID(N'Project.Workout') IS NULL
BEGIN
    CREATE TABLE Project.Workout
    (   
        WorkoutID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        SessionID INT NOT NULL FOREIGN KEY REFERENCES Project.Session(SessionID),   
        ExerciseID INT NOT NULL FOREIGN KEY REFERENCES Project.Exercise(ExerciseID),
        Duration INT NOT NULL, --Out of mins, hours?-- 
        Sets INT NOT NULL, 
        Reps INT NOT NULL,
        AvgHeartRate INT NOT NULL
    );
END;