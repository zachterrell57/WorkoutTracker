CREATE OR ALTER PROCEDURE Project.RetrieveDailyMetrics
   @MetricID INT
AS

SELECT DM.Date, DM.Weight, DM.SleepDuration, DM.Calories
FROM Project.DailyMetrics DM 
WHERE DM.MetricID = @MetricId;
GO

