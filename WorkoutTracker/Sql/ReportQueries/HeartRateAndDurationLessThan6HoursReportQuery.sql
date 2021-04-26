-- The average (average) heart rate and duration of all indoor sessions with less than 6 hours

SELECT AVG(W.AvgHeartRate) AS 'Average Heart Rate', AVG(W.Duration) AS 'Average Duration'
FROM Project.Session S 
	INNER JOIN Project.Environment E ON S.EnviornmentID = E.EnvironmentID
	INNER JOIN Project.Workout W ON S.SessionID = W.SessionID
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
WHERE DM.SleepDuration <= 6