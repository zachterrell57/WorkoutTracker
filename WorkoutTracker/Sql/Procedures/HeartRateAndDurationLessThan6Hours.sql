-- The average (average) heart rate and average duration of all indoor sessions with less than 6 hours of sleep
CREATE OR ALTER PROCEDURE Project.HeartRateAndDurationLessThan6Hours 
AS

SELECT AVG(W.AvgHeartRate) AS 'AvgHeartRate', AVG(W.Duration) AS 'Duration'
FROM Project.Session S 
	INNER JOIN Project.Environment E ON S.EnvironmentID = E.EnvironmentID
	INNER JOIN Project.Workout W ON S.SessionID = W.SessionID
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
WHERE DM.SleepDuration <= 6 AND E.IsIndoor = 1