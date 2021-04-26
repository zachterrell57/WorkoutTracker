CREATE OR ALTER PROCEDURE Project.CreateWorkout
   @Duration FLOAT,
   @AvgHeartRate FLOAT,
   @WorkoutID INT,
   @SessionID INT

AS

INSERT Project.Workout(Duration, AvgHeartRate)
VALUES(@Duration, @AvgHeartRate);

SET @WorkoutID = SCOPE_IDENTITY();
SET @SessionID = SCOPE_IDENTITY();
GO

