IF OBJECT_ID(N'Project.Workout') IS NULL
BEGIN
    CREATE TABLE Project.Workout
    (   
        WorkoutID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        SessionID INT NOT NULL,       
        Duration FLOAT NOT NULL,     
        AvgHeartRate FLOAT NOT NULL

		CONSTRAINT FK_Project_Workout_Project_Session FOREIGN KEY(SessionID)
		REFERENCES Project.Session(SessionID),
    );
END;