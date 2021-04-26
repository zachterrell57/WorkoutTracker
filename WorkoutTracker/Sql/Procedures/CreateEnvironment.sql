CREATE OR ALTER PROCEDURE Project.CreateEnvironment
   @IsIndoor INT,         
   @EnvironmentID INT OUTPUT,
   @WeatherID INT OUTPUT,
   @LocationID INT OUTPUT
AS

INSERT Project.Environment(IsIndoor)
VALUES(@IsIndoor);

SET @EnvironmentID = SCOPE_IDENTITY();
SET @WeatherID = SCOPE_IDENTITY();
SET @LocationID = SCOPE_IDENTITY();

GO

