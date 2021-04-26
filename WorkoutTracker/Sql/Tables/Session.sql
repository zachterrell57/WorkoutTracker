IF OBJECT_ID(N'Project.Session') IS NULL
BEGIN
    CREATE TABLE Project.Session
    (   
        SessionID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,   
        MetricID INT NOT NULL FOREIGN KEY REFERENCES Project.DailyMetrics(MetricID),
        EnviornmentID INT NOT NULL FOREIGN KEY REFERENCES Project.Environment(EnvironmentID),
        StartTime NVARCHAR(32) NOT NULL, --Just putting in a time?--
        EndTime NVARCHAR(32) NOT NULL, 
        Rating FLOAT NOT NULL, --Out of 10, 10 being best?--    
    );
END;