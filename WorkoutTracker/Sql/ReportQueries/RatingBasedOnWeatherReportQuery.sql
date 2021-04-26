-- compare the rating all sunny outdoor workouts with rainy indoor workouts 

SELECT S.Rating AS 'Rating'
FROM Project.Session S
	INNER JOIN Project.Environment E ON S.EnviornmentID = E.EnvironmentID
	INNER JOIN Project.Weather W ON E.WeatherID = W.WeatherID
