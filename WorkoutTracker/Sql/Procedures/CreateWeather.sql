CREATE OR ALTER PROCEDURE Project.CreateWeather
   @WeatherType NVARCHAR(32),
   @WeatherID INT OUTPUT
AS

INSERT Project.Weather(WeatherType)
VALUES(@Weathertype);

SET @WeatherID = SCOPE_IDENTITY();
GO

