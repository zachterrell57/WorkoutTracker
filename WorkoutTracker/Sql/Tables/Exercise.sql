IF OBJECT_ID(N'Project.Exercise') IS NULL
BEGIN
    CREATE TABLE Project.Exercise
    (   
        ExerciseID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Name NVARCHAR(32) NOT NULL,
        MuscleGroup NVARCHAR(32)
    );
END;