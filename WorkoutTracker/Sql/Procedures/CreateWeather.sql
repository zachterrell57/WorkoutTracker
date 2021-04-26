CREATE OR ALTER PROCEDURE Project.CreateWeather
   @Type NVARCHAR(32)
AS

INSERT Project.DailyMetrics(Type)
VALUES(@Type);

SET @WeatherID = SCOPE_IDENTITY();
GO

