CREATE OR ALTER PROCEDURE Project.CreateWorkout
   @Duration FLOAT,
   @AvgHeartRate FLOAT,
   @WorkoutID INT OUTPUT,
   @SessionID INT OUTPUT

AS

INSERT Project.Workout(SessionID, Duration, AvgHeartRate)
VALUES(@SessionID, @Duration, @AvgHeartRate);

SET @WorkoutID = SCOPE_IDENTITY();

GO

