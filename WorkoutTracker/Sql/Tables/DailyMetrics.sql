IF OBJECT_ID(N'Project.DailyMetrics') IS NULL
BEGIN
    CREATE TABLE Project.DailyMetrics
    (   
        MetricID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Date NVARCHAR(32) NOT NULL ,  --Just have user enter in the day?--
        Weight INT NOT NULL,     
        SleepDuration INT NOT NULL, 
        Calories INT NOT NULL
    );
END;