-- compare the rating all sunny outdoor workouts with rainy indoor workouts 

SELECT S.Rating AS 'Rating', W.WeatherType AS 'Weather Type'
FROM Project.Session S
	INNER JOIN Project.Environment E ON S.EnvironmentID = E.EnvironmentID
	INNER JOIN Project.Weather W ON E.WeatherID = W.WeatherID
WHERE W.WeatherType = 'Sunny' AND W.WeatherType = 'Rainy'