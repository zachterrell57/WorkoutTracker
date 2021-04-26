IF OBJECT_ID(N'Project.DailyMetrics') IS NULL
BEGIN
    CREATE TABLE Project.DailyMetrics
    (   
        MetricID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Date NVARCHAR NOT NULL ,
        Weight FLOAT NOT NULL,     
        SleepDuration FLOAT NOT NULL, 
        Calories FLOAT NOT NULL
    );
END;