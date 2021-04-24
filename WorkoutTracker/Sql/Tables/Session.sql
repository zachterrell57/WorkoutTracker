IF OBJECT_ID(N'Project.Session') IS NULL
BEGIN
    CREATE TABLE Project.Session
    (   
        SessionID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,   
        MetricID INT NOT NULL FOREIGN KEY REFERENCES Project.DailyMetrics(MetricID),
        EnviornmentID INT NOT NULL FOREIGN KEY REFERENCES Project.Environment(EnvironmentID),
        LastName NVARCHAR(32) NOT NULL,
        StartTime NVARCHAR(10) NOT NULL, --Just putting in a time?--
        EndTime NVARCHAR(10) NOT NULL, 
        Rating INT NOT NULL, --Out of 10, 10 being best?--    
        Date NVARCHAR(32) NOT NULL --Just have user enter in the day?--
    );
END;