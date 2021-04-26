CREATE OR ALTER PROCEDURE Project.CreateLocation
   @Name NVARCHAR(32),
   @LocationID INT OUTPUT
AS

INSERT Project.Location(Name)
VALUES(@Name);

SET @LocationID = SCOPE_IDENTITY();

GO

