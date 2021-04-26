--Sleep Duration and Calories in all sessions where rating was 10, ordered by date 

SELECT DM.SleepDuration, DM.Calories, DM.Date
FROM Project.Session S	
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
WHERE S.Rating = 10
ORDER BY DM.Date DESC