IF OBJECT_ID(N'Project.ExerciseMuscleGroup') IS NULL
BEGIN
    CREATE TABLE Project.ExerciseMuscleGroup
    (   
        ExerciseID INT NOT NULL FOREIGN KEY REFERENCES Project.Exercise(ExerciseID),
        GroupNameID INT NOT NULL FOREIGN KEY REFERENCES Project.MuscleGroup(GroupNameID),   
        Name NVARCHAR(32) NOT NULL,
        MuscleGroup NVARCHAR(32),

        PRIMARY KEY
        (
            ExerciseID,
            GroupNameID
        )
    );
END;