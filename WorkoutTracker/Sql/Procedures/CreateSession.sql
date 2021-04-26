CREATE OR ALTER PROCEDURE Project.CreateSession
   @StartTime NVARCHAR(32),
   @EndTime NVARCHAR(32),
   @Rating FLOAT,
   @SessionID INT OUTPUT,
   @MetricID INT OUTPUT,
   @EnvironmentID INT OUTPUT 
AS

INSERT Project.CreateSession(StartTime, EndTime, Rating)
VALUES(@StartTime, @EndTime, @Rating);

SET @SessionID = SCOPE_IDENTITY(); 
SET @MetricID = SCOPE_IDENTITY(); 
SET @EnvironmentID = SCOPE_IDENTITY(); 
GO

