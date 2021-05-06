CREATE OR ALTER PROCEDURE Project.CreateWeather
   @WeatherType NVARCHAR(32),
   @WeatherID INT OUTPUT
AS

INSERT Project.Weather(WeatherType)
VALUES(@WeatherType);

SET @WeatherID = SCOPE_IDENTITY();
GO

