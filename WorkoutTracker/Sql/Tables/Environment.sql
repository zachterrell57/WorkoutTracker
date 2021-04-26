IF OBJECT_ID(N'Project.Environment') IS NULL
BEGIN
    CREATE TABLE Project.Environment
    (   
        EnvironmentID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        WeatherID INT NOT NULL FOREIGN KEY REFERENCES Project.Weather(WeatherID),
        LocationID INT NOT NULL FOREIGN KEY REFERENCES Project.Location(LocationID), 
        IsIndoor INT 
    );
END;