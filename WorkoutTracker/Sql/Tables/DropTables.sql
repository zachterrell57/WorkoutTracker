DROP TABLE IF EXISTS Project.Workout;
DROP TABLE IF EXISTS Project.Session;
DROP TABLE IF EXISTS Project.Environment;
DROP TABLE IF EXISTS Project.Weather;
DROP TABLE IF EXISTS Project.Location;
DROP TABLE IF EXISTS Project.DailyMetrics;

CREATE TABLE Project.DailyMetrics
(   
    MetricID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    Date NVARCHAR(32) NOT NULL ,
    Weight FLOAT NOT NULL,     
    SleepDuration FLOAT NOT NULL, 
    Calories FLOAT NOT NULL
);

 CREATE TABLE Project.Location
    (   
        LocationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Name NVARCHAR(32) NOT NULL
    );


CREATE TABLE Project.Environment
(   
    EnvironmentID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
    LocationID INT NOT NULL FOREIGN KEY REFERENCES Project.Location(LocationID), 
    IsIndoor INT 
);


CREATE TABLE Project.Session
(   
    SessionID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,   
    MetricID INT NOT NULL FOREIGN KEY REFERENCES Project.DailyMetrics(MetricID),
    EnviornmentID INT NOT NULL FOREIGN KEY REFERENCES Project.Environment(EnvironmentID),
    StartTime NVARCHAR(32) NOT NULL,
    EndTime NVARCHAR(32) NOT NULL, 
    Rating FLOAT NOT NULL,   
);

CREATE TABLE Project.Workout
(   
    WorkoutID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    SessionID INT NOT NULL FOREIGN KEY REFERENCES Project.Session(SessionID),
    Duration FLOAT NOT NULL,
    AvgHeartRate FLOAT NOT NULL
);

