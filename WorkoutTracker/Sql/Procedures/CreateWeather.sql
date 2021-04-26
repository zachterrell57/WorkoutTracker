CREATE OR ALTER PROCEDURE Project.CreateWeather
   @Type NVARCHAR(32),
   @WeatherID INT OUTPUT
AS

INSERT Project.DailyMetrics(WeatherType)
VALUES(@Weathertype);

SET @WeatherID = SCOPE_IDENTITY();
GO

