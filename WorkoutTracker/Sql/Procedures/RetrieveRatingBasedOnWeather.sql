-- compare the rating all sunny outdoor workouts with rainy indoor workouts, ordered by date 
CREATE OR ALTER PROCEDURE Project.RetrieveRatingBasedOnWeather
AS

SELECT S.Rating, W.WeatherType, DM.Date
FROM Project.Session S
	INNER JOIN Project.DailyMetrics DM ON S.MetricID = DM.MetricID
	INNER JOIN Project.Environment E ON S.EnvironmentID = E.EnvironmentID
	INNER JOIN Project.Weather W ON E.WeatherID = W.WeatherID
WHERE W.WeatherType = 'Sunny' OR W.WeatherType = 'Rainy'
ORDER BY DM.Date
