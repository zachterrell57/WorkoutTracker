CREATE OR ALTER PROCEDURE Project.RetrieveWeather
   @WeatherID INT
AS

SELECT W.WeatherType
FROM Project.Weather W
WHERE W.WeatherID = @WeatherID;
GO

