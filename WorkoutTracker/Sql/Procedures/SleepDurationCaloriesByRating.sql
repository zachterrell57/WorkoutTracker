--Sleep Duration and Calories in all sessions where rating was greater than 8, ordered by date 
CREATE OR ALTER PROCEDURE Project.SleepDurationCaloriesByRating
AS

SELECT DM.SleepDuration, DM.Calories, DM.Date
FROM Project.Session S	
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
WHERE S.Rating > 8
ORDER BY DM.Date DESC