IF OBJECT_ID(N'Project.DailyMetrics') IS NULL
BEGIN
    CREATE TABLE Project.DailyMetrics
    (   
        MetricID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Date DATETIME(32) NOT NULL ,
        Weight INT NOT NULL,     
        SleepDuration INT NOT NULL, 
        Calories INT NOT NULL
    );
END;