CREATE OR ALTER PROCEDURE Project.CreateSession
   @StartTime NVARCHAR(32),
   @EndTime NVARCHAR(32),
   @Rating FLOAT,
   @SessionID INT OUTPUT,
   @MetricID INT OUTPUT,
   @EnvironmentID INT OUTPUT 
AS

INSERT Project.DailyMetrics(Date, Weight, SleepDuration, Calories)
VALUES(@Date, @Weight, @SleepDuration, @Calories);

SET @SessionID = SCOPE_IDENTITY();
SET @MetricID = SCOPE_IDENTITY();
SET @EnvironmentID = SCOPE_IDENTITY();
GO

