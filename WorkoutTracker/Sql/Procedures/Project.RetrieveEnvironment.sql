CREATE OR ALTER PROCEDURE Project.RetrieveEnvironment
   @EnvironmentID INT
AS

SELECT E.IsIndoor
FROM Project.Environment E
WHERE E.EnvironmentID = @EnvironmentID;
GO
