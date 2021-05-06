CREATE OR ALTER PROCEDURE Project.RetrieveWorkouts
@Filter NVARCHAR(32)
AS


SELECT 
	S.StartTime, S.EndTime, S.Rating,
	DM.Date, DM.Weight, DM.SleepDuration, DM.Calories,
	WO.Duration, WO.AvgHeartRate,
	E.IsIndoor,
	W.WeatherType,
	L.Name
			
FROM Project.Session S
	INNER JOIN Project.Workout WO ON S.SessionID = WO.SessionID
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
	INNER JOIN Project.Environment E ON S.EnvironmentID = E.EnvironmentID
	INNER JOIN Project.Weather W ON E.WeatherID = W.WeatherID
	INNER JOIN Project.Location L ON E.LocationID = L.LocationID
ORDER BY CASE WHEN @Filter='StartTime' THEN S.StartTime END DESC,
		 CASE WHEN @Filter='EndTime' THEN S.EndTime END DESC,
		 CASE WHEN @Filter='Rating' THEN S.Rating END DESC,
		 CASE WHEN @Filter='Date' THEN DM.Date END DESC,
		 CASE WHEN @Filter='Weight' THEN DM.Weight END DESC,
		 CASE WHEN @Filter='SleepDuration' THEN DM.SleepDuration END DESC,
		 CASE WHEN @Filter='Calories' THEN DM.Calories END DESC,
		 CASE WHEN @Filter='Duration' THEN WO.Duration END DESC,
		 CASE WHEN @Filter='AvgHeartRate' THEN WO.AvgHeartRate END DESC,
		 CASE WHEN @Filter='IsIndoor' THEN E.IsIndoor END DESC,
		 CASE WHEN @Filter='WeatherType' THEN W.WeatherType END DESC,
		 CASE WHEN @Filter='Location' THEN L.Name END DESC
