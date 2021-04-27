CREATE OR ALTER PROCEDURE Project.RetrieveSession
   @SessionID INT
AS

SELECT S.StartTime, S.EndTime, S.Rating
FROM Project.Session S
WHERE S@SessionID = @SessionID;
GO

