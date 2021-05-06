CREATE OR ALTER PROCEDURE Project.CreateSession
   @StartTime NVARCHAR(32),
   @EndTime NVARCHAR(32),
   @Rating FLOAT,
   @SessionID INT OUTPUT,
   @MetricID INT OUTPUT,
   @EnvironmentID INT OUTPUT 
AS

INSERT Project.Session(MetricID, EnvironmentID, StartTime, EndTime, Rating)
VALUES(@MetricID, @EnvironmentID, @StartTime, @EndTime, @Rating);

SET @SessionID = SCOPE_IDENTITY(); 

GO

