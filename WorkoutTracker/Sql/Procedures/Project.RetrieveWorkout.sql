CREATE OR ALTER PROCEDURE Project.RetrieveWorkout
   @WorkoutID INT
AS

SELECT W.Duration, W.AvgHeartRate
FROM Project.Weather W
WHERE W.WorkoutID = @WorkoutID;
GO

