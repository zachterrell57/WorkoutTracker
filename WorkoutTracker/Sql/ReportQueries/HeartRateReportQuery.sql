SELECT TOP 5 W.AvgHeartRate, 
		DM.Date	
FROM Project.Session S
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
	INNER JOIN Project.Workout W ON S.SessionID = W.SessionID
ORDER BY W.AvgHeartRate DESC