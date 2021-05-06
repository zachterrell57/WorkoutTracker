CREATE OR ALTER PROCEDURE Project.CreateEnvironment          
   @EnvironmentID INT OUTPUT,
   @WeatherID INT OUTPUT,
   @LocationID INT OUTPUT,
   @IsIndoor INT
AS

INSERT Project.Environment(WeatherID, LocationID, IsIndoor)
VALUES(@WeatherID, @LocationID, @IsIndoor);

SET @EnvironmentID = SCOPE_IDENTITY();

GO

