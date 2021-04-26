CREATE OR ALTER PROCEDURE Project.CreateDailyMetrics
   @Date NVARCHAR(32),
   @Weight FLOAT,
   @SleepDuration FLOAT,
   @Calories FLOAT,
   @MetricID INT OUTPUT
AS

INSERT Project.DailyMetrics(Date, Weight, SleepDuration, Calories)
VALUES(@Date, @Weight, @SleepDuration, @Calories);

SET @MetricID = SCOPE_IDENTITY();
GO

