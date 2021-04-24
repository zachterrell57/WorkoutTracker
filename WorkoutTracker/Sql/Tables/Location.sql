IF OBJECT_ID(N'Project.Location') IS NULL
BEGIN
    CREATE TABLE Project.Location
    (   
        LocationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Name NVARCHAR(32) NOT NULL
    );
END;