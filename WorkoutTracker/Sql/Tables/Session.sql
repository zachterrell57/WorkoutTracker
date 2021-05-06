IF OBJECT_ID(N'Project.Session') IS NULL
BEGIN
    CREATE TABLE Project.Session
    (   
        SessionID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,   
        MetricID INT NOT NULL,
        EnvironmentID INT NOT NULL,
        StartTime NVARCHAR(32) NOT NULL,
        EndTime NVARCHAR(32) NOT NULL, 
        Rating FLOAT NOT NULL,   

		CONSTRAINT FK_Project_Session_Project_DailyMetrics FOREIGN KEY(MetricID)
		REFERENCES Project.DailyMetrics(MetricID),

		CONSTRAINT FK_Project_Session_Project_Environment FOREIGN KEY(EnvironmentID)
		REFERENCES Project.Environment(EnvironmentID)
    );
END;