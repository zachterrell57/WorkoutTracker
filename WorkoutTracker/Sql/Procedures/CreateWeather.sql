CREATE OR ALTER PROCEDURE Project.CreateWeather
   @Type NVARCHAR(32),
   @WeatherID INT 
AS

INSERT Project.DailyMetrics(Type)
VALUES(@Type);

SET @WeatherID = SCOPE_IDENTITY();
GO

