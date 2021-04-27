CREATE OR ALTER PROCEDURE Project.RetrieveLocation
   @LocationID INT
AS

SELECT L.Name
FROM Project.Location L
WHERE L.LocationID = @LocationID;
GO
